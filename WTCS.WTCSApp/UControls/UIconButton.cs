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
    public partial class UIconButton : Button
    {
        public UIconButton()
        {
            InitializeComponent();
            Size = new Size(30, 30);
            Font = new Font("Webdings", 10.8F);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Text = "0";
            ForeColor = Color.Silver;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.FromArgb(53, 61, 134);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.Transparent;
        }


        /// <summary>
        /// 不显示聚焦框
        /// </summary>
        protected override bool ShowFocusCues
        {
            get { return false; }
        }
    }
}
