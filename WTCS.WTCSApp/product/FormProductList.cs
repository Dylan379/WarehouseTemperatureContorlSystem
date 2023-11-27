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

namespace WTCS.WTCSApp.product
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        ProductBLL pBLL = new ProductBLL();
        private void LoadProductListPage(object sender, EventArgs e)
        {
            productNameInput.Clear();
            isDeletedCheck.Checked = false;
            FindProductList();
        }

        private void FindProductList()
        {
            string keywords = productNameInput.Text.Trim();
            bool isDeletedChecked = isDeletedCheck.Checked;
            List<ProductInfoModel> productList = pBLL.GetProductList(keywords, isDeletedChecked);
            productListDGV.ShowDgvCols(isDeletedChecked);
            if (productList.Count > 0)
            {
                productListDGV.AutoGenerateColumns = false;
                productListDGV.DataSource = productList;
                deleteBtn.Enabled = true;
            }
            else
            {
                productListDGV.DataSource = null;
                deleteBtn.Enabled = false;
            }

        }

        private void ChangeIsDeletedCheck(object sender, EventArgs e)
        {
            FindProductList();
        }

        private void ClickSearchBtn(object sender, EventArgs e)
        {
            FindProductList();
        }

        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            var currentCell = productListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string currentValue = currentCell.FormattedValue.ToString();
            ProductInfoModel productInfo = productListDGV.Rows[e.RowIndex].DataBoundItem as ProductInfoModel;
            switch (currentValue)
            {
                case "修改":
                    ShowProductInfoPage(2, productInfo.ProductId);
                    break;
                case "删除":
                    DeleteProduct(productInfo.ProductId, 1);
                    break;
                case "恢复":
                    DeleteProduct(productInfo.ProductId, 0);
                    break;
                case "移除":
                    DeleteProduct(productInfo.ProductId, 0);
                    break;
            }


        }

        /// <summary>
        /// 删除/恢复/移除产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="isDeleted></param>
        private void DeleteProduct(int productId, int isDeleted)
        {
            string InfoName = "产品信息";
            string delName = FormUtility.GetDelName(isDeleted);
            string msgTitle = $"{InfoName}{delName}";
            DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delName}该{InfoName}信息吗?");
            if (dialogResult == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1:
                        int res = pBLL.LogicDeleteProduct(productId);
                        if (res == 1)
                        {
                            bl = true;
                        }
                        else if (res == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该分区已添加产品,不能删除");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = pBLL.RecoverProduct(productId);
                        break;
                    case 2:
                        bl = pBLL.DeleteProduct(productId);
                        break;
                }

                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"仓库信息{delName}成功!");
                    FindProductList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"仓库信息{delName}失败!");
                    return;
                }
            }
        }


        /// <summary>
        /// 显示产品信息页
        /// </summary>
        /// <param name="v"></param>
        /// <param name="productId"></param>
        private void ShowProductInfoPage(int actType, int productId)
        {
            FormProductInfo formProductInfo = new FormProductInfo();
            formProductInfo.Tag = new FInfoData()
            {
                ActType = actType,
                FId = productId
            };
            //打开位置
            formProductInfo.ReLoadList += FindProductList;
            formProductInfo.StartPosition = FormStartPosition.CenterParent;
            formProductInfo.ShowDialog();
        }

        private void ClickCreatBtn(object sender, EventArgs e)
        {
            ShowProductInfoPage(1, 0);
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

            foreach (DataGridViewRow dr in productListDGV.Rows)
            {
                ProductInfoModel product = dr.DataBoundItem as ProductInfoModel;
                DataGridViewCheckBoxCell checkBoxCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;

                if (checkBoxCell.FormattedValue.ToString() == "True")
                {
                    dellds.Add(product.ProductId);
                }

            }

            if (dellds.Count > 0)
            {
                DialogResult dialogResult = MsgBoxHelper.MsgBoxConfirm("产品信息删除", "您确定要删除选择的信息吗?");
                if (dialogResult == DialogResult.Yes)
                {
                    string res = pBLL.LogicDeleteProduct(dellds);

                    //成功
                    if (res == "Y")
                    {
                        MsgBoxHelper.MsgBoxShow("产品信息删除", "成功删除选择的产品信息");
                        FindProductList();
                    }
                    else if (res.Length >= 1 && res != "0")//存在分区
                    {
                        MsgBoxHelper.MsgErrorShow("产品信息删除", "不能删除仍包含库存的产品,请检查" + res);
                        return;
                    }
                    else  //失败
                    {
                        MsgBoxHelper.MsgErrorShow("产品信息删除", "删除失败!");
                        return;
                    }

                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("产品信息删除", "请选择要删除的产品信息");
            }

        }

        private void ClickFlashBtn(object sender, EventArgs e)
        {
            isDeletedCheck.Checked = false;
            productNameInput.Clear();
            FindProductList();
        }
    }
}
