using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenineMassas.View
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastroProdutoCliente a = new cadastroProdutoCliente();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
