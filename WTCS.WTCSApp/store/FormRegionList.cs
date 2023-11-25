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

        /// <summary>
        /// 点击单元格内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            //当前点击的单元格
            var cell = storeRegionListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string headText = cell.FormattedValue.ToString();
            //分区数据对象
            ViewStoreRegionInfo regionInfo = storeRegionListDGV.Rows[e.RowIndex].DataBoundItem as ViewStoreRegionInfo;
            switch (headText)
            {
                case "修改":
                    //打开仓库分区信息页
                    ShowStoreRegionInfoPage(2, regionInfo.SRegionId);
                    break;
                case "删除":
                    //逻辑删除
                    DealWithStoreRegion(regionInfo, 1);
                    break;
                case "恢复":
                    DealWithStoreRegion(regionInfo, 0);
                    //恢复逻辑删除的信息
                    break;
                case "移除":
                    DealWithStoreRegion(regionInfo, 2);
                    //真删除
                    break;
            }
        }

        /// <summary>
        /// 仓库分区删除,恢复,移除操作
        /// </summary>
        /// <param name="regionInfo"></param>
        /// <param name="v"></param>
        private void DealWithStoreRegion(ViewStoreRegionInfo regionInfo, int isDeleted)
        {
            string InfoName = "仓库分区信息";
            string delName = FormUtility.GetDelName(isDeleted);
            string msgTitle = $"{InfoName}{delName}";
            DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delName}该{InfoName}信息吗?");
            if (dialogResult == DialogResult.Yes)
            {

                bool bl = false;
                switch (isDeleted)
                {
                    case 1:
                        int res = srBLL.LogicDeleteStoreRegion(regionInfo.SRegionId, regionInfo.StoreId);
                        if (res == 1)
                        {
                            bl = true;
                        }
                        else if (res == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该仓库已添加产品,不能删除!");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = srBLL.RecoverStoreRegion(regionInfo.SRegionId, regionInfo.StoreId);
                        break;
                    case 2:
                        bl = srBLL.DeleteStoreRegion(regionInfo.SRegionId, regionInfo.StoreId);
                        break;
                }

                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"{InfoName}{delName}成功!");
                    FindStoreRegionList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"{InfoName}{delName}失败!");
                    return;
                }
            }
        }

        /// <summary>
        /// 打开分区信息页面
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="sRegionId"></param>
        private void ShowStoreRegionInfoPage(int actType, int sRegionId)
        {
            FormStoreRegionInfo formStoreInfo = new FormStoreRegionInfo();
            formStoreInfo.Tag = new FInfoData()
            {
                ActType = actType,
                FId = sRegionId
            };
            //打开位置
            formStoreInfo.ReLoadList += FindStoreRegionList;
            formStoreInfo.StartPosition = FormStartPosition.CenterParent;
            formStoreInfo.ShowDialog();
        }


        /// <summary>
        /// 点击新增分区按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCreatBtn(object sender, EventArgs e)
        {
            ShowStoreRegionInfoPage(1, 0);
        }

        /// <summary>
        /// 批量删除仓库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDeleteBtn(object sender, EventArgs e)
        {
            //删除行的编号集合
            List<StoreRegionInfoModel> delRegions = new List<StoreRegionInfoModel>();

            foreach (DataGridViewRow dr in storeRegionListDGV.Rows)
            {
                ViewStoreRegionInfo region = dr.DataBoundItem as ViewStoreRegionInfo;
                DataGridViewCheckBoxCell checkBoxCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;

                if (checkBoxCell.FormattedValue.ToString() == "True")
                {
                    delRegions.Add(new StoreRegionInfoModel() { SRegionId = region.SRegionId, StoreId = region.StoreId });
                }

            }

            if (delRegions.Count > 0)
            {
                DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm("分区信息删除", "您确定要删除选择的分区信息吗?");
                if (dialogResult == DialogResult.Yes)
                {
                    string res = srBLL.LogicDeleteStoreRegion(delRegions);

                    //成功
                    if (res == "Y")
                    {
                        MsgBoxHelper.MsgBoxShow("分区删除信息", "成功删除选择的分区信息");
                        FindStoreRegionList();
                    }
                    else if (res.Length >= 1 && (res != "Y" || res != "0"))//存在分区
                    {
                        MsgBoxHelper.MsgErrorShow("分区删除信息", "不能删除仍包含产品的分区,请检查" + res);
                        return;
                    }
                    else  //失败
                    {
                        MsgBoxHelper.MsgErrorShow("分区删除信息", "删除失败!");
                        return;
                    }

                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("分区信息删除", "请选择要删除的分区信息");
            }

        }

        /// <summary>
        /// 点击刷新按钮事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFlashBtn(object sender, EventArgs e)
        {
            storeComboBox.SelectedIndex = 0;
            stateComboBox.SelectedIndex = 0;
            keyWordsInput.Clear();
            isDeletedCheck.Checked = false;
            FindStoreRegionList();
        }
    }
}
