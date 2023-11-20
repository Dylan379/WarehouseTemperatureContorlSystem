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
    public partial class FormStoreList : Form
    {
        StoreBLL storeBLL = new StoreBLL();
        public FormStoreList()
        {
            InitializeComponent();
        }


        //页面加载事件
        private void LoadStoreListForm(object sender, EventArgs e)
        {
            //
            isDeletedCheck.Checked = false;
            storeNameInput.Clear();
            LoadStoreList();

        }

        /// <summary>
        /// 查询仓库列表
        /// </summary>
        private void LoadStoreList()
        {
            bool isDeleted = isDeletedCheck.Checked;
            string keyWords = storeNameInput.Text.Trim();
            storeListDGV.ShowDgvCols(isDeleted);//显示操作列
            storeListDGV.Columns["colAddRegion"].Visible = !isDeleted;

            //加载仓库数据
            List<StoreInfoModel> storeList = storeBLL.GetStoreInfos(keyWords, isDeleted);
            if (storeList.Count > 0)
            {
                storeListDGV.AutoGenerateColumns = false;
                storeListDGV.DataSource = storeList;
                SetEnableBtn(true);
            }
            else
            {
                storeListDGV.DataSource = null;
                SetEnableBtn(false);
            }
        }


        private void SetEnableBtn(bool blShow)
        {
            searchBtn.Enabled = blShow;
            deleteBtn.Enabled = blShow;
        }

        private void IsDeletedCheckedChanged(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        private void ClickSearchBtn(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        /// <summary>
        /// 新增仓库信息---打开信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCreatBtn(object sender, EventArgs e)
        {
            ShowStoreInfoPage(1, 0);
        }

        /// <summary>
        /// 打开仓库分区的方式  添加分区
        /// </summary>
        /// <param name="storeId"></param>
        private void ShowStoreRegionInfoPage(int storeId)
        {
            FormStoreRegionInfo formStoreInfo = new FormStoreRegionInfo();
            formStoreInfo.Tag = new FInfoData()
            {
                ActType = 3,
                FId = storeId
            };
            //打开位置
            formStoreInfo.ReLoadStoreList += LoadStoreList;
            formStoreInfo.StartPosition = FormStartPosition.CenterParent;
            formStoreInfo.ShowDialog();

        }



        /// <summary>
        /// 打开仓库信息页的方式   新增,修改使用
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="storeId"></param>
        private void ShowStoreInfoPage(int actType, int storeId)
        {
            FormStoreInfo formStoreInfo = new FormStoreInfo();
            formStoreInfo.Tag = new FInfoData()
            {
                ActType = actType,
                FId = storeId
            };
            //打开位置
            formStoreInfo.ReLoadList += LoadStoreList;
            formStoreInfo.StartPosition = FormStartPosition.CenterParent;
            formStoreInfo.ShowDialog();

        }

        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            //当前点击的单元格
            var cell = storeListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string headText = cell.FormattedValue.ToString();
            StoreInfoModel storeInfoModel = storeListDGV.Rows[e.RowIndex].DataBoundItem as StoreInfoModel;
            switch (headText)
            {
                case "添加分区":
                    //打开添加仓库分区信息页
                    ShowStoreRegionInfoPage(storeInfoModel.StoreId);
                    break;
                case "修改":
                    //打开仓库信息页
                    ShowStoreInfoPage(2, storeInfoModel.StoreId);
                    break;
                case "删除":
                    //逻辑删除
                    DealWithStore(storeInfoModel, 1);
                    break;
                case "恢复":
                    DealWithStore(storeInfoModel, 0);
                    //恢复逻辑删除的信息
                    break;
                case "移除":
                    DealWithStore(storeInfoModel, 2);
                    //真删除
                    break;
            }
        }

        /// <summary>
        /// 处理行内操作  删除---恢复---移除
        /// </summary>
        /// <param name="storeInfoModel"></param>
        /// <param name="code"></param>
        private void DealWithStore(StoreInfoModel storeInfoModel, int code)
        {
            string InfoName = "仓库信息";
            string msgTitle = $"{InfoName}删除";
            string delName = FormUtility.GetDelName(code);
            DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delName}该{InfoName}信息吗?");
            if (dialogResult == DialogResult.Yes)
            {

                bool bl = false;
                switch (code)
                {
                    case 1:
                        int res = storeBLL.LogicDeleteStore(storeInfoModel.StoreId);
                        if (res == 1)
                        {
                            bl = true;
                        }
                        else if (res == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该仓库已添加分区,不能删!除");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = storeBLL.RecoverStore(storeInfoModel.StoreId);
                        break;
                    case 2:
                        bl = storeBLL.DeleteStore(storeInfoModel.StoreId);
                        break;
                }

                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"仓库信息{delName}成功!");
                    LoadStoreList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"仓库信息{delName}失败!");
                    return;
                }
            }
        }


        /// <summary>
        /// 刷新搜索条件相关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFlashBtn(object sender, EventArgs e)
        {
            isDeletedCheck.Checked = false;
            storeNameInput.Clear();
            LoadStoreList();
        }

        /// <summary>
        /// 批量删除仓库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDeleteBtn(object sender, EventArgs e)
        {
            //删除行的编号集合
            List<int> dellds = new List<int>();

            foreach (DataGridViewRow dr in storeListDGV.Rows)
            {
                StoreInfoModel store = dr.DataBoundItem as StoreInfoModel;
                DataGridViewCheckBoxCell checkBoxCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;

                if (checkBoxCell.FormattedValue.ToString() == "True")
                {
                    dellds.Add(store.StoreId);
                }

            }

            if (dellds.Count > 0)
            {
                DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm("仓库信息删除", "您确定要删除选择的信息吗?");
                if (dialogResult == DialogResult.Yes)
                {
                    string res = storeBLL.LogicDeleteStore(dellds);

                    //成功
                    if (res == "Y")
                    {
                        MsgBoxHelper.MsgBoxShow("仓库删除信息", "成功删除选择的仓库信息");
                        LoadStoreList();
                    }
                    else if (res.Length >= 1 && res != "0")//存在分区
                    {
                        MsgBoxHelper.MsgErrorShow("仓库删除信息", "不能删除仍包含分区的仓库,请检查" + res);
                        return;
                    }
                    else  //失败
                    {
                        MsgBoxHelper.MsgErrorShow("仓库删除信息", "删除失败!");
                        return;
                    }

                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("仓库信息删除", "请选择要删除的仓库信息");
            }

        }
    }
}
