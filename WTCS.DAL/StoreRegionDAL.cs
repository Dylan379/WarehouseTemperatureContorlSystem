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
    public class StoreRegionDAL : BaseDAL<StoreRegionInfoModel>
    {

        /// <summary>
        /// 仓库分区删除处理,包含真删除,逻辑删除,恢复
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="storeId"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool DeleteStoreRegion(int regionId, int storeId, int delType, int isDeleted)
        {
            List<string> sqlList = GetDelRegionSqlList(regionId, storeId, delType, isDeleted);

            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 批量仓库分区删除处理,包含真删除,逻辑删除,恢复
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="storeId"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool DeleteStoreRegionList(List<StoreRegionInfoModel> regionList, int delType, int isDeleted)
        {
            List<string> sqlList = new List<string>();
            foreach (StoreRegionInfoModel item in regionList)
            {
                sqlList.AddRange(GetDelRegionSqlList(item.SRegionId, item.StoreId, delType, isDeleted));
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 得到删除分区sql
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="storeId"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        private List<string> GetDelRegionSqlList(int regionId, int storeId, int delType, int isDeleted)
        {
            List<string> sqlList = new List<string>();
            string strWhere = $"SRegionId={regionId}";
            string delFlag = "+";
            string delSql;
            if (delType == 1)
                delSql = CreateSql.CreatDeleteSql<StoreRegionInfoModel>(strWhere);
            else
            {
                delSql = CreateSql.CreatLogicDeleteSql<StoreRegionInfoModel>(strWhere, isDeleted);
            }
            if (isDeleted >= 0)
                delFlag = "-";
            //修改分区数的sql语句
            string updateSql = $"update StoreInfos set RegionCount{delFlag}1 where StoreId=" + storeId;

            sqlList.Add(delSql);
            sqlList.Add(updateSql);
            return sqlList;
        }

        /// <summary>
        /// 获取指定分区中的产品数量
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public int GetProuctCountInRegion(int regionId)
        {
            string sql = $"select sum(ProductCount) from ProductStoreInfos where SRegionId={regionId} and IsDeleted=0";
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            if (oCount != null && oCount.ToString() != "")
                return oCount.GetInt();
            return 0;
        }

        /// <summary>
        /// 获取指定仓库分区信息
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public StoreRegionInfoModel GetStoreRegionInfo(int regionId)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfoModel>("IsDeleted");
            return GetById(regionId, cols);
        }


        /// <summary>
        /// 仓库分区是否存在
        /// </summary>
        /// <param name="sRegionName"></param>
        /// <param name="sRegionNo"></param>
        /// <returns></returns>
        public bool[] ExistsStoreRegion(string sRegionName, string sRegionNo)
        {
            bool isNoExists = false;
            if (!string.IsNullOrEmpty(sRegionNo))
                isNoExists = ExistsByName("SRegionNo", sRegionNo);
            bool isNameExists = false;
            if (!string.IsNullOrEmpty(sRegionName))
                isNameExists = ExistsByName("SRegionName", sRegionName);
            return new bool[] { isNameExists, isNoExists };
        }


        /// <summary>
        /// 将分区添加至仓库
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        public int AddStoreRegion(StoreRegionInfoModel storeRegionInfo, int isGet)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfoModel>("SRegionId,AllowLowestTemperature,AllowHighestTemperature,IsDeleted");
            //return Add(storeRegionInfo, cols, isGet);

            //修改仓库分区数
            return SqlHelper.ExecuteTrans<int>(cmd =>
            {
                try
                {
                    //入库分区信息
                    SqlModel inModel = CreateSql.GetInsertSqlAndParas(storeRegionInfo, cols, isGet);
                    cmd.CommandText = inModel.Sql;
                    SqlHelper.AddParas(cmd, inModel.SqlParaArray);
                    int res = 0;
                    if (isGet == 1)
                    {
                        object old = cmd.ExecuteScalar();
                        res = old.GetInt();
                    }
                    else
                        res = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    if (res > 0)
                    {
                        //修改仓库分区数
                        string updateSql = "update StoreInfos set RegionCount=RegionCount+1 where StoreId=" +
                                            storeRegionInfo.StoreId;
                        cmd.CommandText = updateSql;
                        cmd.ExecuteNonQuery();
                    }
                    cmd.Transaction.Commit();
                    return 0;
                }
                catch (SqlException ex)
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("执行添加仓库分区事务异常！", ex);
                }
            });
        }


        /// <summary>
        /// 更新仓库分区
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="oldStoreId"></param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfoModel storeRegionInfo, int oldStoreId)
        {
            string cols = CreateSql.GetColsString<StoreRegionInfoModel>("AllowLowestTemperature,AllowHighestTemperature,IsDeleted");
            if (storeRegionInfo.AllowLowestTemperature != null)
                cols += ",AllowLowestTemperature";
            if (storeRegionInfo.AllowHighestTemperature != null)
                cols += ",AllowHighestTemperature";
            //修改仓库分区数
            return SqlHelper.ExecuteTrans(cmd =>
           {
               try
               {
                   //更新分区信息
                   SqlModel upModel = CreateSql.GetUpdateSqlAndParas(storeRegionInfo, cols, "");
                   cmd.CommandText = upModel.Sql;
                   SqlHelper.AddParas(cmd, upModel.SqlParaArray);
                   int res = 0;
                   res = cmd.ExecuteNonQuery();
                   cmd.Parameters.Clear();
                   if (res > 0 && oldStoreId > 0)
                   {
                       //修改仓库分区数
                       string updateSql = "update StoreInfos set RegionCount=RegionCount+1 where StoreId=" +
                                          storeRegionInfo.StoreId;
                       cmd.CommandText = updateSql;
                       cmd.ExecuteNonQuery();
                       //修改仓库分区数
                       string oldUpdateSql = "update StoreInfos set RegionCount=RegionCount-1 where StoreId=" +
                                          oldStoreId;
                       cmd.CommandText = oldUpdateSql;
                       cmd.ExecuteNonQuery();
                   }
                   cmd.Transaction.Commit();
                   return true;
               }
               catch (SqlException ex)
               {
                   cmd.Transaction.Rollback();
                   throw new Exception("执行更新仓库分区事务异常！", ex);
               }
           });

        }

    }
}
