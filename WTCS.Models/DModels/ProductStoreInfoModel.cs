using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.DModels
{
    /// <summary>
    /// 产品入库信息实体
    /// </summary>
    class ProductStoreInfoModel
    {

        public int ProStoreId { get; set; }
        public int ProductId { get; set; }
        public int SRegionId { get; set; }
        public int StoreId { get; set; }
        public int ProductCount { get; set; }
        public int IsDeleted { get; set; }
    }
}
