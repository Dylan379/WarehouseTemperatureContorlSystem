
namespace WTCS.WTCSApp.storeTemper
{
    partial class FormSetRegionTemperature
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.targetTemperUpdown = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closePageBtn = new System.Windows.Forms.Button();
            this.setTypeLabel = new System.Windows.Forms.Label();
            this.changeTemperCheckList = new System.Windows.Forms.CheckedListBox();
            this.msgListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.targetTemperUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "调整方式：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标室温：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "调整方法：";
            // 
            // targetTemperUpdown
            // 
            this.targetTemperUpdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.targetTemperUpdown.ForeColor = System.Drawing.Color.White;
            this.targetTemperUpdown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.targetTemperUpdown.Location = new System.Drawing.Point(125, 75);
            this.targetTemperUpdown.Name = "targetTemperUpdown";
            this.targetTemperUpdown.Size = new System.Drawing.Size(120, 25);
            this.targetTemperUpdown.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(44, 283);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(63, 41);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "确定";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // closePageBtn
            // 
            this.closePageBtn.BackColor = System.Drawing.Color.DarkGray;
            this.closePageBtn.FlatAppearance.BorderSize = 0;
            this.closePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closePageBtn.ForeColor = System.Drawing.Color.White;
            this.closePageBtn.Location = new System.Drawing.Point(154, 283);
            this.closePageBtn.Name = "closePageBtn";
            this.closePageBtn.Size = new System.Drawing.Size(64, 41);
            this.closePageBtn.TabIndex = 8;
            this.closePageBtn.Text = "取消";
            this.closePageBtn.UseVisualStyleBackColor = false;
            // 
            // setTypeLabel
            // 
            this.setTypeLabel.AutoSize = true;
            this.setTypeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.setTypeLabel.Location = new System.Drawing.Point(120, 29);
            this.setTypeLabel.Name = "setTypeLabel";
            this.setTypeLabel.Size = new System.Drawing.Size(50, 25);
            this.setTypeLabel.TabIndex = 9;
            this.setTypeLabel.Text = "升温";
            // 
            // changeTemperCheckList
            // 
            this.changeTemperCheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.changeTemperCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeTemperCheckList.Font = new System.Drawing.Font("STZhongsong", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeTemperCheckList.ForeColor = System.Drawing.Color.White;
            this.changeTemperCheckList.FormattingEnabled = true;
            this.changeTemperCheckList.Items.AddRange(new object[] {
            "上调空调温度",
            "打开暖气",
            "关闭窗户"});
            this.changeTemperCheckList.Location = new System.Drawing.Point(44, 157);
            this.changeTemperCheckList.Name = "changeTemperCheckList";
            this.changeTemperCheckList.Size = new System.Drawing.Size(201, 104);
            this.changeTemperCheckList.TabIndex = 10;
            // 
            // msgListBox
            // 
            this.msgListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.msgListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgListBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msgListBox.ForeColor = System.Drawing.Color.White;
            this.msgListBox.FormattingEnabled = true;
            this.msgListBox.ItemHeight = 20;
            this.msgListBox.Location = new System.Drawing.Point(313, 29);
            this.msgListBox.Name = "msgListBox";
            this.msgListBox.Size = new System.Drawing.Size(347, 302);
            this.msgListBox.TabIndex = 11;
            // 
            // FormSetRegionTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.msgListBox);
            this.Controls.Add(this.changeTemperCheckList);
            this.Controls.Add(this.setTypeLabel);
            this.Controls.Add(this.closePageBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.targetTemperUpdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSetRegionTemperature";
            this.ShowIcon = false;
            this.Text = "仓库分区温度调整";
            ((System.ComponentModel.ISupportInitialize)(this.targetTemperUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown targetTemperUpdown;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closePageBtn;
        private System.Windows.Forms.Label setTypeLabel;
        private System.Windows.Forms.CheckedListBox changeTemperCheckList;
        private System.Windows.Forms.ListBox msgListBox;
    }
}