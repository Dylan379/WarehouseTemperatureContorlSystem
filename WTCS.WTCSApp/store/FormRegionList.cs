using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.WTCSApp.FModels;

namespace WTCS.WTCSApp.store
{
    public partial class FormRegionList : Form
    {
        public FormRegionList()
        {
            InitializeComponent();
        }

        private void LoadRegionListPage(object sender, EventArgs e)
        {
            keyWordsInput.Clear();
            isDeletedCheck.Checked = false;
            //加载仓库下拉框 
            FormUtility.LoadComboBoxStores(storeComboBox);
            //加载状态下拉框
            LaodCboStates();
        }

        private void LaodCboStates()
        {
            List<RegionStateModel> stateList = FormUtility.RegionStateList();
            stateComboBox.DisplayMember = "StateText";
            stateComboBox.ValueMember = "RegionState";
            stateComboBox.DataSource = stateList;
            stateComboBox.SelectedIndex = 0;
        }
    }
}
