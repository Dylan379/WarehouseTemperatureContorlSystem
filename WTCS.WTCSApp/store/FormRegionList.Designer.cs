
namespace WTCS.WTCSApp.store
{
    partial class FormRegionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeRegionListDGV = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowLowestTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHighestTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanel2 = new WTCS.WTCSApp.UControls.UPanel();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.storeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isDeletedCheck = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.keyWordsInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creatBtn = new System.Windows.Forms.Button();
            this.uPanel1 = new WTCS.WTCSApp.UControls.UPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flashBtn = new WTCS.WTCSApp.UControls.UCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeRegionListDGV)).BeginInit();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeRegionListDGV
            // 
            this.storeRegionListDGV.AllowUserToAddRows = false;
            this.storeRegionListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeRegionListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeRegionListDGV.BackgroundColor = System.Drawing.Color.White;
            this.storeRegionListDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.storeRegionListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeRegionListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.storeRegionListDGV.ColumnHeadersHeight = 35;
            this.storeRegionListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.storeRegionListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.SRegionId,
            this.SRegionName,
            this.StoreName,
            this.SRegionNo,
            this.SRTemperature,
            this.AllowLowestTemperature,
            this.AllowHighestTemperature,
            this.TemperState,
            this.colEdit,
            this.colDelete,
            this.colRecover,
            this.colRemove});
            this.storeRegionListDGV.EnableHeadersVisualStyles = false;
            this.storeRegionListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeRegionListDGV.Location = new System.Drawing.Point(0, 122);
            this.storeRegionListDGV.Name = "storeRegionListDGV";
            this.storeRegionListDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeRegionListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.storeRegionListDGV.RowHeadersWidth = 51;
            this.storeRegionListDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.storeRegionListDGV.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.storeRegionListDGV.RowTemplate.Height = 27;
            this.storeRegionListDGV.Size = new System.Drawing.Size(995, 460);
            this.storeRegionListDGV.TabIndex = 3;
            this.storeRegionListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 80F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // SRegionId
            // 
            this.SRegionId.DataPropertyName = "SRegionId";
            this.SRegionId.FillWeight = 80F;
            this.SRegionId.HeaderText = "编号";
            this.SRegionId.MinimumWidth = 6;
            this.SRegionId.Name = "SRegionId";
            this.SRegionId.ReadOnly = true;
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.HeaderText = "分区名";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            this.SRegionName.ReadOnly = true;
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
            // SRegionNo
            // 
            this.SRegionNo.DataPropertyName = "SRegionNo";
            this.SRegionNo.FillWeight = 80F;
            this.SRegionNo.HeaderText = "编码";
            this.SRegionNo.MinimumWidth = 6;
            this.SRegionNo.Name = "SRegionNo";
            this.SRegionNo.ReadOnly = true;
            // 
            // SRTemperature
            // 
            this.SRTemperature.DataPropertyName = "SRTemperature";
            this.SRTemperature.FillWeight = 180F;
            this.SRTemperature.HeaderText = "室内温度";
            this.SRTemperature.MinimumWidth = 6;
            this.SRTemperature.Name = "SRTemperature";
            this.SRTemperature.ReadOnly = true;
            // 
            // AllowLowestTemperature
            // 
            this.AllowLowestTemperature.DataPropertyName = "AllowLowestTemperature";
            this.AllowLowestTemperature.HeaderText = "低温";
            this.AllowLowestTemperature.MinimumWidth = 6;
            this.AllowLowestTemperature.Name = "AllowLowestTemperature";
            this.AllowLowestTemperature.ReadOnly = true;
            // 
            // AllowHighestTemperature
            // 
            this.AllowHighestTemperature.DataPropertyName = "AllowHighestTemperature";
            this.AllowHighestTemperature.HeaderText = "高温";
            this.AllowHighestTemperature.MinimumWidth = 6;
            this.AllowHighestTemperature.Name = "AllowHighestTemperature";
            this.AllowHighestTemperature.ReadOnly = true;
            // 
            // TemperState
            // 
            this.TemperState.DataPropertyName = "TemperState";
            this.TemperState.HeaderText = "状态";
            this.TemperState.MinimumWidth = 6;
            this.TemperState.Name = "TemperState";
            this.TemperState.ReadOnly = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle9;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.TrackVisitedState = false;
            // 
            // colDelete
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDelete.HeaderText = "删除";
            this.colDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.TrackVisitedState = false;
            // 
            // colRecover
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.NullValue = "恢复";
            this.colRecover.DefaultCellStyle = dataGridViewCellStyle11;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.MinimumWidth = 6;
            this.colRecover.Name = "colRecover";
            this.colRecover.TrackVisitedState = false;
            // 
            // colRemove
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.NullValue = "移除";
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle12;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.TrackVisitedState = false;
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
            this.uPanel2.Controls.Add(this.stateComboBox);
            this.uPanel2.Controls.Add(this.storeComboBox);
            this.uPanel2.Controls.Add(this.label4);
            this.uPanel2.Controls.Add(this.label3);
            this.uPanel2.Controls.Add(this.isDeletedCheck);
            this.uPanel2.Controls.Add(this.deleteBtn);
            this.uPanel2.Controls.Add(this.searchBtn);
            this.uPanel2.Controls.Add(this.keyWordsInput);
            this.uPanel2.Controls.Add(this.label2);
            this.uPanel2.Controls.Add(this.creatBtn);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(4, 58);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(992, 58);
            this.uPanel2.TabIndex = 2;
            // 
            // stateComboBox
            // 
            this.stateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stateComboBox.ForeColor = System.Drawing.Color.White;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(367, 15);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 28);
            this.stateComboBox.TabIndex = 9;
            // 
            // storeComboBox
            // 
            this.storeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.storeComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.storeComboBox.ForeColor = System.Drawing.Color.White;
            this.storeComboBox.FormattingEnabled = true;
            this.storeComboBox.Location = new System.Drawing.Point(141, 15);
            this.storeComboBox.Name = "storeComboBox";
            this.storeComboBox.Size = new System.Drawing.Size(150, 28);
            this.storeComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label4.Location = new System.Drawing.Point(307, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(91, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "仓库：";
            // 
            // isDeletedCheck
            // 
            this.isDeletedCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isDeletedCheck.AutoSize = true;
            this.isDeletedCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isDeletedCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isDeletedCheck.ForeColor = System.Drawing.Color.Chocolate;
            this.isDeletedCheck.Location = new System.Drawing.Point(908, 16);
            this.isDeletedCheck.Name = "isDeletedCheck";
            this.isDeletedCheck.Size = new System.Drawing.Size(72, 24);
            this.isDeletedCheck.TabIndex = 5;
            this.isDeletedCheck.Text = "已删除";
            this.isDeletedCheck.UseVisualStyleBackColor = true;
            this.isDeletedCheck.CheckedChanged += new System.EventHandler(this.ChangedDeleteCheckValue);
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
            this.deleteBtn.Location = new System.Drawing.Point(814, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Radius = 15;
            this.deleteBtn.Size = new System.Drawing.Size(65, 35);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(739, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(55, 30);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "查询";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.ClickSearchBtn);
            // 
            // keyWordsInput
            // 
            this.keyWordsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.keyWordsInput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyWordsInput.ForeColor = System.Drawing.Color.White;
            this.keyWordsInput.Location = new System.Drawing.Point(583, 15);
            this.keyWordsInput.Name = "keyWordsInput";
            this.keyWordsInput.Size = new System.Drawing.Size(144, 27);
            this.keyWordsInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(517, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "关键词：";
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
            this.uPanel1.TabIndex = 1;
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
            this.flashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flashBtn.AnotherBackGroundColor = System.Drawing.Color.MidnightBlue;
            this.flashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.flashBtn.BackGroundColor = System.Drawing.Color.CornflowerBlue;
            this.flashBtn.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.flashBtn.BorderWidth = 0;
            this.flashBtn.FlatAppearance.BorderSize = 0;
            this.flashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flashBtn.ForeColor = System.Drawing.Color.White;
            this.flashBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.flashBtn.Location = new System.Drawing.Point(738, 12);
            this.flashBtn.Name = "flashBtn";
            this.flashBtn.Radius = 10;
            this.flashBtn.Size = new System.Drawing.Size(60, 33);
            this.flashBtn.TabIndex = 1;
            this.flashBtn.Text = "刷新";
            this.flashBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库分区管理页面";
            // 
            // FormRegionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.storeRegionListDGV);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FormRegionList";
            this.ShowIcon = false;
            this.Text = "仓库分区管理页面";
            this.Load += new System.EventHandler(this.LoadRegionListPage);
            ((System.ComponentModel.ISupportInitialize)(this.storeRegionListDGV)).EndInit();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Panel panel1;
        private UControls.UCircleButton flashBtn;
        private System.Windows.Forms.Label label1;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.CheckBox isDeletedCheck;
        private UControls.UCircleButton deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox keyWordsInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.DataGridView storeRegionListDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox storeComboBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowLowestTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowHighestTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperState;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}