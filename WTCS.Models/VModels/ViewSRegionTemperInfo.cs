using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.VModels
{
    [Table("ViewSRegionInfos")]
    public class ViewSRegionTemperInfo
    {
        public int StoreId { get; set; }
        public int SRegionId { get; set; }
        public int TotalCount { get; set; }
        public string SRegionName { get; set; }
        public decimal SRTemperature { get; set; }
        public decimal AllowLowestTemperature { get; set; }
        public decimal AllowHighestTemperature { get; set; }
        public int TemperState { get; set; }
        public string TemperRange { get; set; }
    }
}
