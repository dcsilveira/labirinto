namespace Labirinto.Interface
{
    partial class FrmCriarLabirinto
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
            this.pnlDesenho = new System.Windows.Forms.Panel();
            this.cmbTamanhos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDesenho
            // 
            this.pnlDesenho.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDesenho.Location = new System.Drawing.Point(13, 13);
            this.pnlDesenho.Name = "pnlDesenho";
            this.pnlDesenho.Size = new System.Drawing.Size(260, 260);
            this.pnlDesenho.TabIndex = 0;
            // 
            // cmbTamanhos
            // 
            this.cmbTamanhos.FormattingEnabled = true;
            this.cmbTamanhos.Location = new System.Drawing.Point(396, 10);
            this.cmbTamanhos.Name = "cmbTamanhos";
            this.cmbTamanhos.Size = new System.Drawing.Size(37, 21);
            this.cmbTamanhos.TabIndex = 1;
            this.cmbTamanhos.SelectedIndexChanged += new System.EventHandler(this.cmbTamanhos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamanho do Labirinto";
            // 
            // FrmCriarLabirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTamanhos);
            this.Controls.Add(this.pnlDesenho);
            this.Name = "FrmCriarLabirinto";
            this.Text = "Criação Labirinto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesenho;
        private System.Windows.Forms.ComboBox cmbTamanhos;
        private System.Windows.Forms.Label label1;
    }
}