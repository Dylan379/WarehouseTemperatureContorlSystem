
namespace WTCS.WTCSApp.product
{
    partial class FormProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productListDGV = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitLowestTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitHighestTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flashBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanel2 = new WTCS.WTCSApp.UControls.UPanel();
            this.isDeletedCheck = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creatBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productListDGV)).BeginInit();
            this.uPanel1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productListDGV
            // 
            this.productListDGV.AllowUserToAddRows = false;
            this.productListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productListDGV.BackgroundColor = System.Drawing.Color.White;
            this.productListDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.productListDGV.ColumnHeadersHeight = 35;
            this.productListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.ProductId,
            this.ProductName,
            this.ProductNo,
            this.FitLowestTemperature,
            this.FitHighestTemperature,
            this.colEdit,
            this.colDelete,
            this.colRecover,
            this.colRemove});
            this.productListDGV.EnableHeadersVisualStyles = false;
            this.productListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.productListDGV.Location = new System.Drawing.Point(0, 123);
            this.productListDGV.Name = "productListDGV";
            this.productListDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.productListDGV.RowHeadersWidth = 51;
            this.productListDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.productListDGV.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.productListDGV.RowTemplate.Height = 27;
            this.productListDGV.Size = new System.Drawing.Size(995, 460);
            this.productListDGV.TabIndex = 5;
            this.productListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 60F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.FillWeight = 60F;
            this.ProductId.HeaderText = "编号";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 120F;
            this.ProductName.HeaderText = "产品名称";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductNo
            // 
            this.ProductNo.DataPropertyName = "ProductNo";
            this.ProductNo.HeaderText = "产品编码";
            this.ProductNo.MinimumWidth = 6;
            this.ProductNo.Name = "ProductNo";
            this.ProductNo.ReadOnly = true;
            // 
            // FitLowestTemperature
            // 
            this.FitLowestTemperature.DataPropertyName = "FitLowestTemperature";
            this.FitLowestTemperature.FillWeight = 120F;
            this.FitLowestTemperature.HeaderText = "适合低温";
            this.FitLowestTemperature.MinimumWidth = 6;
            this.FitLowestTemperature.Name = "FitLowestTemperature";
            this.FitLowestTemperature.ReadOnly = true;
            // 
            // FitHighestTemperature
            // 
            this.FitHighestTemperature.DataPropertyName = "FitHighestTemperature";
            this.FitHighestTemperature.FillWeight = 120F;
            this.FitHighestTemperature.HeaderText = "适合高温";
            this.FitHighestTemperature.MinimumWidth = 6;
            this.FitHighestTemperature.Name = "FitHighestTemperature";
            this.FitHighestTemperature.ReadOnly = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle23;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.TrackVisitedState = false;
            // 
            // colDelete
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle24;
            this.colDelete.HeaderText = "删除";
            this.colDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.TrackVisitedState = false;
            // 
            // colRecover
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.NullValue = "恢复";
            this.colRecover.DefaultCellStyle = dataGridViewCellStyle25;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.MinimumWidth = 6;
            this.colRecover.Name = "colRecover";
            this.colRecover.TrackVisitedState = false;
            // 
            // colRemove
            // 
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle26.NullValue = "移除";
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle26;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.TrackVisitedState = false;
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
            this.uPanel1.Location = new System.Drawing.Point(0, 1);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(996, 60);
            this.uPanel1.TabIndex = 3;
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
            this.label1.Text = "产品管理页面";
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
            this.uPanel2.Controls.Add(this.productNameInput);
            this.uPanel2.Controls.Add(this.label2);
            this.uPanel2.Controls.Add(this.creatBtn);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(3, 62);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(992, 58);
            this.uPanel2.TabIndex = 4;
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
            this.isDeletedCheck.CheckedChanged += new System.EventHandler(this.ChangeIsDeletedCheck);
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
            // productNameInput
            // 
            this.productNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.productNameInput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productNameInput.ForeColor = System.Drawing.Color.White;
            this.productNameInput.Location = new System.Drawing.Point(245, 15);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(135, 27);
            this.productNameInput.TabIndex = 2;
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
            this.label2.Text = "产品名称/编码:";
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
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.uPanel1);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.productListDGV);
            this.Name = "FormProductList";
            this.ShowIcon = false;
            this.Text = "产品管理页面";
            this.Load += new System.EventHandler(this.LoadProductListPage);
            ((System.ComponentModel.ISupportInitialize)(this.productListDGV)).EndInit();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private UControls.UPanel uPanel1;
        private UControls.UCircleButton flashBtn;
        private System.Windows.Forms.CheckBox isDeletedCheck;
        private UControls.UCircleButton deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox productNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button creatBtn;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.DataGridView productListDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitLowestTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitHighestTemperature;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}