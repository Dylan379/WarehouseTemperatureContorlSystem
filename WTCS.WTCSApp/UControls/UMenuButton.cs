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
    public partial class UMenuButton : UserControl
    {
        public UMenuButton()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 按钮图标
        /// </summary>
        public Image BtnImage
        {
            get { return pbImg.Image; }
            set { pbImg.Image = value; }
        }

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText
        {
            get { return lableBtnText.Text; }
            set { lableBtnText.Text = value; }
        }


        /// <summary>
        /// 鼠标进入
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            BackColor = Color.FromArgb(88, 116, 216);

        }

        /// <summary>
        /// 鼠标移出
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            BackColor = Color.FromArgb(45, 50, 116);

        }

        /// <summary>
        /// 鼠标点击
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            BackColor = Color.FromArgb(88, 116, 216);

        }


        private void lableBtnText_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void pbImg_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void lableBtnText_Click_1(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void pbImg_Click_1(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
