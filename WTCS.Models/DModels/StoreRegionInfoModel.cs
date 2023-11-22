using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.DModels
{
    /// <summary>
    /// 仓库区域信息实体
    /// </summary>
    /// 

    [Table("StoreRegionInfoModel")]
    [PrimaryKey("SRegionId", autoIncrement = true)]
    public class StoreRegionInfoModel
    {
        public int SRegionId { get; set; }
        public string SRegionName { get; set; }
        public string SRegionNo { get; set; }
        public int StoreId { get; set; }
        public decimal? SRTemperature { get; set; }
        public decimal? AllowLowestTemperature { get; set; }
        public decimal? AllowHighestTemperature { get; set; }
        public int TemperState { get; set; }
        public string Remark { get; set; }
        public int IsDeleted { get; set; }

    }
}
