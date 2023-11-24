
namespace WTCS.WTCSApp.store
{
    partial class FormStoreRegionInfo
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
            this.backBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.storeInfoGroup = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentTemperatureInput = new System.Windows.Forms.TextBox();
            this.regionNoInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regionNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TemperPanel = new System.Windows.Forms.Panel();
            this.allowHighestTemperInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.allowLowestTemperInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.regionRemarkInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.storeNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.storeInfoGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TemperPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 50);
            this.panel1.TabIndex = 4;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.AnotherBackGroundColor = System.Drawing.Color.DarkGray;
            this.backBtn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.BorderColor = System.Drawing.Color.Gray;
            this.backBtn.BorderWidth = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.backBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.backBtn.Location = new System.Drawing.Point(670, 12);
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
            this.storeInfoGroup.Controls.Add(this.panel4);
            this.storeInfoGroup.Controls.Add(this.TemperPanel);
            this.storeInfoGroup.Controls.Add(this.panel2);
            this.storeInfoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeInfoGroup.ForeColor = System.Drawing.Color.White;
            this.storeInfoGroup.Location = new System.Drawing.Point(33, 56);
            this.storeInfoGroup.Name = "storeInfoGroup";
            this.storeInfoGroup.Size = new System.Drawing.Size(692, 390);
            this.storeInfoGroup.TabIndex = 5;
            this.storeInfoGroup.TabStop = false;
            this.storeInfoGroup.Text = "仓库分区信息";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(419, 487);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(64, 33);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "清空";
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(258, 487);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(64, 33);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = " 保存";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.storeNameComboBox);
            this.panel2.Controls.Add(this.currentTemperatureInput);
            this.panel2.Controls.Add(this.regionNoInput);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.regionNameInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 100);
            this.panel2.TabIndex = 6;
            // 
            // currentTemperatureInput
            // 
            this.currentTemperatureInput.Location = new System.Drawing.Point(472, 57);
            this.currentTemperatureInput.Name = "currentTemperatureInput";
            this.currentTemperatureInput.Size = new System.Drawing.Size(189, 27);
            this.currentTemperatureInput.TabIndex = 17;
            // 
            // regionNoInput
            // 
            this.regionNoInput.Location = new System.Drawing.Point(472, 16);
            this.regionNoInput.Name = "regionNoInput";
            this.regionNoInput.Size = new System.Drawing.Size(189, 27);
            this.regionNoInput.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "当前温度:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "分区编码:";
            // 
            // regionNameInput
            // 
            this.regionNameInput.Location = new System.Drawing.Point(134, 16);
            this.regionNameInput.Name = "regionNameInput";
            this.regionNameInput.Size = new System.Drawing.Size(185, 27);
            this.regionNameInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "所属仓库:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "分区名称:";
            // 
            // TemperPanel
            // 
            this.TemperPanel.Controls.Add(this.allowHighestTemperInput);
            this.TemperPanel.Controls.Add(this.label7);
            this.TemperPanel.Controls.Add(this.label6);
            this.TemperPanel.Controls.Add(this.allowLowestTemperInput);
            this.TemperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TemperPanel.Location = new System.Drawing.Point(3, 123);
            this.TemperPanel.Name = "TemperPanel";
            this.TemperPanel.Size = new System.Drawing.Size(686, 90);
            this.TemperPanel.TabIndex = 7;
            this.TemperPanel.Visible = false;
            // 
            // allowHighestTemperInput
            // 
            this.allowHighestTemperInput.Location = new System.Drawing.Point(472, 35);
            this.allowHighestTemperInput.Name = "allowHighestTemperInput";
            this.allowHighestTemperInput.Size = new System.Drawing.Size(189, 27);
            this.allowHighestTemperInput.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "允许高温值:";
            // 
            // allowLowestTemperInput
            // 
            this.allowLowestTemperInput.Location = new System.Drawing.Point(134, 35);
            this.allowLowestTemperInput.Name = "allowLowestTemperInput";
            this.allowLowestTemperInput.Size = new System.Drawing.Size(185, 27);
            this.allowLowestTemperInput.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "允许低温值:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.regionRemarkInput);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 174);
            this.panel4.TabIndex = 8;
            // 
            // regionRemarkInput
            // 
            this.regionRemarkInput.Location = new System.Drawing.Point(134, 20);
            this.regionRemarkInput.Multiline = true;
            this.regionRemarkInput.Name = "regionRemarkInput";
            this.regionRemarkInput.Size = new System.Drawing.Size(494, 145);
            this.regionRemarkInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "分区描述:";
            // 
            // storeNameComboBox
            // 
            this.storeNameComboBox.FormattingEnabled = true;
            this.storeNameComboBox.Location = new System.Drawing.Point(134, 60);
            this.storeNameComboBox.Name = "storeNameComboBox";
            this.storeNameComboBox.Size = new System.Drawing.Size(185, 28);
            this.storeNameComboBox.TabIndex = 18;
            // 
            // FormStoreRegionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(757, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.storeInfoGroup);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "FormStoreRegionInfo";
            this.ShowIcon = false;
            this.Text = "仓库分区信息";
            this.Load += new System.EventHandler(this.LoadStoreRegionForm);
            this.panel1.ResumeLayout(false);
            this.storeInfoGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TemperPanel.ResumeLayout(false);
            this.TemperPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UControls.UCircleButton backBtn;
        private System.Windows.Forms.GroupBox storeInfoGroup;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox regionRemarkInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel TemperPanel;
        private System.Windows.Forms.TextBox allowHighestTemperInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox allowLowestTemperInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox currentTemperatureInput;
        private System.Windows.Forms.TextBox regionNoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regionNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox storeNameComboBox;
    }
}