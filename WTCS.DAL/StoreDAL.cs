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
    public class StoreDAL : BaseDAL<StoreInfoModel>
    {

        /// <summary>
        /// 条件查询仓库列表
        /// </summary>
        /// <param name="keyWords">查询关键字</param>
        /// <param name="IsDeleted">是否删除标识</param>
        /// <returns></returns>
        public List<StoreInfoModel> GetStoreInfos(string keyWords, int isDeleted)
        {

            string cols = CreateSql.GetColsString<StoreInfoModel>("IsDeleted");
            string strWhere = $"IsDeleted={isDeleted}";
            if (!string.IsNullOrEmpty(keyWords))
            {
                strWhere += " and (StoreNo like @keyWords or StoreName like @keyWords)";
                SqlParameter parameters = new SqlParameter("@keyWords", $"%{keyWords}%");
                return GetModelList(strWhere, cols, parameters);

            }
            return GetModelList(strWhere, cols);
        }

        /// <summary>
        /// 获取指定仓库分区数量
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int GetStoreRegionCount(int storeId)
        {
            string sql = $"SELECT RegionCount FROM StoreInfos WHERE StoreId={storeId}";
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            if (oCount != null && oCount.ToString() != "")
            {
                return oCount.GetInt();
            }
            return 0;
        }



    }
}
