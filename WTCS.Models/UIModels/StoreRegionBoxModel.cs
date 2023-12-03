using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WTCS.Models.UIModels
{
    public class StoreRegionBoxModel
    {
        public int SRegionId { get; set; }
        public int SId { get; set; }
        public string SRegionName { get; set; }
        public bool BtnSetVisible { get; set; }
        public string BtnSetText { get; set; }
        public int TemperState { get; set; }
        public Color StateColor { get; set; }
        public int ProductCount { get; set; }
        public decimal SRTemper { get; set; }
        public decimal MaxTemper { get; set; }
        public decimal MinTemper { get; set; }
        public string TemperRange { get; set; }

    }
}
