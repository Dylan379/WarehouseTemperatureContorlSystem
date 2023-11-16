using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCS.WTCSApp.UControls
{
    public partial class UCircleButton : Button
    {
        public UCircleButton()
        {
            InitializeComponent();
        }


        //重绘命令消息ID  0xF
        private const int WM_PAINT = 0xF;

        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色")]
        private Color backGroundColor = Color.Gray;
        /// <summary>
        /// 背景色
        /// </summary>
        public Color BackGroundColor
        {
            get { return backGroundColor; }
            set
            {
                backGroundColor = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Gray"), Description("控件边框色")]
        private Color borderColor = Color.Gray;
        /// <summary>
        /// 边框色
        /// </summary>
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(int), "0"), Description("控件边框粗细")]
        private int borderWidth = 0;
        /// <summary>
        /// 边框粗细
        /// </summary>
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Transparent"), Description("另一个控件背景色")]
        private Color anotherBackGroundColor = Color.Transparent;
        /// <summary>
        /// 另一个控件背景色
        /// </summary>
        public Color AnotherBackGroundColor
        {
            get { return anotherBackGroundColor; }
            set
            {
                anotherBackGroundColor = value;
                Invalidate();
            }
        }


        [DefaultValue(typeof(int), "5"), Description("圆角弧度大小")]
        private int radius = 5;
        /// <summary>
        /// 圆角弧度大小
        /// </summary>
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方式")]
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        /// <summary>
        /// 渐变方式
        /// </summary>
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }


        //重写处理windows消息方法
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                //绘制工作
                if (Radius > 0)
                {
                    using (Graphics graphics = Graphics.FromHwnd(this.Handle))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;//消除锯齿
                        Rectangle rectangle = new Rectangle();
                        rectangle.Width = Width;
                        rectangle.Height = Height;
                        DrawBorder(graphics, rectangle, Radius);

                    }
                }
            }
        }

        private void DrawBorder(Graphics graphics, Rectangle rectangle, int radius)
        {
            rectangle.Width -= 1;
            rectangle.Height -= 1;

            if (BorderWidth > 0) //边框粗细大于0
            {
                GraphicsPath path = PaintCommon.GetRoundRectangle(rectangle, radius);//绘制一个圆角矩形路径
                using (Pen pen = new Pen(BorderColor, BorderWidth))
                {
                    graphics.DrawPath(pen, path);
                }
            }

            //背景区域的矩形
            Rectangle backGroundRectangle = new Rectangle(rectangle.X + BorderWidth,
                                                          rectangle.Y + BorderWidth,
                                                          rectangle.Width - 2 * BorderWidth,
                                                          rectangle.Height - 2 * BorderWidth);
            //绘制背景
            DrawBackColor(graphics, backGroundRectangle, radius);
            //绘制文本
            DrawText(graphics, backGroundRectangle);
        }

        /// <summary>
        /// 绘制按钮文本
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="backGroundRectangle"></param>
        private void DrawText(Graphics graphics, Rectangle backGroundRectangle)
        {
            //格式化字符串位置
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), backGroundRectangle, stringFormat);
        }

        /// <summary>
        /// 绘制背景
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="backGroundRectangle"></param>
        /// <param name="radius"></param>
        private void DrawBackColor(Graphics graphics, Rectangle backGroundRectangle, int radius)
        {
            //获取背景区域的圆角矩形
            GraphicsPath backGroundPath = PaintCommon.GetRoundRectangle(backGroundRectangle, radius);
            if (AnotherBackGroundColor != Color.Transparent)
            {
                //线性渐变画笔
                LinearGradientBrush brush = new LinearGradientBrush(backGroundRectangle,
                                                                    BackGroundColor,
                                                                    AnotherBackGroundColor,
                                                                    GradientMode);
                graphics.FillPath(brush, backGroundPath); //圆角矩形内部

            }
            else
            {
                //纯色背景
                Brush brush = new SolidBrush(BackGroundColor);
                graphics.FillPath(brush, backGroundPath);
            }
        }
    }
}
