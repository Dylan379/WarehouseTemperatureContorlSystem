using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.BLL;
using WTCS.Models.DModels;
using WTCS.WTCSApp.FModels;

namespace WTCS.WTCSApp.store
{
    public partial class FormStoreRegionInfo : Form
    {
        public FormStoreRegionInfo()
        {
            InitializeComponent();
        }

        private StoreRegionBLL srBLL = new StoreRegionBLL();
        public event Action ReLoadStoreList;//刷新仓库管理列表页数据

        public event Action ReLoadList;//刷新仓库分区管理列表页数据
        private FInfoData fInfo = null;
        int actType = 1;//当前页面状态标识
        string oldName = "";//修改前名称
        string oldNo = "";//修改前编号
        int regionId = 0;//当前修改的仓库编号
        int oldStoreId = 0;//修改前的仓库编号
        private void LoadStoreRegionForm(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                fInfo = Tag as FInfoData;
                InitStoreRegionInfo();
            }
        }

        /// <summary>
        /// 初始化页面信息
        /// </summary>
        private void InitStoreRegionInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                FormUtility.LoadComboBoxStores(storeNameComboBox);
                switch (actType)
                {

                    case 1:
                        TemperPanel.Visible = false;
                        resetBtn.Enabled = true;
                        ResetInputs();
                        Text += "---新增";
                        break;
                    case 2:
                        TemperPanel.Visible = true;
                        regionId = fInfo.FId;
                        //加载仓库信息
                        resetBtn.Enabled = false;
                        GetRegionInfo();
                        Text += "---修改";
                        saveBtn.Text = "修改";
                        break;
                    case 3:
                        TemperPanel.Visible = false;
                        resetBtn.Enabled = true;
                        ResetInputs();
                        storeNameComboBox.SelectedValue = fInfo.FId;//仓库编号
                        storeNameComboBox.Enabled = false;
                        Text += "---新增";
                        break;
                }
            }
        }


        /// <summary>
        /// 加载分区
        /// </summary>
        private void GetRegionInfo()
        {
            StoreRegionInfoModel storeRegionInfo = srBLL.GetSRegionInfo(regionId);
            if (storeRegionInfo != null)
            {
                regionNameInput.Text = storeRegionInfo.SRegionName;
                regionNoInput.Text = storeRegionInfo.SRegionNo;
                storeNameComboBox.SelectedValue = storeRegionInfo.StoreId;
                currentTemperatureInput.Text =
                                                storeRegionInfo.SRTemperature ==
                                                null ? "" : storeRegionInfo.SRTemperature.Value.ToString();
                allowLowestTemperInput.Text =
                                                storeRegionInfo.AllowLowestTemperature ==
                                                null ? "" : storeRegionInfo.AllowLowestTemperature.Value.ToString();
                allowHighestTemperInput.Text =
                                                storeRegionInfo.AllowHighestTemperature ==
                                                null ? "" : storeRegionInfo.AllowHighestTemperature.Value.ToString();
                regionRemarkInput.Text = storeRegionInfo.Remark;
                oldName = storeRegionInfo.SRegionName;
                oldNo = storeRegionInfo.SRegionNo;
                oldStoreId = storeRegionInfo.StoreId;

            }
        }

        /// <summary>
        /// 页面清空
        /// </summary>
        private void ResetInputs()
        {
            //allowHighestTemperInput.Clear(); ;
            //allowLowestTemperInput.Clear();
            currentTemperatureInput.Clear(); ;
            regionNoInput.Clear();
            regionNameInput.Clear();
            regionRemarkInput.Clear();
            storeNameComboBox.SelectedIndex = 0;
            if (actType == 3)
            {
                storeNameComboBox.SelectedValue = fInfo.FId;
            }
            // actType = 1;
            oldName = "";
            oldNo = "";
            oldStoreId = 0;

        }

        private void ClickSaveBtn(object sender, EventArgs e)
        {
            //信息接收
            string msgTitle = "分区信息提交";
            string regionName = regionNameInput.Text.Trim();
            string regionNo = regionNoInput.Text.Trim();
            int storeId = storeNameComboBox.SelectedValue.GetInt();
            decimal? currentTemperature = null;
            if (!string.IsNullOrEmpty(currentTemperatureInput.Text))
                currentTemperature = currentTemperatureInput.Text.GetDecimal();
            decimal? lowestTemperature = null, highestTemperature = null;
            int regionTemperState = 1;
            if (actType == 2)
            {
                if (!string.IsNullOrEmpty(allowLowestTemperInput.Text))
                    lowestTemperature = allowLowestTemperInput.Text.GetDecimal();
                if (!string.IsNullOrEmpty(allowHighestTemperInput.Text))
                    highestTemperature = allowHighestTemperInput.Text.GetDecimal();
                if (lowestTemperature != null &&
                    highestTemperature != null &&
                    lowestTemperature > highestTemperature)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "温度信息设置异常,请检查");
                    allowLowestTemperInput.Focus();
                    return;
                }
                else if (lowestTemperature != null &&
                        currentTemperature != null &&
                        lowestTemperature > currentTemperature)
                {
                    regionTemperState = 0;//低温状态
                }
                else if (highestTemperature != null &&
                        currentTemperature != null &&
                        currentTemperature > highestTemperature)
                {
                    regionTemperState = 2;//高温状态
                }
            }
            string remark = regionRemarkInput.Text.Trim();


            if (string.IsNullOrEmpty(regionName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "分区名称不能为空!");
                regionNameInput.Focus();
                return;
            }
            if (storeId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择所属仓库!");
                storeNameComboBox.Focus();
                return;
            }
            //判断数据存在性
            //新增   或   修改
            if (regionId == 0 || (regionId > 0 && (oldName != regionName || oldNo != regionNo)))
            {
                int intBl;
                if (regionId > 0)
                {
                    if (oldName == regionName)
                        intBl = srBLL.ExistsStore("", regionNo);
                    else if (oldNo == regionNo)
                        intBl = srBLL.ExistsStore(regionName, "");
                    else
                        intBl = srBLL.ExistsStore(regionName, regionNo);
                }
                else
                    intBl = srBLL.ExistsStore(regionName, regionNo);
                switch (intBl)
                {
                    case 1://Name存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "存在相同名称的分区，请检查！");
                        return;
                    case 2://No存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "存在相同编号的分区，请检查！");
                        return;
                    case 3://都存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该分区已存在，请检查！");
                        return;
                    case 0:
                        break;
                }
                if (intBl > 0)
                    return;
            }
            //分区信息封装
            StoreRegionInfoModel storeRegionInfo = new StoreRegionInfoModel()
            {
                SRegionId = regionId,
                SRegionName = regionName,
                SRegionNo = regionNo,
                SRTemperature = currentTemperature,
                Remark = remark,
                StoreId = storeId,
                TemperState = regionTemperState
            };
            if (actType == 2)
            {
                if (lowestTemperature != null)
                    storeRegionInfo.AllowLowestTemperature = lowestTemperature;
                if (highestTemperature != null)
                    storeRegionInfo.AllowHighestTemperature = highestTemperature;
            }

            //提交
            bool saveState = false;
            if (actType == 1 || actType == 3)
            {
                int newRegionId = srBLL.AddStoreRegionWithId(storeRegionInfo);//新分区编号
                if (newRegionId > 0)
                {
                    saveState = true;
                    regionId = newRegionId;

                }
            }
            else//修改
            {
                if (storeId != oldStoreId)
                    saveState = srBLL.UpdateStoreRegion(storeRegionInfo, oldStoreId);
                else
                    saveState = srBLL.UpdateStoreRegion(storeRegionInfo);
            }

            string actName = actType != 2 ? "新增" : "修改";
            if (saveState)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, $"{regionName}仓库分区信息{actName}成功!");
                if (actType == 1)
                {
                    actType = 2;
                    saveBtn.Text = "修改";
                    oldName = regionName;
                    oldNo = regionNo;
                }
                if (actType == 3)
                {
                    ReLoadStoreList?.Invoke();
                }
                else
                {
                    ReLoadList?.Invoke();
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, $"{regionName}仓库分区信息{actName}失败!");
                return;
            }


        }

        private void ClickResetBtn(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void ClickBackBtn(object sender, EventArgs e)
        {
            Close();
        }
    }
}
