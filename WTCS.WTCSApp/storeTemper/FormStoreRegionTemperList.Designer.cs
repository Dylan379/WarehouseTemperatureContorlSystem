
namespace WTCS.WTCSApp.storeTemper
{
    partial class FormStoreRegionTemperList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.uIndicatorLight3 = new WTCS.WTCSApp.UControls.UIndicatorLight();
            this.uIndicatorLight2 = new WTCS.WTCSApp.UControls.UIndicatorLight();
            this.uIndicatorLight1 = new WTCS.WTCSApp.UControls.UIndicatorLight();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uPanel1
            // 
            this.uPanel1.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BorderColor = System.Drawing.Color.Gray;
            this.uPanel1.BorderWidth = 0;
            this.uPanel1.Controls.Add(this.uIndicatorLight3);
            this.uPanel1.Controls.Add(this.uIndicatorLight2);
            this.uPanel1.Controls.Add(this.uIndicatorLight1);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(91, 99);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(659, 69);
            this.uPanel1.TabIndex = 2;
            // 
            // uIndicatorLight3
            // 
            this.uIndicatorLight3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight3.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.uIndicatorLight3.LightText = "高温";
            this.uIndicatorLight3.Location = new System.Drawing.Point(360, 13);
            this.uIndicatorLight3.Name = "uIndicatorLight3";
            this.uIndicatorLight3.Size = new System.Drawing.Size(90, 40);
            this.uIndicatorLight3.TabIndex = 2;
            // 
            // uIndicatorLight2
            // 
            this.uIndicatorLight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight2.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uIndicatorLight2.LightText = "正常";
            this.uIndicatorLight2.Location = new System.Drawing.Point(525, 13);
            this.uIndicatorLight2.Name = "uIndicatorLight2";
            this.uIndicatorLight2.Size = new System.Drawing.Size(90, 40);
            this.uIndicatorLight2.TabIndex = 1;
            // 
            // uIndicatorLight1
            // 
            this.uIndicatorLight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uIndicatorLight1.LightText = "低温";
            this.uIndicatorLight1.Location = new System.Drawing.Point(197, 13);
            this.uIndicatorLight1.Name = "uIndicatorLight1";
            this.uIndicatorLight1.Size = new System.Drawing.Size(90, 40);
            this.uIndicatorLight1.TabIndex = 0;
            // 
            // FormStoreRegionTemperList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uPanel1);
            this.Name = "FormStoreRegionTemperList";
            this.Text = "仓库分区温度管理页面";
            this.uPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UControls.UPanel uPanel1;
        private UControls.UIndicatorLight uIndicatorLight1;
        private UControls.UIndicatorLight uIndicatorLight3;
        private UControls.UIndicatorLight uIndicatorLight2;
    }
}