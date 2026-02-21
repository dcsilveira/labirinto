using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labirinto.Interface
{
    public partial class FrmCriarLabirinto : Form
    {
        public FrmCriarLabirinto()
        {
            InitializeComponent();

        }

        private void IniciarTamanhos()
        {
            cmbTamanhos.Items.Add(8);
            cmbTamanhos.Items.Add(10);
            cmbTamanhos.Items.Add(16);
            cmbTamanhos.Items.Add(20);

            cmbTamanhos.SelectedIndex = 0;

        }

        private void cmbTamanhos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
