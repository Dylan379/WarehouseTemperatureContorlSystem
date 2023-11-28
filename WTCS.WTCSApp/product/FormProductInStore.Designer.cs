
namespace WTCS.WTCSApp.product
{
    partial class FormProductInStore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flashBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.typeNameLabel = new System.Windows.Forms.Label();
            this.productInStoreListBtn = new System.Windows.Forms.Button();
            this.productInStoreRecordBtn = new System.Windows.Forms.Button();
            this.productInStoresDGV = new System.Windows.Forms.DataGridView();
            this.ProStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeInfoGroup = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.inStoreBtn = new System.Windows.Forms.Button();
            this.inStoreCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.sRegionNameCobx = new System.Windows.Forms.ComboBox();
            this.inStoreNameCobx = new System.Windows.Forms.ComboBox();
            this.storeProductNameCobx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInStoresDGV)).BeginInit();
            this.storeInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreCountUpDown)).BeginInit();
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
            this.uPanel1.TabIndex = 4;
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
            this.flashBtn.Location = new System.Drawing.Point(891, 11);
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
            this.label1.Text = "产品入库页面";
            // 
            // typeNameLabel
            // 
            this.typeNameLabel.AutoSize = true;
            this.typeNameLabel.ForeColor = System.Drawing.Color.White;
            this.typeNameLabel.Location = new System.Drawing.Point(12, 131);
            this.typeNameLabel.Name = "typeNameLabel";
            this.typeNameLabel.Size = new System.Drawing.Size(75, 15);
            this.typeNameLabel.TabIndex = 5;
            this.typeNameLabel.Text = "入库记录:";
            // 
            // productInStoreListBtn
            // 
            this.productInStoreListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(122)))), ((int)(((byte)(200)))));
            this.productInStoreListBtn.FlatAppearance.BorderSize = 0;
            this.productInStoreListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productInStoreListBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productInStoreListBtn.ForeColor = System.Drawing.Color.White;
            this.productInStoreListBtn.Location = new System.Drawing.Point(130, 102);
            this.productInStoreListBtn.Name = "productInStoreListBtn";
            this.productInStoreListBtn.Size = new System.Drawing.Size(145, 45);
            this.productInStoreListBtn.TabIndex = 6;
            this.productInStoreListBtn.Text = "产品库存列表";
            this.productInStoreListBtn.UseVisualStyleBackColor = false;
            this.productInStoreListBtn.Click += new System.EventHandler(this.ClickProductStoreList);
            // 
            // productInStoreRecordBtn
            // 
            this.productInStoreRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.productInStoreRecordBtn.FlatAppearance.BorderSize = 0;
            this.productInStoreRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productInStoreRecordBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productInStoreRecordBtn.ForeColor = System.Drawing.Color.White;
            this.productInStoreRecordBtn.Location = new System.Drawing.Point(315, 102);
            this.productInStoreRecordBtn.Name = "productInStoreRecordBtn";
            this.productInStoreRecordBtn.Size = new System.Drawing.Size(143, 44);
            this.productInStoreRecordBtn.TabIndex = 7;
            this.productInStoreRecordBtn.Text = "产品入库记录";
            this.productInStoreRecordBtn.UseVisualStyleBackColor = false;
            this.productInStoreRecordBtn.Click += new System.EventHandler(this.ClickProductInStoreRecord);
            // 
            // productInStoresDGV
            // 
            this.productInStoresDGV.AllowUserToAddRows = false;
            this.productInStoresDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productInStoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productInStoresDGV.BackgroundColor = System.Drawing.Color.White;
            this.productInStoresDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productInStoresDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productInStoresDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.productInStoresDGV.ColumnHeadersHeight = 35;
            this.productInStoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productInStoresDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProStoreId,
            this.ProductName,
            this.StoreName,
            this.SRegionName,
            this.ProductCount});
            this.productInStoresDGV.EnableHeadersVisualStyles = false;
            this.productInStoresDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.productInStoresDGV.Location = new System.Drawing.Point(3, 178);
            this.productInStoresDGV.Name = "productInStoresDGV";
            this.productInStoresDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productInStoresDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.productInStoresDGV.RowHeadersWidth = 51;
            this.productInStoresDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.productInStoresDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.productInStoresDGV.RowTemplate.Height = 27;
            this.productInStoresDGV.Size = new System.Drawing.Size(567, 399);
            this.productInStoresDGV.TabIndex = 8;
            // 
            // ProStoreId
            // 
            this.ProStoreId.DataPropertyName = "ProStoreId";
            this.ProStoreId.FillWeight = 60F;
            this.ProStoreId.HeaderText = "编号";
            this.ProStoreId.MinimumWidth = 6;
            this.ProStoreId.Name = "ProStoreId";
            this.ProStoreId.ReadOnly = true;
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
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "仓库";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.FillWeight = 120F;
            this.SRegionName.HeaderText = "分区";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            this.SRegionName.ReadOnly = true;
            // 
            // ProductCount
            // 
            this.ProductCount.DataPropertyName = "ProductCount";
            this.ProductCount.FillWeight = 120F;
            this.ProductCount.HeaderText = "库存数量";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            // 
            // storeInfoGroup
            // 
            this.storeInfoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storeInfoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeInfoGroup.Controls.Add(this.resetBtn);
            this.storeInfoGroup.Controls.Add(this.inStoreBtn);
            this.storeInfoGroup.Controls.Add(this.inStoreCountUpDown);
            this.storeInfoGroup.Controls.Add(this.sRegionNameCobx);
            this.storeInfoGroup.Controls.Add(this.inStoreNameCobx);
            this.storeInfoGroup.Controls.Add(this.storeProductNameCobx);
            this.storeInfoGroup.Controls.Add(this.label4);
            this.storeInfoGroup.Controls.Add(this.label3);
            this.storeInfoGroup.Controls.Add(this.label5);
            this.storeInfoGroup.Controls.Add(this.label6);
            this.storeInfoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeInfoGroup.ForeColor = System.Drawing.Color.White;
            this.storeInfoGroup.Location = new System.Drawing.Point(582, 178);
            this.storeInfoGroup.Name = "storeInfoGroup";
            this.storeInfoGroup.Size = new System.Drawing.Size(402, 399);
            this.storeInfoGroup.TabIndex = 9;
            this.storeInfoGroup.TabStop = false;
            this.storeInfoGroup.Text = "入库设置";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(122)))), ((int)(((byte)(200)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Location = new System.Drawing.Point(222, 339);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(77, 36);
            this.resetBtn.TabIndex = 15;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ClickResetBtn);
            // 
            // inStoreBtn
            // 
            this.inStoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.inStoreBtn.FlatAppearance.BorderSize = 0;
            this.inStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inStoreBtn.Location = new System.Drawing.Point(113, 339);
            this.inStoreBtn.Name = "inStoreBtn";
            this.inStoreBtn.Size = new System.Drawing.Size(75, 36);
            this.inStoreBtn.TabIndex = 14;
            this.inStoreBtn.Text = "入库";
            this.inStoreBtn.UseVisualStyleBackColor = false;
            this.inStoreBtn.Click += new System.EventHandler(this.ClickInStoreBtn);
            // 
            // inStoreCountUpDown
            // 
            this.inStoreCountUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.inStoreCountUpDown.ForeColor = System.Drawing.Color.White;
            this.inStoreCountUpDown.Location = new System.Drawing.Point(113, 288);
            this.inStoreCountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inStoreCountUpDown.Name = "inStoreCountUpDown";
            this.inStoreCountUpDown.Size = new System.Drawing.Size(198, 27);
            this.inStoreCountUpDown.TabIndex = 13;
            // 
            // sRegionNameCobx
            // 
            this.sRegionNameCobx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.sRegionNameCobx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sRegionNameCobx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sRegionNameCobx.ForeColor = System.Drawing.Color.White;
            this.sRegionNameCobx.FormattingEnabled = true;
            this.sRegionNameCobx.Location = new System.Drawing.Point(113, 208);
            this.sRegionNameCobx.Name = "sRegionNameCobx";
            this.sRegionNameCobx.Size = new System.Drawing.Size(198, 28);
            this.sRegionNameCobx.TabIndex = 12;
            // 
            // inStoreNameCobx
            // 
            this.inStoreNameCobx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.inStoreNameCobx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inStoreNameCobx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inStoreNameCobx.ForeColor = System.Drawing.Color.White;
            this.inStoreNameCobx.FormattingEnabled = true;
            this.inStoreNameCobx.Location = new System.Drawing.Point(113, 139);
            this.inStoreNameCobx.Name = "inStoreNameCobx";
            this.inStoreNameCobx.Size = new System.Drawing.Size(198, 28);
            this.inStoreNameCobx.TabIndex = 11;
            this.inStoreNameCobx.SelectedIndexChanged += new System.EventHandler(this.ChangStoreNameSelected);
            // 
            // storeProductNameCobx
            // 
            this.storeProductNameCobx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeProductNameCobx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeProductNameCobx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeProductNameCobx.ForeColor = System.Drawing.Color.White;
            this.storeProductNameCobx.FormattingEnabled = true;
            this.storeProductNameCobx.Location = new System.Drawing.Point(113, 66);
            this.storeProductNameCobx.Name = "storeProductNameCobx";
            this.storeProductNameCobx.Size = new System.Drawing.Size(198, 28);
            this.storeProductNameCobx.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "入库数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓库分区:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "入库仓库:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "入库产品:";
            // 
            // FormProductInStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.storeInfoGroup);
            this.Controls.Add(this.productInStoresDGV);
            this.Controls.Add(this.productInStoreRecordBtn);
            this.Controls.Add(this.productInStoreListBtn);
            this.Controls.Add(this.typeNameLabel);
            this.Controls.Add(this.uPanel1);
            this.Name = "FormProductInStore";
            this.Text = "产品入库页面";
            this.Load += new System.EventHandler(this.LoadProductInStorePage);
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInStoresDGV)).EndInit();
            this.storeInfoGroup.ResumeLayout(false);
            this.storeInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Panel panel1;
        private UControls.UCircleButton flashBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeNameLabel;
        private System.Windows.Forms.Button productInStoreListBtn;
        private System.Windows.Forms.Button productInStoreRecordBtn;
        private System.Windows.Forms.DataGridView productInStoresDGV;
        private System.Windows.Forms.GroupBox storeInfoGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sRegionNameCobx;
        private System.Windows.Forms.ComboBox inStoreNameCobx;
        private System.Windows.Forms.ComboBox storeProductNameCobx;
        private System.Windows.Forms.NumericUpDown inStoreCountUpDown;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button inStoreBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProStoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
    }
}