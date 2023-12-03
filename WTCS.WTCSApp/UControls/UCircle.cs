using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WTCS.WTCSApp.UControls
{
    public partial class UCircle : UserControl
    {
        public UCircle()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectangle = e.ClipRectangle;
            Rectangle rectangle1 = new Rectangle(rectangle.X + 1,
                                                 rectangle.Y + 1,
                                                 rectangle.Width - 2,
                                                 rectangle.Height - 2);
            graphics.DrawEllipse(new Pen(ForeColor), rectangle1);
            graphics.FillEllipse(new SolidBrush(ForeColor), rectangle1);
        }
    }
}
