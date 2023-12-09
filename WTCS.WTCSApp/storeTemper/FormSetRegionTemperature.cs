using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.WTCSApp.UControls;

namespace WTCS.WTCSApp.storeTemper
{
    public partial class FormSetRegionTemperature : Form
    {
        public FormSetRegionTemperature()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //刷新列表页该分区的温度与状态
        public event Action<object, UStoreRegionArgs> ReloadRegion;

    }
}
