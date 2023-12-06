using Communicate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DAL;
using WTCS.Models.DModels;
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


        /// <summary>
        /// 读取分区温度数据(从设备中读取)
        /// </summary>
        /// <returns></returns>
        public List<StoreRegionBoxModel> ReadRegionTemperData()
        {
            List<ViewSRegionTemperInfo> regionTemperList = vsrtDAL.GetSRegionTemperList(0);
            //建立连接,读取数据
            ModbusRTU mbRTU = new ModbusRTU("COM1",
                                             9600,
                                             8,
                                             System.IO.Ports.StopBits.One,
                                             System.IO.Ports.Parity.None);

            ushort length = (ushort)regionTemperList.Count;
            if (mbRTU.Open())
            {
                regionTemperList = Task.Run(async () =>
                {
                    List<ushort> values = await mbRTU.ReadUInt16(0, len: length);

                    if (values != null)
                    {
                        if (values.Count > 0)
                        {
                            List<StoreRegionInfoModel> regions = new List<StoreRegionInfoModel>();
                            for (int i = 0; i < values.Count; i++)
                            {
                                //读取到的温度值
                                decimal temperValue = decimal.Parse(((decimal)(values[i] / 10)).ToString("0.00"));
                                StoreRegionInfoModel regionInfo = new StoreRegionInfoModel();
                                regionInfo.SRegionId = regionTemperList[i].SRegionId;
                                regionInfo.SRTemperature = temperValue;
                                if (temperValue > 0)
                                {
                                    if (regionTemperList[i].AllowHighestTemperature < temperValue)
                                        regionInfo.TemperState = 2;
                                    else if (regionTemperList[i].AllowLowestTemperature > temperValue)
                                        regionInfo.TemperState = 0;
                                    else
                                        regionInfo.TemperState = 1;
                                    regions.Add(regionInfo);
                                    regionTemperList[i].TemperState = regionInfo.TemperState;
                                    regionTemperList[i].SRTemperature = temperValue;
                                }
                            }
                            //将读取到的分区室温数据更新到数据库




                        }
                        return regionTemperList;

                    }
                    else
                        return null;
                }).Result;
                mbRTU.Close();
            }
            return GetRegionBoxList(regionTemperList);
        }
    }
}
