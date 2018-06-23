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
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin1  a = new TelaLogin1();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void telaInicial_Load(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.Hide();
                TelaLogin1 a = new TelaLogin1();
                a.Closed += (s, args) => this.Close();
                a.Show();
            }
        }
    }
}
