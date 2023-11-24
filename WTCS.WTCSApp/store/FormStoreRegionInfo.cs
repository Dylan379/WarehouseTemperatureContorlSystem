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
            actType = 1;
            oldName = "";
            oldNo = "";
            oldStoreId = 0;

        }
    }
}
