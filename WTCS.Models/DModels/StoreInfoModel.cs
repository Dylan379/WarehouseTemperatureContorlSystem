using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.Models.DModels
{
    /// <summary>
    /// 仓库信息实体
    /// </summary>
    class StoreInfoModel
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public string StoreNo { get; set; }

        public int RegionCount { get; set; }
        public string Remark { get; set; }
        public int IsDeleted { get; set; }

    }
}
