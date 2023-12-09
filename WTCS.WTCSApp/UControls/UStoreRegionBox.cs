using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTCS.Models.UIModels;

namespace WTCS.WTCSApp.UControls
{
    public partial class UStoreRegionBox : UserControl
    {
        public UStoreRegionBox()
        {
            InitializeComponent();
        }

        private StoreRegionBoxModel uBoxSource;

        public StoreRegionBoxModel UBoxSource
        {
            get { return uBoxSource; }
            set
            {
                uBoxSource = value;
                //赋值操作
                SId = UBoxSource.SId;
                SRegionId = UBoxSource.SRegionId;
                MaxTemper = UBoxSource.MaxTemper;
                MinTemper = UBoxSource.MinTemper;
                SRTemper = UBoxSource.SRTemper;
                TemperState = UBoxSource.TemperState;
                TemperRange = UBoxSource.TemperRange;
                SRegionName = UBoxSource.SRegionName;
                ProductCount = UBoxSource.ProductCount;
            }
        }


        /// <summary>
        /// 分区编号
        /// </summary>
        public int SRegionId
        {
            get
            {
                return UBoxSource.SRegionId;
            }
            set
            {
                UBoxSource.SRegionId = value;
            }
        }

        /// <summary>
        /// 分区名称
        /// </summary>
        public string SRegionName
        {
            get
            {
                return UBoxSource.SRegionName;
            }
            set
            {
                UBoxSource.SRegionName = value;
                SRegionNameText.Text = UBoxSource.SRegionName;
            }

        }

        public int SId
        {
            get { return UBoxSource.SId; }
            set { UBoxSource.SId = value; }
        }

        //设置按钮可见性
        public bool BtnSetVisible
        {
            get
            {
                return UBoxSource.BtnSetVisible;
            }
            set
            {
                UBoxSource.BtnSetVisible = value;
                temperatureChangeBtn.Visible = UBoxSource.BtnSetVisible;
            }
        }

        /// <summary>
        /// 设置按钮文本
        /// </summary>
        public string BtnSetText
        {
            get
            {
                return UBoxSource.BtnSetText;
            }
            set
            {
                UBoxSource.BtnSetText = value;
                temperatureChangeBtn.Text = UBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 设置温度状态
        /// </summary>
        public int TemperState
        {
            get { return UBoxSource.TemperState; }
            set
            {
                UBoxSource.TemperState = value;
                switch (UBoxSource.TemperState)
                {
                    case 0: //低温
                        UBoxSource.StateColor = Color.FromArgb(137, 201, 151);
                        UBoxSource.BtnSetVisible = true;
                        UBoxSource.BtnSetText = "升温";
                        break;
                    case 1:
                        UBoxSource.StateColor = Color.FromArgb(126, 206, 244);
                        UBoxSource.BtnSetVisible = false;
                        UBoxSource.BtnSetText = "正常";
                        break;
                    case 2: //高温
                        UBoxSource.StateColor = Color.FromArgb(155, 61, 76);
                        UBoxSource.BtnSetVisible = true;
                        UBoxSource.BtnSetText = "降温";
                        break;
                    default:
                        break;
                }
                SRTemperStateLight.ForeColor = uBoxSource.StateColor;
                temperatureChangeBtn.Visible = uBoxSource.BtnSetVisible;
                temperatureChangeBtn.Text = uBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 设置颜色状态
        /// </summary>
        public Color StateColor
        {
            get { return uBoxSource.StateColor; }
            set
            {
                uBoxSource.StateColor = value;
                SRTemperStateLight.ForeColor = uBoxSource.StateColor;
            }
        }

        public int ProductCount
        {
            get { return uBoxSource.ProductCount; }
            set
            {
                uBoxSource.ProductCount = value;
                productCountLabel.Text = uBoxSource.ProductCount.ToString();
            }
        }

        public decimal SRTemper
        {
            get { return uBoxSource.SRTemper; }
            set
            {
                uBoxSource.SRTemper = value;
                currentTemperatureLabel.Text = uBoxSource.SRTemper.ToString();
                uTemperValue.Value = uBoxSource.SRTemper;
            }
        }

        public decimal MaxTemper
        {
            get { return uBoxSource.MaxTemper; }
            set
            {
                uBoxSource.MaxTemper = value;
                uTemperValue.BMaxValue = uBoxSource.MaxTemper;
            }
        }

        public decimal MinTemper
        {
            get { return uBoxSource.MinTemper; }
            set
            {
                uBoxSource.MinTemper = value;
                uTemperValue.BMinValue = uBoxSource.MinTemper;
            }
        }

        public string TemperRange
        {
            get { return UBoxSource.TemperRange; }
            set
            {
                UBoxSource.TemperRange = value;
                temperatureRangeLabel.Text = UBoxSource.TemperRange.ToString();
            }
        }

        //设置分区温度事件
        public event Action<object, UStoreRegionArgs> SetTemperature;


        /// <summary>
        /// 升温或降温事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickTemperControlBtn(object sender, EventArgs e)
        {
            UStoreRegionArgs args = new UStoreRegionArgs(SId,
                                                         SRegionId,
                                                         TemperState,
                                                         MinTemper,
                                                         MaxTemper);

            SetTemperature?.Invoke(sender, args);
        }
    }
}
