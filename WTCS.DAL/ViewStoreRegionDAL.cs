﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL.Base;
using WTCS.Models.VModels;

namespace WTCS.DAL
{
    public class ViewStoreRegionDAL : BQuery<ViewStoreRegionInfo>
    {

        /// <summary>
        /// 条件查询仓库分区列表
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="stateId"></param>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<ViewStoreRegionInfo> FindStoreRegionList(int storeId, int stateId, string keywords, int isDeleted)
        {
            List<ViewStoreRegionInfo> list = new List<ViewStoreRegionInfo>();
            string cols = CreateSql.GetColsString<ViewStoreRegionInfo>("StoreId,TemperState,Remark,IsDeleted");
            string strWhere = $"IsDeleted={isDeleted}";
            if (storeId > 0)
                strWhere += $" and StoreId={storeId}";
            if (stateId > -1)
                strWhere += $" and TemperState={stateId}";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (SRegionNo like @keywords or SRegionName like @keywords)";
                SqlParameter parameter = new SqlParameter("@keywords", $"%{keywords}%");
                list = GetModelList(strWhere, cols, parameter);
            }
            else
                list = GetModelList(strWhere, cols);
            return list;

        }
    }
}
