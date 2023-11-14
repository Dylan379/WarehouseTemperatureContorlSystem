using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.DModels
{
    /// <summary>
    /// 产品信息实体
    /// </summary>
    class ProductInfoModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNo { get; set; }
        public decimal FitLowestTemperature { get; set; }
        public decimal FitHighestTemperature { get; set; }

        public int IsDeleted { get; set; }
    }
}
