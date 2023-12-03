
namespace WTCS.WTCSApp.UControls
{
    partial class UIndicatorLight
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
            this.uCircleLight = new WTCS.WTCSApp.UControls.UCircle();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uCircleLight
            // 
            this.uCircleLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uCircleLight.Location = new System.Drawing.Point(13, 12);
            this.uCircleLight.Name = "uCircleLight";
            this.uCircleLight.Size = new System.Drawing.Size(16, 16);
            this.uCircleLight.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.lblState.Location = new System.Drawing.Point(36, 8);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(50, 25);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "低温";
            // 
            // UIndicatorLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.uCircleLight);
            this.Name = "UIndicatorLight";
            this.Size = new System.Drawing.Size(90, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCircle uCircleLight;
        private System.Windows.Forms.Label lblState;
    }
}
