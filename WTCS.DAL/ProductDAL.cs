using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL.Base;
using WTCS.DbUtility;
using WTCS.Models.DModels;

namespace WTCS.DAL
{
    public class ProductDAL : BaseDAL<ProductInfoModel>
    {
        /// <summary>
        /// 得到产品列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ProductInfoModel> GetProductList(string keywords, int isDeleted)
        {
            string cols = CreateSql.GetColsString<ProductInfoModel>("IsDeleted");
            string strWhere = $" IsDeleted = {isDeleted} ";
            SqlParameter parameter = null;
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (ProductName like @keywords or ProductNo like @keywords) ";
                parameter = new SqlParameter("@keywords", $"%{keywords}%");
                return GetModelList(strWhere, cols, parameter);
            }
            return GetModelList(strWhere, cols);
        }


        /// <summary>
        /// 获得指定产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductInfoModel GetProductInfo(int productId)
        {
            string cols = CreateSql.GetColsString<ProductInfoModel>("IsDeleted");

            return GetById(productId, cols);
        }

        /// <summary>
        /// 获取所有产品列表  绑定下拉框
        /// </summary>
        /// <returns></returns>
        public List<ProductInfoModel> GetAllProducts()
        {
            return GetModelList("ProductId,ProductName", 0);
        }


        /// <summary>
        /// 获取指定产品的库存数
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int GetProductCount(int productId)
        {
            string sql = "select sum(ProductCount) from ProductStoreInfos where ProductId = " + productId;
            object countObject = SqlHelper.ExecuteScalar(sql, 1);
            if (countObject != null && countObject.ToString() != "")
            {
                return countObject.GetInt();
            }
            return 0;
        }

        /// <summary>
        /// 检查编码或名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns></returns>
        public bool[] ExistsProduct(string productName, string productNo)
        {
            bool isNoExists = false;
            if (!string.IsNullOrEmpty(productNo))
                isNoExists = ExistsByName("productNo", productNo);
            bool isNameExists = false;
            if (!string.IsNullOrEmpty(productName))
                isNameExists = ExistsByName("productName", productName);
            return new bool[] { isNameExists, isNoExists };
        }



        /// <summary>
        /// 添加物品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <param name="isGetId"></param>
        /// <returns></returns>
        public int AddProductInfo(ProductInfoModel productInfo, int isGetId)
        {
            string cols = CreateSql.GetColsString<ProductInfoModel>("ProductId,IsDeleted");
            return Add(productInfo, cols, isGetId);
        }


        /// <summary>
        /// 更新修改产品信息
        /// </summary>
        /// <param name="productInfo"></param>
        /// <param name="isGetId"></param>
        /// <returns></returns>
        public bool UpdateProductInfo(ProductInfoModel productInfo)
        {
            string cols = CreateSql.GetColsString<ProductInfoModel>("IsDeleted");
            return Update(productInfo, cols);
        }


    }
}
