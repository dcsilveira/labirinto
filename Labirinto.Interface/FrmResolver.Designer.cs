namespace Labirinto.Interface
{
    partial class FrmResolver
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
            this.pbxLabirinto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLabirinto
            // 
            this.pbxLabirinto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbxLabirinto.Location = new System.Drawing.Point(13, 13);
            this.pbxLabirinto.Name = "pbxLabirinto";
            this.pbxLabirinto.Size = new System.Drawing.Size(260, 260);
            this.pbxLabirinto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLabirinto.TabIndex = 0;
            this.pbxLabirinto.TabStop = false;
            this.pbxLabirinto.UseWaitCursor = true;
            // 
            // FrmResolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.pbxLabirinto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resolvendo...";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResolver_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLabirinto;
    }
}