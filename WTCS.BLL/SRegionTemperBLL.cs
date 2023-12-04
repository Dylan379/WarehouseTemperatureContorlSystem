using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;
using WTCS.Models.UIModels;
using WTCS.Models.VModels;

namespace WTCS.BLL
{
    public class SRegionTemperBLL
    {
        private StoreRegionDAL srDAL = new StoreRegionDAL();
        private ViewSRegionTemperDAL vsrtDAL = new ViewSRegionTemperDAL();

        /// <summary>
        /// 查询指定仓库分区列表
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<StoreRegionBoxModel> FindRegionBoxList(int storeId)
        {

            List<ViewSRegionTemperInfo> regionList = vsrtDAL.GetSRegionTemperList(storeId);

            //转换为目标类型
            return GetRegionBoxList(regionList);
        }


        /// <summary>
        /// 将 List<ViewSRegionTemperInfo> 转换为 List<StoreRegionBoxModel>
        /// </summary>
        /// <param name="regionList"></param>
        /// <returns></returns>
        private List<StoreRegionBoxModel> GetRegionBoxList(List<ViewSRegionTemperInfo> regionList)
        {
            List<StoreRegionBoxModel> boxList = new List<StoreRegionBoxModel>();
            if (regionList != null)
            {
                int id = -1;
                foreach (ViewSRegionTemperInfo item in regionList)
                {
                    string range = "";
                    if (item.AllowLowestTemperature == item.AllowHighestTemperature)
                        range = "无";
                    else
                        range = item.AllowLowestTemperature + " ~ " + item.AllowHighestTemperature + "℃";

                    if (item.SRTemperature > 0)
                    {
                        if (item.AllowLowestTemperature > item.SRTemperature)
                            item.TemperState = 0;
                        if (item.AllowHighestTemperature < item.SRTemperature)
                            item.TemperState = 2;
                        else
                            item.SRTemperature = 1;
                    }
                    id++;
                    boxList.Add(new StoreRegionBoxModel()
                    {
                        SId = id,
                        SRegionId = item.SRegionId,
                        SRegionName = item.SRegionName,
                        SRTemper = item.SRTemperature,
                        MaxTemper = item.AllowHighestTemperature,
                        MinTemper = item.AllowLowestTemperature,
                        TemperRange = range,
                        TemperState = item.TemperState,
                        ProductCount = item.TotalCount
                    });
                }
            }


            return boxList;
        }

    }
}
