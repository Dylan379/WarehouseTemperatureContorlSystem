
namespace WTCS.WTCSApp.store
{
    partial class FormStoreInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.storeNameInput = new System.Windows.Forms.TextBox();
            this.storeNoInput = new System.Windows.Forms.TextBox();
            this.storeRemarkInput = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.storeInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 50);
            this.panel1.TabIndex = 0;
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
            this.backBtn.Click += new System.EventHandler(this.ClickBackBtn);
            // 
            // storeInfoGroup
            // 
            this.storeInfoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeInfoGroup.Controls.Add(this.storeRemarkInput);
            this.storeInfoGroup.Controls.Add(this.storeNoInput);
            this.storeInfoGroup.Controls.Add(this.storeNameInput);
            this.storeInfoGroup.Controls.Add(this.label3);
            this.storeInfoGroup.Controls.Add(this.label2);
            this.storeInfoGroup.Controls.Add(this.label1);
            this.storeInfoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeInfoGroup.ForeColor = System.Drawing.Color.White;
            this.storeInfoGroup.Location = new System.Drawing.Point(27, 55);
            this.storeInfoGroup.Name = "storeInfoGroup";
            this.storeInfoGroup.Size = new System.Drawing.Size(605, 347);
            this.storeInfoGroup.TabIndex = 1;
            this.storeInfoGroup.TabStop = false;
            this.storeInfoGroup.Text = "仓库信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库编码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓库描述:";
            // 
            // storeNameInput
            // 
            this.storeNameInput.Location = new System.Drawing.Point(169, 60);
            this.storeNameInput.Name = "storeNameInput";
            this.storeNameInput.Size = new System.Drawing.Size(199, 27);
            this.storeNameInput.TabIndex = 3;
            // 
            // storeNoInput
            // 
            this.storeNoInput.Location = new System.Drawing.Point(169, 118);
            this.storeNoInput.Name = "storeNoInput";
            this.storeNoInput.Size = new System.Drawing.Size(199, 27);
            this.storeNoInput.TabIndex = 4;
            // 
            // storeRemarkInput
            // 
            this.storeRemarkInput.Location = new System.Drawing.Point(169, 175);
            this.storeRemarkInput.Multiline = true;
            this.storeRemarkInput.Name = "storeRemarkInput";
            this.storeRemarkInput.Size = new System.Drawing.Size(334, 147);
            this.storeRemarkInput.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(208, 437);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(64, 33);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = " 保存";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.ClickSaveBtn);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(331, 437);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(64, 33);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "清空";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ClickRestBtn);
            // 
            // FormStoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(652, 503);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.storeInfoGroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStoreInfo";
            this.ShowIcon = false;
            this.Text = "仓库信息页面";
            this.Load += new System.EventHandler(this.LoadStoreInfoPage);
            this.panel1.ResumeLayout(false);
            this.storeInfoGroup.ResumeLayout(false);
            this.storeInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UControls.UCircleButton backBtn;
        private System.Windows.Forms.GroupBox storeInfoGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox storeRemarkInput;
        private System.Windows.Forms.TextBox storeNoInput;
        private System.Windows.Forms.TextBox storeNameInput;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}