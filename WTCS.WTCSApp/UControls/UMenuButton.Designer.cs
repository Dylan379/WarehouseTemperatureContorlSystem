
namespace WTCS.WTCSApp.UControls
{
    partial class UMenuButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lableBtnText = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lableBtnText
            // 
            this.lableBtnText.AutoSize = true;
            this.lableBtnText.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableBtnText.ForeColor = System.Drawing.Color.White;
            this.lableBtnText.Location = new System.Drawing.Point(79, 14);
            this.lableBtnText.Name = "lableBtnText";
            this.lableBtnText.Size = new System.Drawing.Size(65, 33);
            this.lableBtnText.TabIndex = 1;
            this.lableBtnText.Text = "文本";
            this.lableBtnText.Click += new System.EventHandler(this.lableBtnText_Click_1);
            this.lableBtnText.MouseEnter += new System.EventHandler(this.lableBtnText_MouseEnter);
            // 
            // pbImg
            // 
            this.pbImg.Image = global::WTCS.WTCSApp.Properties.Resources.R_C;
            this.pbImg.Location = new System.Drawing.Point(23, 5);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(50, 50);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click_1);
            this.pbImg.MouseEnter += new System.EventHandler(this.pbImg_MouseEnter);
            // 
            // UMenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.Controls.Add(this.lableBtnText);
            this.Controls.Add(this.pbImg);
            this.Name = "UMenuButton";
            this.Size = new System.Drawing.Size(257, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lableBtnText;
    }
}
