
namespace WTCS.WTCSApp.UControls
{
    partial class UStoreRegionBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.temperatureChangeBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.SRegionNameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uTemperValue = new WTCS.WTCSApp.UControls.UThermometer();
            this.label6 = new System.Windows.Forms.Label();
            this.SRTemperStateLight = new WTCS.WTCSApp.UControls.UCircle();
            this.temperatureRangeLabel = new System.Windows.Forms.Label();
            this.currentTemperatureLabel = new System.Windows.Forms.Label();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.temperatureChangeBtn);
            this.panel1.Controls.Add(this.SRegionNameText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 42);
            this.panel1.TabIndex = 0;
            // 
            // temperatureChangeBtn
            // 
            this.temperatureChangeBtn.AnotherBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.temperatureChangeBtn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(118)))));
            this.temperatureChangeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.temperatureChangeBtn.BorderWidth = 0;
            this.temperatureChangeBtn.FlatAppearance.BorderSize = 0;
            this.temperatureChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temperatureChangeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperatureChangeBtn.ForeColor = System.Drawing.Color.White;
            this.temperatureChangeBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.temperatureChangeBtn.Location = new System.Drawing.Point(257, 9);
            this.temperatureChangeBtn.Name = "temperatureChangeBtn";
            this.temperatureChangeBtn.Radius = 10;
            this.temperatureChangeBtn.Size = new System.Drawing.Size(62, 27);
            this.temperatureChangeBtn.TabIndex = 2;
            this.temperatureChangeBtn.Text = "温控";
            this.temperatureChangeBtn.UseVisualStyleBackColor = true;
            this.temperatureChangeBtn.Click += new System.EventHandler(this.ClickTemperControlBtn);
            // 
            // SRegionNameText
            // 
            this.SRegionNameText.AutoSize = true;
            this.SRegionNameText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SRegionNameText.ForeColor = System.Drawing.Color.White;
            this.SRegionNameText.Location = new System.Drawing.Point(122, 9);
            this.SRegionNameText.Name = "SRegionNameText";
            this.SRegionNameText.Size = new System.Drawing.Size(44, 26);
            this.SRegionNameText.TabIndex = 1;
            this.SRegionNameText.Text = "0-0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库分区:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.uTemperValue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.SRTemperStateLight);
            this.panel2.Controls.Add(this.temperatureRangeLabel);
            this.panel2.Controls.Add(this.currentTemperatureLabel);
            this.panel2.Controls.Add(this.productCountLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 168);
            this.panel2.TabIndex = 1;
            // 
            // uTemperValue
            // 
            this.uTemperValue.BMaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uTemperValue.BMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uTemperValue.Font = new System.Drawing.Font("SimSun", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uTemperValue.ForeColor = System.Drawing.Color.White;
            this.uTemperValue.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.uTemperValue.LeftTemperatureUnit = WTCS.WTCSApp.UControls.UThermometer.TemperatureUnit.C;
            this.uTemperValue.Location = new System.Drawing.Point(257, 3);
            this.uTemperValue.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.uTemperValue.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.uTemperValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uTemperValue.Name = "uTemperValue";
            this.uTemperValue.Size = new System.Drawing.Size(71, 154);
            this.uTemperValue.SpCount = 5;
            this.uTemperValue.TabIndex = 12;
            this.uTemperValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uTemperValue.ValueColor = System.Drawing.Color.White;
            this.uTemperValue.ValueFont = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(142, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "℃";
            // 
            // SRTemperStateLight
            // 
            this.SRTemperStateLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.SRTemperStateLight.Location = new System.Drawing.Point(107, 131);
            this.SRTemperStateLight.Name = "SRTemperStateLight";
            this.SRTemperStateLight.Size = new System.Drawing.Size(20, 20);
            this.SRTemperStateLight.TabIndex = 7;
            // 
            // temperatureRangeLabel
            // 
            this.temperatureRangeLabel.AutoSize = true;
            this.temperatureRangeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperatureRangeLabel.ForeColor = System.Drawing.Color.White;
            this.temperatureRangeLabel.Location = new System.Drawing.Point(103, 95);
            this.temperatureRangeLabel.Name = "temperatureRangeLabel";
            this.temperatureRangeLabel.Size = new System.Drawing.Size(109, 19);
            this.temperatureRangeLabel.TabIndex = 6;
            this.temperatureRangeLabel.Text = "15.6 ~ 25.6 ℃";
            // 
            // currentTemperatureLabel
            // 
            this.currentTemperatureLabel.AutoSize = true;
            this.currentTemperatureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentTemperatureLabel.ForeColor = System.Drawing.Color.Yellow;
            this.currentTemperatureLabel.Location = new System.Drawing.Point(103, 54);
            this.currentTemperatureLabel.Name = "currentTemperatureLabel";
            this.currentTemperatureLabel.Size = new System.Drawing.Size(40, 19);
            this.currentTemperatureLabel.TabIndex = 5;
            this.currentTemperatureLabel.Text = "25.5";
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productCountLabel.ForeColor = System.Drawing.Color.White;
            this.productCountLabel.Location = new System.Drawing.Point(103, 15);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(27, 19);
            this.productCountLabel.TabIndex = 4;
            this.productCountLabel.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "当前状态:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "温度范围:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "室内温度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "产品数量:";
            // 
            // UStoreRegionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UStoreRegionBox";
            this.Size = new System.Drawing.Size(348, 210);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SRegionNameText;
        private UCircleButton temperatureChangeBtn;
        private UCircle SRTemperStateLight;
        private System.Windows.Forms.Label temperatureRangeLabel;
        private System.Windows.Forms.Label currentTemperatureLabel;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private UThermometer uTemperValue;
    }
}
