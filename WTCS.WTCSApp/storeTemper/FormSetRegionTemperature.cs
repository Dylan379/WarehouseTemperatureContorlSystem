using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.BLL;
using WTCS.WTCSApp.FModels;
using WTCS.WTCSApp.UControls;

namespace WTCS.WTCSApp.storeTemper
{
    public partial class FormSetRegionTemperature : Form
    {
        public FormSetRegionTemperature()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        SRegionTemperBLL rtBLL = new SRegionTemperBLL();
        //刷新列表页该分区的温度与状态
        public event Action<object, UStoreRegionArgs> ReloadRegion;

        RegionTemperData regionData = null;//分区信息
        int isCompleted = -1;

        private void PageLoad(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                regionData = this.Tag as RegionTemperData;//分区对象
                if (regionData != null)
                {
                    if (regionData.TemperState == 0)
                        setTypeLabel.Text = "升温";
                    else
                        setTypeLabel.Text = "降温";
                }
                InitSetWays();
                targetTemperUpdown.Value = 0;
            }
        }

        private void InitSetWays()
        {
            changeTemperCheckList.Items.Clear();
            if (regionData.TemperState == 0)
            {
                changeTemperCheckList.Items.Add("打开热风");
                changeTemperCheckList.Items.Add("打开暖气");
                changeTemperCheckList.Items.Add("关闭窗户");
            }
            else
            {
                changeTemperCheckList.Items.Add("打开冷风");
                changeTemperCheckList.Items.Add("关闭暖气");
                changeTemperCheckList.Items.Add("打开窗户");
            }



        }

        private void ClickComfirmBtn(object sender, EventArgs e)
        {

            isCompleted = 0;//开始调温
            decimal srTemper = targetTemperUpdown.Value;//目标室温
            string msgTitle = "调整分区温度";
            if (regionData.Lowtemperature > srTemper)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "目标温度低于当前分区最低温度要求!");
                return;
            }
            else if (regionData.HighTemperature < srTemper)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "目标温度高于当前分区最低温度要求!");
                return;
            }
            if (changeTemperCheckList.CheckedItems.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请设置调温方法!");
                return;
            }

            //开始调温处理
            Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    msgListBox.Items.Add($"开始{setTypeLabel.Text}处理");
                }));
                //Thread.Sleep(5000);
                //室温已调整到目标值
                //写入设备中 从站中
                if (rtBLL.SetSRTemperature(regionData.SId, srTemper))
                {
                    Invoke(new Action(() =>
                    {
                        msgListBox.Items.Add($"已写入设备中");
                    }));
                    Thread.Sleep(1000);
                    //更新仓库信息分区表
                    bool blUpdate = rtBLL.UpdateSRTemperatureById(regionData.SRegionId, srTemper);
                    if (blUpdate)
                    {
                        isCompleted = 1;
                        this.Invoke(new Action(() =>
                        {
                            UStoreRegionArgs args = new UStoreRegionArgs(regionData.SRegionId, 1, srTemper);
                            ReloadRegion?.Invoke(this, args);//刷新列表页该分区的温度
                            msgListBox.Items.Add($"{setTypeLabel.Text}工作已完成，稍后自动关闭！");

                        }));
                        Thread.Sleep(2000);
                        this.Invoke(new Action(() =>
                        {
                            Close();//关闭本页

                        }));
                    }
                }
            });
        }

        /// <summary>
        /// 取消按钮处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCancelBtn(object sender, EventArgs e)
        {
            if (isCompleted == -1 || isCompleted == 1)
                Close();
            else
            {
                MsgBoxHelper.MsgErrorShow("调整分区温度", "正在调温中，不能关闭页面！");
                return;
            }
        }


        /// <summary>
        /// 页面关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (isCompleted == 0)
            {
                MsgBoxHelper.MsgErrorShow("调整分区温度", "正在调温中，不能关闭页面！");
                e.Cancel = true;
                return;
            }
        }
    }
}
