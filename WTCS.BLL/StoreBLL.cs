using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;
using WTCS.DAL.Base;
using WTCS.Models.DModels;

namespace WTCS.BLL
{
    public class StoreBLL
    {
        private StoreDAL storeDAL = new StoreDAL();

        public List<StoreInfoModel> GetStoreInfos(string keyWords, bool isDeleted)
        {

            int IsDeleted = isDeleted ? 1 : 0;
            return storeDAL.GetStoreInfos(keyWords, IsDeleted);

        }

        /// <summary>
        /// 判断指定仓库是否添加了分区
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool IsAddRegion(int storeId)
        {
            int regionCount = storeDAL.GetStoreRegionCount(storeId);
            if (regionCount > 0)
            {
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// 逻辑删除仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int LogicDeleteStore(int storeId)
        {
            int reDel;
            if (IsAddRegion(storeId))
                //已添加了分区
                reDel = 2;
            else
            {
                bool blDel = storeDAL.Delete(storeId, 0, 1);
                if (blDel)
                    reDel = 1;
                else
                    reDel = 0;
            }
            return reDel;
        }

        /// <summary>
        /// 批量 逻辑删除仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public string LogicDeleteStore(List<int> storeId)
        {
            string reStr = "";

            foreach (var id in storeId)
            {
                if (reStr.Length > 0)
                    reStr += ",";
                if (IsAddRegion(id))
                    reStr += id;//已添加了分区
            }
            if (reStr == "")
                reStr = storeDAL.DeleteList(storeId, 0, 1) ? "Y" : "0";
            return reStr;
        }



        /// <summary>
        /// 恢复仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RecoverStore(int storeId)
        {
            return storeDAL.Delete(storeId, 0, 0);
        }


        /// <summary>
        /// 真删除仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteStore(int storeId)
        {
            return storeDAL.Delete(storeId, 1, 2);
        }




    }
}
