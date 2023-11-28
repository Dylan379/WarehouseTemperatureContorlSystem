using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;
using WTCS.DAL.Base;
using WTCS.Models.DModels;
using WTCS.Models.VModels;

namespace WTCS.BLL
{
    public class ProductBLL
    {
        ProductDAL pDAL = new ProductDAL();
        ViewProductStoreDAL vpsDAL = new ViewProductStoreDAL();
        ProductStoreDAL psDAL = new ProductStoreDAL();
        /// <summary>
        /// 得到产品列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ProductInfoModel> GetProductList(string keywords, bool isDeletedChecked)
        {
            int isDeleted = isDeletedChecked ? 1 : 0;

            return pDAL.GetProductList(keywords, isDeleted);
        }


        /// <summary>
        /// 获得指定产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductInfoModel GetProductInfo(int productId)
        {
            return pDAL.GetProductInfo(productId);
        }

        /// <summary>
        /// 获取所有产品列表  绑定下拉框
        /// </summary>
        /// <returns></returns>
        public List<ProductInfoModel> GetAllProducts()
        {
            return pDAL.GetAllProducts();
        }

        /// <summary>
        /// 检查产品是否还有库存
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool IsProductCleared(int productId)
        {
            int count = pDAL.GetProductCount(productId);

            if (count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 逻辑删除产品信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int LogicDeleteProduct(int productId)
        {
            int reDel;
            if (IsProductCleared(productId))
                //已添加了分区
                reDel = 2;
            else
            {
                bool blDel = pDAL.Delete(productId, 0, 1);
                if (blDel)
                    reDel = 1;
                else
                    reDel = 0;
            }
            return reDel;
        }

        /// <summary>
        /// 批量 逻辑删除产品信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public string LogicDeleteProduct(List<int> productId)
        {
            string reStr = "";

            foreach (var id in productId)
            {
                if (reStr.Length > 0)
                    reStr += ",";
                if (IsProductCleared(id))
                    reStr += id;//已添加了分区
            }
            if (reStr == "")
                reStr = pDAL.DeleteList(productId, 0, 1) ? "Y" : "0";
            return reStr;
        }

        /// <summary>
        /// 恢复产品信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RecoverProduct(int productId)
        {
            return pDAL.Delete(productId, 0, 0);
        }


        /// <summary>
        /// 真删除产品信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteProduct(int productId)
        {
            return pDAL.Delete(productId, 1, 2);
        }



        /// <summary>
        /// 检查编码或名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns></returns>
        public int ExistsProduct(string productName, string productNo)
        {
            bool[] bls = pDAL.ExistsProduct(productName, productNo);
            bool isNameExists = bls[0];
            bool isNoExists = bls[1];
            if (!isNameExists && !isNoExists)
                return 0;//都不存在
            else if (isNameExists && !isNoExists)
                return 1;//Name存在
            else if (!isNameExists && isNoExists)
                return 2;//No存在
            else
                return 3;//都存在
        }



        /// <summary>
        /// 添加物品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <param name="isGetId"></param>
        /// <returns></returns>
        public bool AddProductInfo(ProductInfoModel productInfo)
        {
            return pDAL.AddProductInfo(productInfo, 0) > 0;
        }


        /// <summary>
        /// 添加物品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <param name="isGetId"></param>
        /// <returns></returns>
        public int AddProductInfoReturnId(ProductInfoModel productInfo)
        {
            return pDAL.AddProductInfo(productInfo, 1);
        }


        /// <summary>
        /// 更新修改产品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <param name="isGetId"></param>
        /// <returns></returns>
        public bool UpdateProductInfo(ProductInfoModel productInfo)
        {
            return pDAL.UpdateProductInfo(productInfo);
        }



        #region 产品入库

        /// <summary>
        /// 获取所有产品库存数据
        /// </summary>
        /// <returns></returns>
        public List<ViewProductStoreInfo> GetAllProductStoreList()
        {
            return vpsDAL.GetAllProductStoreList();
        }

        /// <summary>
        /// 检查指定产品在指定分区中是否有库存
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sRegionId"></param>
        /// <returns></returns>
        public bool InStoreProducts(ProductStoreInfoModel infoModel)
        {
            if (infoModel == null)
                throw new Exception("入库信息不能为null");
            if (psDAL.ExistProductStoreRecord(infoModel.ProductId, infoModel.SRegionId))
            {
                //修改产品数量

                return psDAL.UpdateProductToStore(infoModel);
            }
            else
            {
                //新增产品入库,以及入库信息
                return psDAL.AddProductToStore(infoModel);
            }
        }

        #endregion
    }
}
