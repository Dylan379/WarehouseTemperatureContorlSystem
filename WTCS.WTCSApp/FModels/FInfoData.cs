using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.WTCSApp.FModels
{
    public class FInfoData
    {


        //主键编号
        public int FId { get; set; }
        //1 add  2Edit  3AddChild  4info
        public int ActType { get; set; }
    }
}
