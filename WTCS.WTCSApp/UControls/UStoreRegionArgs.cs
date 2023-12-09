using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.WTCSApp.UControls
{
    /// <summary>
    /// 传递数据
    /// </summary>
    public class UStoreRegionArgs : EventArgs
    {
        public int SId { get; set; }
        public int SRegionId { get; set; }
        public int TemperState { get; set; }
        public decimal SRTemperature { get; set; }

        public decimal Lowtemperature { get; set; }
        public decimal HighTemperature { get; set; }


        public UStoreRegionArgs(int sId,
                                int sRegionId,
                                int temperState,
                                decimal lowTemperature,
                                decimal highTemperature)
        {
            SId = sId;
            SRegionId = sRegionId;
            TemperState = temperState;
            Lowtemperature = lowTemperature;
            HighTemperature = highTemperature;
        }

    }
}
