using Labirinto.RegraNegocio;

namespace Labirinto.Interface
{
    public partial class FrmResolver : Form
    {
        private LabirintoSolver labirinto;

        public Dictionary<Bitmap, int> Solucoes
        {
            get
            {
                return labirinto.Solucoes;
            }
        }

        public FrmResolver()
        {
            InitializeComponent();
        }

        public FrmResolver(LabirintoSolver labirinto)
        {
            InitializeComponent();
            this.labirinto = labirinto;
            Resolver();
        }

        private void Resolver()
        {
            Thread thResolver = new Thread(new ThreadStart(labirinto.Resolver));
            Thread thRefresh = new Thread(new ThreadStart(RefreshImagem));
 
            thRefresh.Start();
            thResolver.Start();
        }

        private void RefreshImagem()
        {
            if (!labirinto.Acabou)
            {
                pbxLabirinto.Image = labirinto.MapaBitmap;
                Thread.Sleep(50);
                RefreshImagem();
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void FrmResolver_FormClosing(object sender, FormClosingEventArgs e)
        {
            labirinto.Acabou = true;
        }
    }
}
