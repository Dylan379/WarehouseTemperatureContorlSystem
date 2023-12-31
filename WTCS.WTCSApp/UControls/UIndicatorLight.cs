﻿using System;
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
    public partial class UIndicatorLight : UserControl
    {
        public UIndicatorLight()
        {
            InitializeComponent();
        }


        //指示灯颜色
        public Color CircleColor
        {
            get { return uCircleLight.ForeColor; }
            set
            {
                uCircleLight.ForeColor = value;
            }
        }

        //指示灯描述
        public string LightText
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }


    }
}
