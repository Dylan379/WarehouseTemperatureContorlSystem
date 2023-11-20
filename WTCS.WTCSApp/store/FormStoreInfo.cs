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
    public partial class FormStoreInfo : Form
    {
        public FormStoreInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 刷新列表页数据
        /// </summary>
        public event Action ReLoadList;
    }
}
