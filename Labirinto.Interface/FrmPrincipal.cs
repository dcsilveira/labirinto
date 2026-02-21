using System.Data;
using Labirinto.RegraNegocio;

namespace Labirinto.Interface
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            PreencherOpcoesMapa();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            LabirintoSolver labirinto = new LabirintoSolver();

            // Verifico qual mapa será solucionado
            if (chkMapa1.Checked || chkMapa2.Checked || chkMapa3.Checked)
            {
                if (chkMapa1.Checked)
                    labirinto = new LabirintoSolver(8, Maps.Labirinto01, chkResolucaoRapida.Checked);
                if (chkMapa2.Checked)
                    labirinto = new LabirintoSolver(10, Maps.Labirinto02, chkResolucaoRapida.Checked);
                if (chkMapa3.Checked)
                    labirinto = new LabirintoSolver(20, Maps.Labirinto03, chkResolucaoRapida.Checked);
                
                FrmResolver frmResolver = new FrmResolver(labirinto);
                frmResolver.ShowDialog();

                if (frmResolver.DialogResult == DialogResult.OK)
                {
                    // Preencho a lista de soluções
                    imlListaImagens.Images.Clear();
                    imlListaImagens.Images.AddRange(frmResolver.Solucoes.Keys.ToArray());

                    lsvSolucoes.Items.Clear();
                    lsvSolucoes.LargeImageList = imlListaImagens;

                    for(int i = 0; i < imlListaImagens.Images.Count; i++)
                    {
                        lsvSolucoes.Items.Add(frmResolver.Solucoes.ElementAt(i).Value.ToString(), i);
                    }

                    KeyValuePair<Bitmap, int> solucao = new KeyValuePair<Bitmap, int>();

                    // Melhor Solução
                    solucao = frmResolver.Solucoes.OrderBy(p => p.Value).ElementAt(0);
                    pbxMelhorSolucao.Image = solucao.Key;
                    lblMelhorSolucao.Text = string.Format("Melhor Solução ({0} passos)", solucao.Value);

                    // Pior Solução
                    solucao = frmResolver.Solucoes.OrderByDescending(p => p.Value).ElementAt(0);
                    pbxPiorSolucao.Image =  solucao.Key;
                    lblPiorSolucao.Text = string.Format("Pior Solução ({0} passos)", solucao.Value);
                }
            }
            else
            {
                MessageBox.Show("Selecione um mapa!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreencherOpcoesMapa()
        {
            LabirintoSolver labirinto = new LabirintoSolver(8, Maps.Labirinto01, false);
            pbxLabirinto1.Image = labirinto.MapaBitmap;

            labirinto = new LabirintoSolver(10, Maps.Labirinto02, false);
            pbxLabirinto2.Image = labirinto.MapaBitmap;

            labirinto = new LabirintoSolver(20, Maps.Labirinto03, false);
            pbxLabirinto3.Image = labirinto.MapaBitmap;
        }

        private void chkMapa1_Click(object sender, EventArgs e)
        {
            chkMapa1.Checked = true;
            chkMapa2.Checked = false;
            chkMapa3.Checked = false;            
        }

        private void chkMapa2_Click(object sender, EventArgs e)
        {
            chkMapa1.Checked = false;
            chkMapa2.Checked = true;
            chkMapa3.Checked = false;
        }

        private void chkMapa3_Click(object sender, EventArgs e)
        {
            chkMapa1.Checked = false;
            chkMapa2.Checked = false;
            chkMapa3.Checked = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }
    }
}
