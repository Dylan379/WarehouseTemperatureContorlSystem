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
    public partial class FormStoreInfo : Form
    {
        public FormStoreInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 刷新列表页数据
        /// </summary>
        public event Action ReLoadList;
        public StoreBLL storeBLL = new StoreBLL();
        public FInfoData fInfo = null;
        int storeId = 0;//当前修改仓库编号
        string oldName = "";//修改前名称
        string oldNo = "";//修改前编号
        int actType = 1;//新增
        private void LoadStoreInfoPage(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                fInfo = Tag as FInfoData;
                InitPageInfo();

            }



        }

        private void InitPageInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                if (actType == 1)
                {
                    resetBtn.Enabled = true;
                    ResetInputs();
                    Text += "---新增";
                }
                else//修改
                {
                    storeId = fInfo.FId;
                    //加载仓库信息
                    resetBtn.Enabled = false;
                    GetStore();
                    Text += "---修改";
                }
            }
        }

        /// <summary>
        /// 加载仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        private void GetStore()
        {
            StoreInfoModel storeInfoModel = storeBLL.GetStore(storeId);
            if (storeInfoModel != null)
            {
                storeNameInput.Text = storeInfoModel.StoreName;
                storeNoInput.Text = storeInfoModel.StoreNo;
                storeRemarkInput.Text = storeInfoModel.Remark;
                oldName = storeInfoModel.StoreName;
                oldNo = storeInfoModel.StoreNo;
            }


        }


        /// <summary>
        /// 清空处理
        /// </summary>
        private void ResetInputs()
        {
            storeNameInput.Clear();
            storeNoInput.Clear();
            storeRemarkInput.Clear();
            actType = 1;
            oldName = "";
            oldNo = "";
        }

        /// <summary>
        /// 清空按钮点击处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRestBtn(object sender, EventArgs e)
        {
            ResetInputs();
        }


        /// <summary>
        /// 返回按钮点击处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBackBtn(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// 点击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSaveBtn(object sender, EventArgs e)
        {

            string saveType = actType == 1 ? "新增" : "修改";
            //信息接收
            string storeName = storeNameInput.Text.Trim();
            string storeNo = storeNoInput.Text.Trim();
            string remark = storeRemarkInput.Text.Trim();

            //判断非空
            if (string.IsNullOrEmpty(storeName))
            {
                MsgBoxHelper.MsgErrorShow($"{actType}仓库信息", "仓库名称不能为空");
                storeNameInput.Focus();
                return;
            }
            //判断数据存在性
            //新增   或   修改
            if (storeId == 0 || (storeId > 0 && (oldName != storeName || oldNo != storeNo)))
            {
                int intBl;
                if (storeId > 0)
                {
                    if (oldName == storeName)
                        intBl = storeBLL.ExistsStore("", storeNo);
                    else if (oldNo == storeNo)
                        intBl = storeBLL.ExistsStore(storeName, "");
                    else
                        intBl = storeBLL.ExistsStore(storeName, storeNo);
                }
                else
                    intBl = storeBLL.ExistsStore(storeName, storeNo);
                switch (intBl)
                {
                    case 1://Name存在
                        MsgBoxHelper.MsgErrorShow($"{actType}仓库信息", "存在相同名称的仓库，请检查！");
                        return;
                    case 2://No存在
                        MsgBoxHelper.MsgErrorShow($"{actType}仓库信息", "存在相同编号的仓库，请检查！");
                        return;
                    case 3://都存在
                        MsgBoxHelper.MsgErrorShow($"{actType}仓库信息", "该仓库已存在，请检查！");
                        return;
                    case 0:
                        break;
                }

            }
            //信息的封装 
            StoreInfoModel storeInfo = new StoreInfoModel()
            {
                StoreId = storeId,
                StoreName = storeName,
                StoreNo = storeNo,
                Remark = remark
            };

            //信息提交
            if (actType == 1)
            {
                int newStoreId = storeBLL.AddStoreGetId(storeInfo);
                if (newStoreId > 0)
                {
                    MsgBoxHelper.MsgBoxShow($"{saveType}仓库信息", $"仓库：{storeName} 信息新增成功！");
                    storeId = newStoreId;
                    actType = 2;
                    oldName = storeName;
                    oldNo = storeNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"{saveType}仓库信息", $"仓库：{storeName} 信息新增失败！");
                    return;
                }
            }
            else
            {
                bool res = storeBLL.UpdateStore(storeInfo);
                if (res)
                {
                    MsgBoxHelper.MsgBoxShow($"{saveType}仓库信息", $"仓库：{storeName} 信息{saveType}成功！");
                    oldName = storeName;
                    oldNo = storeNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"{saveType}仓库信息", $"仓库：{storeName} 信息{saveType}失败！");
                    return;
                }
            }

        }
    }
}
