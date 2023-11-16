
namespace WTCS.WTCSApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.pwdPanel = new WTCS.WTCSApp.UControls.UPanel();
            this.userPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountPanel = new WTCS.WTCSApp.UControls.UPanel();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.pwdPanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.blue;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.pwdPanel);
            this.loginPanel.Controls.Add(this.accountPanel);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(157, 128);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(701, 346);
            this.loginPanel.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.BorderWidth = 0;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.loginBtn.Location = new System.Drawing.Point(73, 267);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Radius = 10;
            this.loginBtn.Size = new System.Drawing.Size(564, 58);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "登 录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pwdPanel
            // 
            this.pwdPanel.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.pwdPanel.BackGroundColor = System.Drawing.Color.Transparent;
            this.pwdPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.pwdPanel.BorderWidth = 1;
            this.pwdPanel.Controls.Add(this.userPwd);
            this.pwdPanel.Controls.Add(this.label3);
            this.pwdPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pwdPanel.Location = new System.Drawing.Point(73, 179);
            this.pwdPanel.Name = "pwdPanel";
            this.pwdPanel.Radius = 5;
            this.pwdPanel.Size = new System.Drawing.Size(564, 67);
            this.pwdPanel.TabIndex = 2;
            // 
            // userPwd
            // 
            this.userPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(106)))));
            this.userPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPwd.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPwd.ForeColor = System.Drawing.Color.White;
            this.userPwd.Location = new System.Drawing.Point(101, 17);
            this.userPwd.Name = "userPwd";
            this.userPwd.Size = new System.Drawing.Size(375, 38);
            this.userPwd.TabIndex = 2;
            this.userPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码：";
            // 
            // accountPanel
            // 
            this.accountPanel.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.accountPanel.BackGroundColor = System.Drawing.Color.Transparent;
            this.accountPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.accountPanel.BorderWidth = 1;
            this.accountPanel.Controls.Add(this.userName);
            this.accountPanel.Controls.Add(this.label2);
            this.accountPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.accountPanel.Location = new System.Drawing.Point(73, 84);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Radius = 5;
            this.accountPanel.Size = new System.Drawing.Size(564, 67);
            this.accountPanel.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(106)))));
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(101, 16);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(375, 38);
            this.userName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库温控系统";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.minimalist;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 607);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "仓库温控系统登录界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.pwdPanel.ResumeLayout(false);
            this.pwdPanel.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label1;
        private UControls.UPanel accountPanel;
        private UControls.UPanel pwdPanel;
        private UControls.UCircleButton loginBtn;
        private System.Windows.Forms.TextBox userPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
    }
}

