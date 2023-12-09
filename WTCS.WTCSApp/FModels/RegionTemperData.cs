using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.WTCSApp.FModels
{
    public class RegionTemperData
    {
        public int SId { get; set; }
        public int SRegionId { get; set; }
        public int TemperState { get; set; }
        public decimal SRTemperature { get; set; }

        public decimal Lowtemperature { get; set; }
        public decimal HighTemperature { get; set; }
    }
}
