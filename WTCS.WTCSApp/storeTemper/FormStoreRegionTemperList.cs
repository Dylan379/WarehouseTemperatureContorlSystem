using Common;
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
using WTCS.Models.UIModels;
using WTCS.WTCSApp.FModels;
using WTCS.WTCSApp.UControls;

namespace WTCS.WTCSApp.storeTemper
{
    public partial class FormStoreRegionTemperList : Form
    {
        public FormStoreRegionTemperList()
        {
            InitializeComponent();
        }
        SRegionTemperBLL rtBLL = new SRegionTemperBLL();

        private void uPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        /// <summary>
        /// 查询分区盒子列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadStoreTemperControlPage(object sender, EventArgs e)
        {
            //加载仓库列表下拉框
            FormUtility.LoadComboBoxStores(storeComboBox);
            messageLable.Text = "";
            LoadSRegionBoxList();
        }

        private void LoadSRegionBoxList()
        {
            int storeId = storeComboBox.SelectedValue.GetInt();
            List<StoreRegionBoxModel> boxList = rtBLL.FindRegionBoxList(storeId);

            //将boxList包装成分区盒子,显示在列表中
            ShowSRegionBoxList(boxList);


        }

        private void ShowSRegionBoxList(List<StoreRegionBoxModel> boxList)
        {
            regionListFLP.Controls.Clear();
            if (boxList.Count > 0)
            {
                foreach (StoreRegionBoxModel box in boxList)
                {
                    UStoreRegionBox rBox = new UStoreRegionBox();
                    rBox.UBoxSource = box;
                    if (box.TemperState != 1)
                    {
                        //就会显示升温或者降温按钮
                        rBox.SetTemperature += SetTemperature;
                    }
                    rBox.Margin = new Padding(10, 20, 10, 20);
                    regionListFLP.Controls.Add(rBox);
                }
            }
        }



        /// <summary>
        /// 温度调整事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetTemperature(object sender, UStoreRegionArgs e)
        {
            FormSetRegionTemperature formSetTemper = new FormSetRegionTemperature();
            formSetTemper.Tag = new RegionTemperData()
            {
                SRegionId = e.SRegionId,
                TemperState = e.TemperState,
                Lowtemperature = e.Lowtemperature,
                HighTemperature = e.HighTemperature,
                SId = e.SId
            };

            //订阅刷新事件
            formSetTemper.ReloadRegion += ReloadRegion;
            formSetTemper.Show();
        }

        private void ReloadRegion(object sender, UStoreRegionArgs e)
        {
            foreach (Control item in regionListFLP.Controls)
            {
                UStoreRegionBox uBox = item as UStoreRegionBox;
                if (uBox.SRegionId == e.SRegionId)
                {
                    uBox.SRTemper = e.SRTemperature;
                    uBox.TemperState = e.TemperState;
                    break;
                }
            }
        }

        private void ClickTestBtn(object sender, EventArgs e)
        {
            messageLable.ForeColor = Color.White;
            //显示消息
            Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    messageLable.Text = "开始读取温度数据...";
                }));
                Thread.Sleep(2000);
                //读取数据

                try
                {
                    Invoke(new Action(() =>
                    {
                        messageLable.Text = "读取中...";
                        //读取温度数据
                        List<StoreRegionBoxModel> boxList = rtBLL.ReadRegionTemperData();
                        if (boxList != null)
                        {
                            ShowSRegionBoxList(boxList);
                            messageLable.Text = "读取完成!";
                        }
                        else
                        {
                            messageLable.Text = "读取失败,请检查设备!";
                            messageLable.ForeColor = Color.Red;
                        }
                    }));
                }
                catch (Exception ex)
                {
                    MsgBoxHelper.MsgErrorShow("读取温度数据失败", ex.Message);
                }
            });


        }

        private void storeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSRegionBoxList();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFlashBtn(object sender, EventArgs e)
        {
            storeComboBox.SelectedIndex = 0;
            messageLable.Text = "";
            LoadSRegionBoxList();
        }
    }
}
