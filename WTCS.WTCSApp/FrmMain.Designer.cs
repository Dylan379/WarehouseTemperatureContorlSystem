
namespace WTCS.WTCSApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.topPanel = new System.Windows.Forms.Panel();
            this.uiPanel = new System.Windows.Forms.Panel();
            this.btnMin = new WTCS.WTCSApp.UControls.UIconButton();
            this.btnClose = new WTCS.WTCSApp.UControls.UIconButton();
            this.btnMax = new WTCS.WTCSApp.UControls.UIconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dayTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPageTop = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.btnStoreTemperPage = new WTCS.WTCSApp.UControls.UPageButton();
            this.btnProductInStorePage = new WTCS.WTCSApp.UControls.UPageButton();
            this.btnProductManagePage = new WTCS.WTCSApp.UControls.UPageButton();
            this.btnStoreRegionPage = new WTCS.WTCSApp.UControls.UPageButton();
            this.btnStorePage = new WTCS.WTCSApp.UControls.UPageButton();
            this.panelPage = new System.Windows.Forms.Panel();
            this.uPanel2 = new WTCS.WTCSApp.UControls.UPanel();
            this.btnStoreTemperManage = new WTCS.WTCSApp.UControls.UMenuButton();
            this.btnProductManage = new WTCS.WTCSApp.UControls.UMenuButton();
            this.btnStoreManage = new WTCS.WTCSApp.UControls.UMenuButton();
            this.topPanel.SuspendLayout();
            this.uiPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPageTop.SuspendLayout();
            this.uPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.uiPanel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.uPanel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1382, 89);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseMove);
            // 
            // uiPanel
            // 
            this.uiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel.Controls.Add(this.btnMin);
            this.uiPanel.Controls.Add(this.btnClose);
            this.uiPanel.Controls.Add(this.btnMax);
            this.uiPanel.Location = new System.Drawing.Point(1175, 12);
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Size = new System.Drawing.Size(155, 50);
            this.uiPanel.TabIndex = 5;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMin.ForeColor = System.Drawing.Color.Silver;
            this.btnMin.Location = new System.Drawing.Point(15, 10);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "0";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(112, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "r";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMax.ForeColor = System.Drawing.Color.Silver;
            this.btnMax.Location = new System.Drawing.Point(64, 10);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "1";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "仓库温控系统";
            // 
            // uPanel1
            // 
            this.uPanel1.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel1.BackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel1.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources._1700189500065;
            this.uPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.uPanel1.BorderWidth = 0;
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(12, 12);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 30;
            this.uPanel1.Size = new System.Drawing.Size(60, 60);
            this.uPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.dayTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.loginUserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 740);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 60);
            this.panel2.TabIndex = 2;
            // 
            // dayTime
            // 
            this.dayTime.AutoSize = true;
            this.dayTime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayTime.ForeColor = System.Drawing.Color.White;
            this.dayTime.Location = new System.Drawing.Point(596, 26);
            this.dayTime.Name = "dayTime";
            this.dayTime.Size = new System.Drawing.Size(0, 20);
            this.dayTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(491, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "登陆时间:";
            // 
            // loginUserName
            // 
            this.loginUserName.AutoSize = true;
            this.loginUserName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginUserName.ForeColor = System.Drawing.Color.White;
            this.loginUserName.Location = new System.Drawing.Point(122, 26);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(0, 20);
            this.loginUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录用户:";
            // 
            // panelPageTop
            // 
            this.panelPageTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPageTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelPageTop.Controls.Add(this.closeButton);
            this.panelPageTop.Controls.Add(this.btnStoreTemperPage);
            this.panelPageTop.Controls.Add(this.btnProductInStorePage);
            this.panelPageTop.Controls.Add(this.btnProductManagePage);
            this.panelPageTop.Controls.Add(this.btnStoreRegionPage);
            this.panelPageTop.Controls.Add(this.btnStorePage);
            this.panelPageTop.Location = new System.Drawing.Point(309, 98);
            this.panelPageTop.Name = "panelPageTop";
            this.panelPageTop.Size = new System.Drawing.Size(1021, 40);
            this.panelPageTop.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(978, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 40);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.ClickCloseBtn);
            // 
            // btnStoreTemperPage
            // 
            this.btnStoreTemperPage.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreTemperPage.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.btn5;
            this.btnStoreTemperPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoreTemperPage.BtnText = "仓库温控页面";
            this.btnStoreTemperPage.Location = new System.Drawing.Point(746, 0);
            this.btnStoreTemperPage.Name = "btnStoreTemperPage";
            this.btnStoreTemperPage.Size = new System.Drawing.Size(165, 40);
            this.btnStoreTemperPage.TabIndex = 4;
            // 
            // btnProductInStorePage
            // 
            this.btnProductInStorePage.BackColor = System.Drawing.Color.Transparent;
            this.btnProductInStorePage.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.btn4;
            this.btnProductInStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductInStorePage.BtnText = "产品入库页面";
            this.btnProductInStorePage.Location = new System.Drawing.Point(558, 0);
            this.btnProductInStorePage.Name = "btnProductInStorePage";
            this.btnProductInStorePage.Size = new System.Drawing.Size(165, 40);
            this.btnProductInStorePage.TabIndex = 3;
            // 
            // btnProductManagePage
            // 
            this.btnProductManagePage.BackColor = System.Drawing.Color.Transparent;
            this.btnProductManagePage.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.btn3;
            this.btnProductManagePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductManagePage.BtnText = "产品管理页面";
            this.btnProductManagePage.Location = new System.Drawing.Point(371, 0);
            this.btnProductManagePage.Name = "btnProductManagePage";
            this.btnProductManagePage.Size = new System.Drawing.Size(165, 40);
            this.btnProductManagePage.TabIndex = 2;
            // 
            // btnStoreRegionPage
            // 
            this.btnStoreRegionPage.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreRegionPage.BackgroundImage = global::WTCS.WTCSApp.Properties.Resources.btn2;
            this.btnStoreRegionPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoreRegionPage.BtnText = "仓库分区页面";
            this.btnStoreRegionPage.Location = new System.Drawing.Point(186, 0);
            this.btnStoreRegionPage.Name = "btnStoreRegionPage";
            this.btnStoreRegionPage.Size = new System.Drawing.Size(165, 40);
            this.btnStoreRegionPage.TabIndex = 1;
            // 
            // btnStorePage
            // 
            this.btnStorePage.BackColor = System.Drawing.Color.Transparent;
            this.btnStorePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStorePage.BackgroundImage")));
            this.btnStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorePage.BtnText = "仓库管理页面";
            this.btnStorePage.Location = new System.Drawing.Point(3, 0);
            this.btnStorePage.Name = "btnStorePage";
            this.btnStorePage.Size = new System.Drawing.Size(165, 40);
            this.btnStorePage.TabIndex = 0;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Location = new System.Drawing.Point(309, 155);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1021, 577);
            this.panelPage.TabIndex = 9;
            this.panelPage.SizeChanged += new System.EventHandler(this.PagePanelSizeChanged);
            this.panelPage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // uPanel2
            // 
            this.uPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uPanel2.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BorderColor = System.Drawing.Color.Gray;
            this.uPanel2.BorderWidth = 0;
            this.uPanel2.Controls.Add(this.btnStoreTemperManage);
            this.uPanel2.Controls.Add(this.btnProductManage);
            this.uPanel2.Controls.Add(this.btnStoreManage);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(5, 98);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(276, 634);
            this.uPanel2.TabIndex = 1;
            // 
            // btnStoreTemperManage
            // 
            this.btnStoreTemperManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreTemperManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreTemperManage.BtnImage = global::WTCS.WTCSApp.Properties.Resources.Temper;
            this.btnStoreTemperManage.BtnText = "仓库温控管理";
            this.btnStoreTemperManage.Location = new System.Drawing.Point(1, 142);
            this.btnStoreTemperManage.Name = "btnStoreTemperManage";
            this.btnStoreTemperManage.Size = new System.Drawing.Size(276, 60);
            this.btnStoreTemperManage.TabIndex = 3;
            this.btnStoreTemperManage.Click += new System.EventHandler(this.ClickBtnStoreTemperManage);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnProductManage.BtnImage = global::WTCS.WTCSApp.Properties.Resources.product;
            this.btnProductManage.BtnText = "产品管理";
            this.btnProductManage.Location = new System.Drawing.Point(1, 80);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(276, 60);
            this.btnProductManage.TabIndex = 2;
            this.btnProductManage.Click += new System.EventHandler(this.ClickBtnProductManage);
            // 
            // btnStoreManage
            // 
            this.btnStoreManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreManage.BtnImage = ((System.Drawing.Image)(resources.GetObject("btnStoreManage.BtnImage")));
            this.btnStoreManage.BtnText = "仓库管理";
            this.btnStoreManage.Location = new System.Drawing.Point(1, 18);
            this.btnStoreManage.Name = "btnStoreManage";
            this.btnStoreManage.Size = new System.Drawing.Size(276, 60);
            this.btnStoreManage.TabIndex = 1;
            this.btnStoreManage.Click += new System.EventHandler(this.ClickBtnStoreManage);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelPageTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "温控系统主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.uiPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPageTop.ResumeLayout(false);
            this.uPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Label label1;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dayTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPageTop;
        private System.Windows.Forms.Panel panelPage;
        private UControls.UMenuButton btnStoreManage;
        private UControls.UIconButton btnClose;
        private UControls.UIconButton btnMax;
        private UControls.UIconButton btnMin;
        private System.Windows.Forms.Panel uiPanel;
        private UControls.UPageButton btnStorePage;
        private UControls.UPageButton btnProductInStorePage;
        private UControls.UPageButton btnProductManagePage;
        private UControls.UPageButton btnStoreRegionPage;
        private UControls.UPageButton btnStoreTemperPage;
        private UControls.UMenuButton btnStoreTemperManage;
        private UControls.UMenuButton btnProductManage;
        private System.Windows.Forms.Button closeButton;
    }
}