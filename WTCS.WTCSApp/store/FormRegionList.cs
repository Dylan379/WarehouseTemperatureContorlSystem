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
using WTCS.Models.VModels;
using WTCS.WTCSApp.FModels;

namespace WTCS.WTCSApp.store
{
    public partial class FormRegionList : Form
    {
        StoreRegionBLL srBLL = new StoreRegionBLL();
        public FormRegionList()
        {
            InitializeComponent();
        }

        private void LoadRegionListPage(object sender, EventArgs e)
        {
            keyWordsInput.Clear();
            isDeletedCheck.Checked = false;
            //加载仓库下拉框 
            FormUtility.LoadComboBoxStores(storeComboBox);
            //加载状态下拉框
            LaodCboStates();
            //加载所有仓库分区信息
            FindStoreRegionList();
        }

        private void LaodCboStates()
        {
            List<RegionStateModel> stateList = FormUtility.RegionStateList();
            stateComboBox.DisplayMember = "StateText";
            stateComboBox.ValueMember = "RegionState";
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedIndex = 0;
        }


        private void FindStoreRegionList()
        {
            int storeId = storeComboBox.SelectedValue.GetInt();
            int stateId = stateComboBox.SelectedValue.GetInt();
            string keywords = keyWordsInput.Text.Trim();
            bool showDel = isDeletedCheck.Checked;
            storeRegionListDGV.ShowDgvCols(showDel);//显示操作列

            List<ViewStoreRegionInfo> regionList = srBLL.FindStoreRegionList(storeId,
                                                                             stateId,
                                                                            keywords,
                                                                            showDel);
            if (regionList.Count > 0)
            {
                storeRegionListDGV.AutoGenerateColumns = false;
                storeRegionListDGV.DataSource = regionList;
                SetEnableBtn(true);
            }
            else
            {
                storeRegionListDGV.DataSource = null;
                SetEnableBtn(false);
            }

        }

        private void SetEnableBtn(bool showDel)
        {
            deleteBtn.Enabled = showDel;
            //searchBtn.Enabled = showDel;
        }

        private void ClickSearchBtn(object sender, EventArgs e)
        {
            FindStoreRegionList();
        }

        private void ChangedDeleteCheckValue(object sender, EventArgs e)
        {
            FindStoreRegionList();
        }
    }
}
