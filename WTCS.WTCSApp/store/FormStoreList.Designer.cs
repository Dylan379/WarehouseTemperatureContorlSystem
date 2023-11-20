
namespace WTCS.WTCSApp.store
{
    partial class FormStoreList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flashBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanel2 = new WTCS.WTCSApp.UControls.UPanel();
            this.isDeletedCheck = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.storeNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creatBtn = new System.Windows.Forms.Button();
            this.storeListDGV = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddRegion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanel1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel1.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uPanel1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BorderColor = System.Drawing.Color.Gray;
            this.uPanel1.BorderWidth = 0;
            this.uPanel1.Controls.Add(this.panel1);
            this.uPanel1.Controls.Add(this.flashBtn);
            this.uPanel1.Controls.Add(this.label1);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(0, 0);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(996, 60);
            this.uPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 58);
            this.panel1.TabIndex = 0;
            // 
            // flashBtn
            // 
            this.flashBtn.AnotherBackGroundColor = System.Drawing.Color.MidnightBlue;
            this.flashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.flashBtn.BackGroundColor = System.Drawing.Color.CornflowerBlue;
            this.flashBtn.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.flashBtn.BorderWidth = 0;
            this.flashBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.flashBtn.FlatAppearance.BorderSize = 0;
            this.flashBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flashBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flashBtn.ForeColor = System.Drawing.Color.White;
            this.flashBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.flashBtn.Location = new System.Drawing.Point(757, 12);
            this.flashBtn.Name = "flashBtn";
            this.flashBtn.Radius = 10;
            this.flashBtn.Size = new System.Drawing.Size(60, 33);
            this.flashBtn.TabIndex = 1;
            this.flashBtn.Text = "刷新";
            this.flashBtn.UseVisualStyleBackColor = false;
            this.flashBtn.Click += new System.EventHandler(this.ClickFlashBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库管理页面";
            // 
            // uPanel2
            // 
            this.uPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel2.AnotherBackGroundColor = System.Drawing.Color.Transparent;
            this.uPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BorderColor = System.Drawing.Color.Gray;
            this.uPanel2.BorderWidth = 0;
            this.uPanel2.Controls.Add(this.isDeletedCheck);
            this.uPanel2.Controls.Add(this.deleteBtn);
            this.uPanel2.Controls.Add(this.searchBtn);
            this.uPanel2.Controls.Add(this.storeNameInput);
            this.uPanel2.Controls.Add(this.label2);
            this.uPanel2.Controls.Add(this.creatBtn);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(3, 61);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(992, 58);
            this.uPanel2.TabIndex = 1;
            // 
            // isDeletedCheck
            // 
            this.isDeletedCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isDeletedCheck.AutoSize = true;
            this.isDeletedCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isDeletedCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isDeletedCheck.ForeColor = System.Drawing.Color.Chocolate;
            this.isDeletedCheck.Location = new System.Drawing.Point(754, 16);
            this.isDeletedCheck.Name = "isDeletedCheck";
            this.isDeletedCheck.Size = new System.Drawing.Size(72, 24);
            this.isDeletedCheck.TabIndex = 5;
            this.isDeletedCheck.Text = "已删除";
            this.isDeletedCheck.UseVisualStyleBackColor = true;
            this.isDeletedCheck.CheckedChanged += new System.EventHandler(this.IsDeletedCheckedChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AnotherBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.deleteBtn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(122)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.Gray;
            this.deleteBtn.BorderWidth = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.deleteBtn.Location = new System.Drawing.Point(520, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 15;
            this.deleteBtn.Size = new System.Drawing.Size(65, 35);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.ClickDeleteBtn);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(422, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(55, 30);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "查询";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.ClickSearchBtn);
            // 
            // storeNameInput
            // 
            this.storeNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeNameInput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeNameInput.ForeColor = System.Drawing.Color.White;
            this.storeNameInput.Location = new System.Drawing.Point(245, 15);
            this.storeNameInput.Name = "storeNameInput";
            this.storeNameInput.Size = new System.Drawing.Size(135, 27);
            this.storeNameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(119, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "仓库名称/编码:";
            // 
            // creatBtn
            // 
            this.creatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(246)))));
            this.creatBtn.FlatAppearance.BorderSize = 0;
            this.creatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.creatBtn.ForeColor = System.Drawing.Color.White;
            this.creatBtn.Location = new System.Drawing.Point(26, 13);
            this.creatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(55, 30);
            this.creatBtn.TabIndex = 0;
            this.creatBtn.Text = "新增";
            this.creatBtn.UseVisualStyleBackColor = false;
            this.creatBtn.Click += new System.EventHandler(this.ClickCreatBtn);
            // 
            // storeListDGV
            // 
            this.storeListDGV.AllowUserToAddRows = false;
            this.storeListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeListDGV.BackgroundColor = System.Drawing.Color.White;
            this.storeListDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.storeListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.storeListDGV.ColumnHeadersHeight = 35;
            this.storeListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.storeListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.StoreId,
            this.StoreNo,
            this.StoreName,
            this.RegionCount,
            this.Remark,
            this.colAddRegion,
            this.colEdit,
            this.colDelete,
            this.colRecover,
            this.colRemove});
            this.storeListDGV.EnableHeadersVisualStyles = false;
            this.storeListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeListDGV.Location = new System.Drawing.Point(0, 122);
            this.storeListDGV.Name = "storeListDGV";
            this.storeListDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.storeListDGV.RowHeadersWidth = 51;
            this.storeListDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.storeListDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.storeListDGV.RowTemplate.Height = 27;
            this.storeListDGV.Size = new System.Drawing.Size(995, 460);
            this.storeListDGV.TabIndex = 2;
            this.storeListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 60F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "StoreId";
            this.StoreId.FillWeight = 60F;
            this.StoreId.HeaderText = "编号";
            this.StoreId.MinimumWidth = 6;
            this.StoreId.Name = "StoreId";
            this.StoreId.ReadOnly = true;
            // 
            // StoreNo
            // 
            this.StoreNo.DataPropertyName = "StoreNo";
            this.StoreNo.HeaderText = "仓库编码";
            this.StoreNo.MinimumWidth = 6;
            this.StoreNo.Name = "StoreNo";
            this.StoreNo.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.FillWeight = 150F;
            this.StoreName.HeaderText = "仓库名称";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // RegionCount
            // 
            this.RegionCount.DataPropertyName = "RegionCount";
            this.RegionCount.FillWeight = 80F;
            this.RegionCount.HeaderText = "分区数";
            this.RegionCount.MinimumWidth = 6;
            this.RegionCount.Name = "RegionCount";
            this.RegionCount.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 180F;
            this.Remark.HeaderText = "描述";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // colAddRegion
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.NullValue = "添加分区";
            this.colAddRegion.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAddRegion.HeaderText = "添加分区";
            this.colAddRegion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colAddRegion.MinimumWidth = 6;
            this.colAddRegion.Name = "colAddRegion";
            this.colAddRegion.TrackVisitedState = false;
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.TrackVisitedState = false;
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "删除";
            this.colDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.TrackVisitedState = false;
            // 
            // colRecover
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.NullValue = "恢复";
            this.colRecover.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.MinimumWidth = 6;
            this.colRecover.Name = "colRecover";
            this.colRecover.TrackVisitedState = false;
            // 
            // colRemove
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.NullValue = "移除";
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle6;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.TrackVisitedState = false;
            // 
            // FormStoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.storeListDGV);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FormStoreList";
            this.Text = "仓库信息管理页面";
            this.Load += new System.EventHandler(this.LoadStoreListForm);
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Label label1;
        private UControls.UCircleButton flashBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox storeNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button creatBtn;
        private UControls.UCircleButton deleteBtn;
        private System.Windows.Forms.CheckBox isDeletedCheck;
        private System.Windows.Forms.DataGridView storeListDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn colAddRegion;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}