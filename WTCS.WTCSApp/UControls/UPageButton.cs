using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS.WTCSApp.UControls
{
    [DefaultEvent("Click")]
    public partial class UPageButton : UserControl
    {
        public UPageButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText
        {
            get { return lbText.Text; }
            set { lbText.Text = value; }
        }


        public override Color ForeColor { get => lbText.ForeColor; set => lbText.ForeColor = value; }



        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            lbText.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbText_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
