using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;
using WTCS.Models.DModels;
using WTCS.Models.VModels;

namespace WTCS.BLL
{
    public class StoreRegionBLL
    {
        ViewStoreRegionDAL vsrDAL = new ViewStoreRegionDAL();
        StoreRegionDAL srDAL = new StoreRegionDAL();

        /// <summary>
        /// 条件查询仓库分区列表
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="stateId"></param>
        /// <param name="keywords"></param>
        /// <param name="showDel"></param>
        /// <returns></returns>
        public List<ViewStoreRegionInfo> FindStoreRegionList(int storeId, int stateId, string keywords, bool showDel)
        {
            int isDeleted = showDel ? 1 : 0;
            return vsrDAL.FindStoreRegionList(storeId, stateId, keywords, isDeleted);
        }


        /// <summary>
        /// 判断指定分区是否添加产品
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public bool IsRegionHaveProducts(int regionId)
        {
            int productCount = srDAL.GetProuctCountInRegion(regionId);
            if (productCount > 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// 逻辑删除分区信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int LogicDeleteStoreRegion(int regionId, int storeId)
        {
            int reDel;
            if (IsRegionHaveProducts(regionId))
                //已添加了产品
                reDel = 2;
            else
            {
                bool blDel = srDAL.DeleteStoreRegion(regionId, storeId, 0, 1);
                if (blDel)
                    reDel = 1;//删除成功
                else
                    reDel = 0;
            }
            return reDel;
        }


        /// <summary>
        /// 批量 逻辑删除分区信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public string LogicDeleteStoreRegion(List<StoreRegionInfoModel> regionList)
        {
            string reStr = "";

            foreach (StoreRegionInfoModel storeRegionInfo in regionList)
            {
                if (reStr.Length > 0)
                    reStr += ",";
                if (IsRegionHaveProducts(storeRegionInfo.SRegionId))
                    reStr += storeRegionInfo.SRegionId;//已添加了分区
            }
            if (reStr == "")
                reStr = srDAL.DeleteStoreRegionList(regionList, 0, 1) ? "Y" : "0";
            return reStr;
        }


        /// <summary>
        /// 恢复仓库分区信息
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RecoverStoreRegion(int regionId, int storeId)
        {
            return srDAL.DeleteStoreRegion(regionId, storeId, 0, 0);
        }


        /// <summary>
        /// 真删除仓库分区信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteStoreRegion(int regionId, int storeId)
        {
            return srDAL.DeleteStoreRegion(regionId, storeId, 1, 2);
        }


        /// <summary>
        /// 获取指定仓库分区信息
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public StoreRegionInfoModel GetSRegionInfo(int regionId)
        {
            return srDAL.GetStoreRegionInfo(regionId);
        }

        /// <summary>
        /// 检查是否存在相同名称或编号的仓库
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns></returns>
        public int ExistsStore(string sRegionName, string sRegionNo)
        {
            bool[] bls = srDAL.ExistsStoreRegion(sRegionName, sRegionNo);
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
        /// 添加分区至仓库并返回Id
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns></returns>
        public int AddStoreRegionWithId(StoreRegionInfoModel storeRegionInfo)
        {
            return srDAL.AddStoreRegion(storeRegionInfo, 1);
        }

        /// <summary>
        /// 添加分区至仓库
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <returns></returns>
        public bool AddStoreRegion(StoreRegionInfoModel storeRegionInfo)
        {
            return srDAL.AddStoreRegion(storeRegionInfo, 0) > 0;
        }

        /// <summary>
        /// 更新仓库分区，修改所属仓库
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="oldStoreId"></param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfoModel storeRegionInfo, int oldStoreId)
        {
            return srDAL.UpdateStoreRegion(storeRegionInfo, oldStoreId);
        }

        /// <summary>
        /// 更新仓库分区，没有修改所属仓库
        /// </summary>
        /// <param name="storeRegionInfo"></param>
        /// <param name="oldStoreId"></param>
        /// <returns></returns>
        public bool UpdateStoreRegion(StoreRegionInfoModel storeRegionInfo)
        {
            return srDAL.UpdateStoreRegion(storeRegionInfo, 0);
        }



    }


}
