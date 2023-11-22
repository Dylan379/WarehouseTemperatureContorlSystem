using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.Models.DModels;

namespace WTCS.Models.VModels
{

    [Table("ViewStoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo : StoreRegionInfoModel
    {
        public string TemperStateText { get; set; }
        public string StoreName { get; set; }
    }
}
