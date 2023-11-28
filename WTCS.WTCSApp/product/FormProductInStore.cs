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

namespace WTCS.WTCSApp.product
{
    public partial class FormProductInStore : Form
    {
        public FormProductInStore()
        {
            InitializeComponent();
        }
        ProductBLL pBLL = new ProductBLL();
        StoreRegionBLL srBLL = new StoreRegionBLL();
        List<ViewProductStoreInfo> records = new List<ViewProductStoreInfo>();
        Color selColor = Color.FromArgb(50, 10, 255);
        Color unSelColor = Color.FromArgb(50, 122, 200);
        private void LoadProductInStorePage(object sender, EventArgs e)
        {

            LoadProductCobx();
            FormUtility.LoadComboBoxStores(inStoreNameCobx);
            productInStoresDGV.AutoGenerateColumns = false;
            productInStoresDGV.DataSource = records;
            inStoreCountUpDown.Value = 0;

        }

        /// <summary>
        /// 加载产品下拉框
        /// </summary>
        private void LoadProductCobx()
        {
            List<ProductInfoModel> list = pBLL.GetAllProducts();
            list.Insert(0, new ProductInfoModel()
            {
                ProductId = 0,
                ProductName = "请选择"
            });

            storeProductNameCobx.DisplayMember = "ProductName";
            storeProductNameCobx.ValueMember = "ProductId";
            storeProductNameCobx.DataSource = list;
            storeProductNameCobx.SelectedIndex = 0;



        }

        private void ChangStoreNameSelected(object sender, EventArgs e)
        {
            //加载指定仓库分区列表
            int storeId = inStoreNameCobx.SelectedIndex.GetInt();
            if (storeId > 0)
            {
                List<StoreRegionInfoModel> regionList = srBLL.GetRegionListByStoreId(storeId);
                regionList.Insert(0, new StoreRegionInfoModel()
                {
                    SRegionId = 0,
                    SRegionName = "请选择"
                });
                sRegionNameCobx.DisplayMember = "SRegionName";
                sRegionNameCobx.ValueMember = "SRegionId";
                sRegionNameCobx.DataSource = regionList;
                sRegionNameCobx.SelectedIndex = 0;
            }



        }


        /// <summary>
        /// 产品库存列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickProductStoreList(object sender, EventArgs e)
        {
            productInStoreListBtn.BackColor = selColor;
            productInStoreRecordBtn.BackColor = unSelColor;
            typeNameLabel.Text = "产品库存数据：";
            List<ViewProductStoreInfo> storeData = pBLL.GetAllProductStoreList();
            productInStoresDGV.DataSource = storeData;


        }

        private void ShowInStoreRecors()
        {
            productInStoreRecordBtn.BackColor = selColor;
            productInStoreListBtn.BackColor = unSelColor;
            typeNameLabel.Text = "入库记录：";
            productInStoresDGV.DataSource = records;
        }

        /// <summary>
        /// 产品入库记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickProductInStoreRecord(object sender, EventArgs e)
        {
            ShowInStoreRecors();
        }

        private void ClickFlashBtn(object sender, EventArgs e)
        {
            ShowInStoreRecors();
            storeProductNameCobx.SelectedIndex = 0;
            inStoreNameCobx.SelectedIndex = 0;
            sRegionNameCobx.DataSource = null;
            inStoreCountUpDown.Value = 0;
        }

        private void ClickResetBtn(object sender, EventArgs e)
        {
            storeProductNameCobx.SelectedIndex = 0;
            inStoreNameCobx.SelectedIndex = 0;
            sRegionNameCobx.DataSource = null;
            inStoreCountUpDown.Value = 0;
        }



        /// <summary>
        /// 入库提交功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickInStoreBtn(object sender, EventArgs e)
        {
            //获取信息
            int productId = storeProductNameCobx.SelectedValue.GetInt();
            int storeId = inStoreNameCobx.SelectedValue.GetInt();
            int regionId = sRegionNameCobx.SelectedValue.GetInt();
            int productCount = inStoreCountUpDown.Value.GetInt();
            //检查
            if (productId == 0 ||
                storeId == 0 ||
                regionId == 0 ||
                productCount == 0)
            {
                MsgBoxHelper.MsgErrorShow("产品入库", "入库信息有误，请检查！");
                return;
            }
            //封装信息
            ProductStoreInfoModel infoModel = new ProductStoreInfoModel()
            {
                ProductId = productId,
                StoreId = storeId,
                SRegionId = regionId,
                ProductCount = productCount
            };

            //提交

            bool isInStore = pBLL.InStoreProducts(infoModel);

            if (isInStore)
            {
                MsgBoxHelper.MsgBoxShow("产品入库", "产品入库成功");
                ShowThisInStoreRecors(storeProductNameCobx.Text, inStoreNameCobx.Text, sRegionNameCobx.Text, productCount);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("产品入库", "入库失败！");
                return;
            }


        }


        /// <summary>
        /// 将入库记录添加到列表中
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="storeName"></param>
        /// <param name="regionname"></param>
        /// <param name="productCount"></param>
        private void ShowThisInStoreRecors(string productName, string storeName, string regionname, int productCount)
        {

            records.Add(new ViewProductStoreInfo()
            {
                ProStoreId = records.Count + 1,
                ProductCount = productCount,
                ProductName = productName,
                StoreName = storeName,
                SRegionName = regionname

            });
            productInStoresDGV.DataSource = null;
            ShowInStoreRecors();



        }
    }
}
