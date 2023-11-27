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

namespace WTCS.WTCSApp.product
{
    public partial class FormProductInfo : Form
    {
        public FormProductInfo()
        {
            InitializeComponent();
        }

        public event Action ReLoadList;
        private FInfoData fInfo = null;
        ProductBLL pBLL = new ProductBLL();
        int actType = 1;
        int productId = 0;
        string oldName = "";//原来的产品名称
        string oldNo = "";//原来的产品编号
        private void LoadProductInfoPage(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                fInfo = Tag as FInfoData;
            }
            InitPageInfo();

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
                    productId = fInfo.FId;
                    //加载仓库信息
                    resetBtn.Enabled = false;
                    GetProduct();
                    Text += "---修改";
                }
            }
        }

        /// <summary>
        /// 加载指定的产品信息
        /// </summary>
        private void GetProduct()
        {
            ProductInfoModel productInfo = pBLL.GetProductInfo(productId);
            if (productInfo != null)
            {
                productNameInput.Text = productInfo.ProductName;
                productNoInput.Text = productInfo.ProductNo;
                fitHighestTemperatureInput.Text = productInfo.FitHighestTemperature.ToString();
                fitLowestTemperatureInput.Text = productInfo.FitLowestTemperature.ToString();
                oldName = productInfo.ProductName;
                oldNo = productInfo.ProductNo;
            }
        }


        /// <summary>
        /// 清空处理
        /// </summary>
        private void ResetInputs()
        {
            productNameInput.Clear();
            productNoInput.Clear();
            fitHighestTemperatureInput.Clear();
            fitLowestTemperatureInput.Clear();
            productId = 0;
            actType = 1;
            oldName = "";
            oldNo = "";
        }

        private void ClickSaveBtn(object sender, EventArgs e)
        {
            string saveType = actType == 1 ? "新增" : "修改";
            //接收
            string productName = productNameInput.Text.Trim();
            string productNo = productNoInput.Text.Trim();
            decimal? fitLowestTemperature = null;
            if (!string.IsNullOrEmpty(fitLowestTemperatureInput.Text))
                fitLowestTemperature = fitLowestTemperatureInput.Text.GetDecimal();
            decimal? fitHighestTemperature = null;
            if (!string.IsNullOrEmpty(fitHighestTemperatureInput.Text))
                fitHighestTemperature = fitHighestTemperatureInput.Text.GetDecimal();
            //判断
            if (string.IsNullOrEmpty(productName))
            {
                MsgBoxHelper.MsgErrorShow($"{actType}产品信息", "产品名称不能为空！");
                productNameInput.Focus();
                return;
            }
            if (productId == 0 || (productId > 0 && (oldName != productName || oldNo != productNo)))
            {
                int intBl;
                if (productId > 0)
                {
                    if (oldName == productName)
                        intBl = pBLL.ExistsProduct("", productNo);
                    else if (oldNo == productNo)
                        intBl = pBLL.ExistsProduct(productName, "");
                    else
                        intBl = pBLL.ExistsProduct(productName, productNo);
                }
                else
                    intBl = pBLL.ExistsProduct(productName, productNo);
                switch (intBl)
                {
                    case 1://Name存在
                        MsgBoxHelper.MsgErrorShow($"{actType}产品信息", "存在相同名称的产品，请检查！");
                        return;
                    case 2://No存在
                        MsgBoxHelper.MsgErrorShow($"{actType}产品信息", "存在相同编号的产品，请检查！");
                        return;
                    case 3://都存在
                        MsgBoxHelper.MsgErrorShow($"{actType}产品信息", "该产品已存在，请检查！");
                        return;
                    case 0:
                        break;
                }
                if (intBl > 0)
                    return;
            }

            if (fitLowestTemperature == null ||
                fitHighestTemperature == null ||
                fitLowestTemperature > fitHighestTemperature)
            {
                MsgBoxHelper.MsgErrorShow($"{actType}产品信息", "温度有空值或范围有误！");
                return;
            }

            ProductInfoModel productInfo = new ProductInfoModel
            {
                ProductId = productId,
                ProductName = productName,
                ProductNo = productNo,
                FitHighestTemperature = fitHighestTemperature,
                FitLowestTemperature = fitLowestTemperature
            };
            //提交
            if (actType == 1)
            {
                int newProductId = pBLL.AddProductInfoReturnId(productInfo);
                if (newProductId > 0)
                {
                    MsgBoxHelper.MsgBoxShow($"{saveType}产品信息", $"产品：{productName} 信息新增成功！");
                    productId = newProductId;
                    actType = 2;
                    oldName = productName;
                    oldNo = productNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"{saveType}产品信息", $"产品：{productName} 信息新增失败！");
                    return;
                }
            }
            else
            {
                bool res = pBLL.UpdateProductInfo(productInfo);
                if (res)
                {
                    MsgBoxHelper.MsgBoxShow($"{saveType}产品信息", $"产品：{productName} 信息{saveType}成功！");
                    oldName = productName;
                    oldNo = productNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"{saveType}产品信息", $"产品：{productName} 信息{saveType}失败！");
                    return;
                }
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
