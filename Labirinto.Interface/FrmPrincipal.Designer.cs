namespace Labirinto.Interface
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnResolver = new System.Windows.Forms.Button();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.chkMapa3 = new System.Windows.Forms.CheckBox();
            this.chkMapa2 = new System.Windows.Forms.CheckBox();
            this.chkMapa1 = new System.Windows.Forms.CheckBox();
            this.pbxLabirinto3 = new System.Windows.Forms.PictureBox();
            this.pbxLabirinto2 = new System.Windows.Forms.PictureBox();
            this.pbxLabirinto1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imlListaImagens = new System.Windows.Forms.ImageList(this.components);
            this.lsvSolucoes = new System.Windows.Forms.ListView();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblSolucoes = new System.Windows.Forms.Label();
            this.pbxMelhorSolucao = new System.Windows.Forms.PictureBox();
            this.pbxPiorSolucao = new System.Windows.Forms.PictureBox();
            this.lblMelhorSolucao = new System.Windows.Forms.Label();
            this.lblPiorSolucao = new System.Windows.Forms.Label();
            this.pnlSolucoes = new System.Windows.Forms.Panel();
            this.chkResolucaoRapida = new System.Windows.Forms.CheckBox();
            this.pnlOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMelhorSolucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPiorSolucao)).BeginInit();
            this.pnlSolucoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(496, 64);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(111, 76);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.Controls.Add(this.chkMapa3);
            this.pnlOpcoes.Controls.Add(this.chkMapa2);
            this.pnlOpcoes.Controls.Add(this.chkMapa1);
            this.pnlOpcoes.Controls.Add(this.pbxLabirinto3);
            this.pnlOpcoes.Controls.Add(this.pbxLabirinto2);
            this.pnlOpcoes.Controls.Add(this.pbxLabirinto1);
            this.pnlOpcoes.Location = new System.Drawing.Point(12, 61);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(326, 132);
            this.pnlOpcoes.TabIndex = 1;
            // 
            // chkMapa3
            // 
            this.chkMapa3.AutoCheck = false;
            this.chkMapa3.AutoSize = true;
            this.chkMapa3.Location = new System.Drawing.Point(235, 109);
            this.chkMapa3.Name = "chkMapa3";
            this.chkMapa3.Size = new System.Drawing.Size(62, 17);
            this.chkMapa3.TabIndex = 13;
            this.chkMapa3.Text = "Mapa 3";
            this.chkMapa3.UseVisualStyleBackColor = true;
            this.chkMapa3.Click += new System.EventHandler(this.chkMapa3_Click);
            // 
            // chkMapa2
            // 
            this.chkMapa2.AutoCheck = false;
            this.chkMapa2.AutoSize = true;
            this.chkMapa2.Location = new System.Drawing.Point(129, 109);
            this.chkMapa2.Name = "chkMapa2";
            this.chkMapa2.Size = new System.Drawing.Size(62, 17);
            this.chkMapa2.TabIndex = 12;
            this.chkMapa2.Text = "Mapa 2";
            this.chkMapa2.UseVisualStyleBackColor = true;
            this.chkMapa2.Click += new System.EventHandler(this.chkMapa2_Click);
            // 
            // chkMapa1
            // 
            this.chkMapa1.AutoCheck = false;
            this.chkMapa1.AutoSize = true;
            this.chkMapa1.Location = new System.Drawing.Point(22, 109);
            this.chkMapa1.Name = "chkMapa1";
            this.chkMapa1.Size = new System.Drawing.Size(62, 17);
            this.chkMapa1.TabIndex = 11;
            this.chkMapa1.Text = "Mapa 1";
            this.chkMapa1.UseVisualStyleBackColor = true;
            this.chkMapa1.Click += new System.EventHandler(this.chkMapa1_Click);
            // 
            // pbxLabirinto3
            // 
            this.pbxLabirinto3.Location = new System.Drawing.Point(216, 3);
            this.pbxLabirinto3.Name = "pbxLabirinto3";
            this.pbxLabirinto3.Size = new System.Drawing.Size(100, 100);
            this.pbxLabirinto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLabirinto3.TabIndex = 10;
            this.pbxLabirinto3.TabStop = false;
            // 
            // pbxLabirinto2
            // 
            this.pbxLabirinto2.Location = new System.Drawing.Point(110, 3);
            this.pbxLabirinto2.Name = "pbxLabirinto2";
            this.pbxLabirinto2.Size = new System.Drawing.Size(100, 100);
            this.pbxLabirinto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLabirinto2.TabIndex = 9;
            this.pbxLabirinto2.TabStop = false;
            // 
            // pbxLabirinto1
            // 
            this.pbxLabirinto1.Location = new System.Drawing.Point(4, 3);
            this.pbxLabirinto1.Name = "pbxLabirinto1";
            this.pbxLabirinto1.Size = new System.Drawing.Size(100, 100);
            this.pbxLabirinto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLabirinto1.TabIndex = 8;
            this.pbxLabirinto1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "mstMenu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // imlListaImagens
            // 
            this.imlListaImagens.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlListaImagens.ImageSize = new System.Drawing.Size(64, 64);
            this.imlListaImagens.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lsvSolucoes
            // 
            this.lsvSolucoes.Location = new System.Drawing.Point(7, 42);
            this.lsvSolucoes.Name = "lsvSolucoes";
            this.lsvSolucoes.Size = new System.Drawing.Size(261, 161);
            this.lsvSolucoes.TabIndex = 4;
            this.lsvSolucoes.UseCompatibleStateImageBehavior = false;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(13, 42);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(105, 13);
            this.lblEscolha.TabIndex = 5;
            this.lblEscolha.Text = "Escolha um Labirinto";
            // 
            // lblSolucoes
            // 
            this.lblSolucoes.AutoSize = true;
            this.lblSolucoes.Location = new System.Drawing.Point(8, 26);
            this.lblSolucoes.Name = "lblSolucoes";
            this.lblSolucoes.Size = new System.Drawing.Size(51, 13);
            this.lblSolucoes.TabIndex = 6;
            this.lblSolucoes.Text = "Soluções";
            // 
            // pbxMelhorSolucao
            // 
            this.pbxMelhorSolucao.Location = new System.Drawing.Point(275, 42);
            this.pbxMelhorSolucao.Name = "pbxMelhorSolucao";
            this.pbxMelhorSolucao.Size = new System.Drawing.Size(160, 160);
            this.pbxMelhorSolucao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMelhorSolucao.TabIndex = 7;
            this.pbxMelhorSolucao.TabStop = false;
            // 
            // pbxPiorSolucao
            // 
            this.pbxPiorSolucao.Location = new System.Drawing.Point(441, 42);
            this.pbxPiorSolucao.Name = "pbxPiorSolucao";
            this.pbxPiorSolucao.Size = new System.Drawing.Size(160, 160);
            this.pbxPiorSolucao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPiorSolucao.TabIndex = 8;
            this.pbxPiorSolucao.TabStop = false;
            // 
            // lblMelhorSolucao
            // 
            this.lblMelhorSolucao.AutoSize = true;
            this.lblMelhorSolucao.Location = new System.Drawing.Point(272, 26);
            this.lblMelhorSolucao.Name = "lblMelhorSolucao";
            this.lblMelhorSolucao.Size = new System.Drawing.Size(81, 13);
            this.lblMelhorSolucao.TabIndex = 9;
            this.lblMelhorSolucao.Text = "Melhor Solução";
            // 
            // lblPiorSolucao
            // 
            this.lblPiorSolucao.AutoSize = true;
            this.lblPiorSolucao.Location = new System.Drawing.Point(438, 26);
            this.lblPiorSolucao.Name = "lblPiorSolucao";
            this.lblPiorSolucao.Size = new System.Drawing.Size(67, 13);
            this.lblPiorSolucao.TabIndex = 10;
            this.lblPiorSolucao.Text = "Pior Solução";
            // 
            // pnlSolucoes
            // 
            this.pnlSolucoes.Controls.Add(this.lblSolucoes);
            this.pnlSolucoes.Controls.Add(this.lblPiorSolucao);
            this.pnlSolucoes.Controls.Add(this.lsvSolucoes);
            this.pnlSolucoes.Controls.Add(this.lblMelhorSolucao);
            this.pnlSolucoes.Controls.Add(this.pbxMelhorSolucao);
            this.pnlSolucoes.Controls.Add(this.pbxPiorSolucao);
            this.pnlSolucoes.Location = new System.Drawing.Point(0, 199);
            this.pnlSolucoes.Name = "pnlSolucoes";
            this.pnlSolucoes.Size = new System.Drawing.Size(619, 212);
            this.pnlSolucoes.TabIndex = 11;
            // 
            // chkResolucaoRapida
            // 
            this.chkResolucaoRapida.AutoSize = true;
            this.chkResolucaoRapida.Location = new System.Drawing.Point(496, 147);
            this.chkResolucaoRapida.Name = "chkResolucaoRapida";
            this.chkResolucaoRapida.Size = new System.Drawing.Size(114, 17);
            this.chkResolucaoRapida.TabIndex = 12;
            this.chkResolucaoRapida.Text = "Resolução Rápida";
            this.chkResolucaoRapida.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 414);
            this.Controls.Add(this.chkResolucaoRapida);
            this.Controls.Add(this.pnlSolucoes);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.pnlOpcoes);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Solucionador de Labirintos";
            this.pnlOpcoes.ResumeLayout(false);
            this.pnlOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLabirinto1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMelhorSolucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPiorSolucao)).EndInit();
            this.pnlSolucoes.ResumeLayout(false);
            this.pnlSolucoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.CheckBox chkMapa3;
        private System.Windows.Forms.CheckBox chkMapa2;
        private System.Windows.Forms.CheckBox chkMapa1;
        private System.Windows.Forms.PictureBox pbxLabirinto3;
        private System.Windows.Forms.PictureBox pbxLabirinto2;
        private System.Windows.Forms.PictureBox pbxLabirinto1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ImageList imlListaImagens;
        private System.Windows.Forms.ListView lsvSolucoes;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblSolucoes;
        private System.Windows.Forms.PictureBox pbxMelhorSolucao;
        private System.Windows.Forms.PictureBox pbxPiorSolucao;
        private System.Windows.Forms.Label lblMelhorSolucao;
        private System.Windows.Forms.Label lblPiorSolucao;
        private System.Windows.Forms.Panel pnlSolucoes;
        private System.Windows.Forms.CheckBox chkResolucaoRapida;
    }
}

