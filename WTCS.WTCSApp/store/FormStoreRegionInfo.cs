using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS.WTCSApp.store
{
    public partial class FormStoreRegionInfo : Form
    {
        public FormStoreRegionInfo()
        {
            InitializeComponent();
        }

        public event Action ReLoadStoreList;//刷新仓库管理列表页数据

    }
}
