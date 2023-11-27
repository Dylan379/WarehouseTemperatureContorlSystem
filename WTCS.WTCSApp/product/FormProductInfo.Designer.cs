
namespace WTCS.WTCSApp.product
{
    partial class FormProductInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productBackBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.backBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.storeInfoGroup = new System.Windows.Forms.GroupBox();
            this.fitHighestTemperatureInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fitLowestTemperatureInput = new System.Windows.Forms.TextBox();
            this.productNoInput = new System.Windows.Forms.TextBox();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.storeInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.productBackBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 48);
            this.panel1.TabIndex = 4;
            // 
            // productBackBtn
            // 
            this.productBackBtn.AnotherBackGroundColor = System.Drawing.Color.DarkGray;
            this.productBackBtn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productBackBtn.BorderColor = System.Drawing.Color.Gray;
            this.productBackBtn.BorderWidth = 0;
            this.productBackBtn.FlatAppearance.BorderSize = 0;
            this.productBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productBackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.productBackBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.productBackBtn.Location = new System.Drawing.Point(425, 12);
            this.productBackBtn.Name = "productBackBtn";
            this.productBackBtn.Radius = 5;
            this.productBackBtn.Size = new System.Drawing.Size(56, 30);
            this.productBackBtn.TabIndex = 1;
            this.productBackBtn.Text = "返回";
            this.productBackBtn.UseVisualStyleBackColor = true;
            this.productBackBtn.Click += new System.EventHandler(this.ClickBackBtn);
            // 
            // backBtn
            // 
            this.backBtn.AnotherBackGroundColor = System.Drawing.Color.DarkGray;
            this.backBtn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.BorderColor = System.Drawing.Color.Gray;
            this.backBtn.BorderWidth = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.backBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.backBtn.Location = new System.Drawing.Point(584, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Radius = 5;
            this.backBtn.Size = new System.Drawing.Size(56, 30);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "返回";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // storeInfoGroup
            // 
            this.storeInfoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeInfoGroup.Controls.Add(this.fitHighestTemperatureInput);
            this.storeInfoGroup.Controls.Add(this.label4);
            this.storeInfoGroup.Controls.Add(this.fitLowestTemperatureInput);
            this.storeInfoGroup.Controls.Add(this.productNoInput);
            this.storeInfoGroup.Controls.Add(this.productNameInput);
            this.storeInfoGroup.Controls.Add(this.label3);
            this.storeInfoGroup.Controls.Add(this.label2);
            this.storeInfoGroup.Controls.Add(this.label1);
            this.storeInfoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeInfoGroup.ForeColor = System.Drawing.Color.White;
            this.storeInfoGroup.Location = new System.Drawing.Point(34, 54);
            this.storeInfoGroup.Name = "storeInfoGroup";
            this.storeInfoGroup.Size = new System.Drawing.Size(447, 275);
            this.storeInfoGroup.TabIndex = 5;
            this.storeInfoGroup.TabStop = false;
            this.storeInfoGroup.Text = "产品信息";
            // 
            // fitHighestTemperatureInput
            // 
            this.fitHighestTemperatureInput.Location = new System.Drawing.Point(210, 201);
            this.fitHighestTemperatureInput.Name = "fitHighestTemperatureInput";
            this.fitHighestTemperatureInput.Size = new System.Drawing.Size(106, 27);
            this.fitHighestTemperatureInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "适合高温:";
            // 
            // fitLowestTemperatureInput
            // 
            this.fitLowestTemperatureInput.Location = new System.Drawing.Point(210, 149);
            this.fitLowestTemperatureInput.Name = "fitLowestTemperatureInput";
            this.fitLowestTemperatureInput.Size = new System.Drawing.Size(106, 27);
            this.fitLowestTemperatureInput.TabIndex = 5;
            // 
            // productNoInput
            // 
            this.productNoInput.Location = new System.Drawing.Point(210, 103);
            this.productNoInput.Name = "productNoInput";
            this.productNoInput.Size = new System.Drawing.Size(106, 27);
            this.productNoInput.TabIndex = 4;
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(210, 56);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(106, 27);
            this.productNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "适合低温:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品编码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品名称:";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(309, 353);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(74, 48);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "清空";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ClickResetBtn);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(158, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 48);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = " 保存";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.ClickSaveBtn);
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(512, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.storeInfoGroup);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProductInfo";
            this.ShowIcon = false;
            this.Text = "产品信息页";
            this.Load += new System.EventHandler(this.LoadProductInfoPage);
            this.panel1.ResumeLayout(false);
            this.storeInfoGroup.ResumeLayout(false);
            this.storeInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UControls.UCircleButton backBtn;
        private System.Windows.Forms.GroupBox storeInfoGroup;
        private System.Windows.Forms.TextBox fitLowestTemperatureInput;
        private System.Windows.Forms.TextBox productNoInput;
        private System.Windows.Forms.TextBox productNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox fitHighestTemperatureInput;
        private System.Windows.Forms.Label label4;
        private UControls.UCircleButton productBackBtn;
    }
}