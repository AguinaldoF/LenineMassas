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
    public partial class cadastroProdutoCliente : Form
    {
        public cadastroProdutoCliente()
        {
            InitializeComponent();
        }

        private void btnClientes1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente a = new CadastroCliente();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void btnProdutos1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
            telaMenu a = new telaMenu();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
