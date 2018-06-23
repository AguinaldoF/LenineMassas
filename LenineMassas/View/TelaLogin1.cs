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
    public partial class TelaLogin1 : Form
    {
        public TelaLogin1()
        {
            InitializeComponent();

            txtUsuario.Text = "Usuário";
            txtSenha.Text = "Senha";
        }

        // Metodo que informa o preenchimento de todos os campos

        private void txtUsuario_Enter(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                MessageBox.Show("É necessário preencher todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Metodo que realiza Login ao clicar no btnLogin

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("É necessário preencher todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtUsuario.Text == "aguinaldo" && txtSenha.Text == "1234")
            {

                this.Hide();
                telaMenu a = new telaMenu();
                a.Closed += (s, args) => this.Close();
                a.Show();
            }

            else if (txtUsuario.Text != "aguinaldo" || txtSenha.Text != "drhouse9982")
            {
                MessageBox.Show("Usuário ou Senha incorretos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Metodo que realiza Login ao pressionar enter

        private void txtSenha_Enter(object sender, KeyPressEventArgs e)
        {

           if ((Keys)e.KeyChar == Keys.Enter)
            {
                if(txtUsuario.Text == null || txtSenha.Text == null)
                {
                    MessageBox.Show("É necessário preencher todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtUsuario.Text == "aguinaldo" && txtSenha.Text == "1234")
                {

                    this.Hide();
                    telaMenu a = new telaMenu();
                    a.Closed += (s, args) => this.Close();
                    a.Show();
                }

                else if (txtUsuario.Text != "aguinaldo" || txtSenha.Text != "drhouse9982")
                {
                    MessageBox.Show("Usuário ou Senha incorretos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        // Metodo que finaliza o programa ao clicar em btnCancelar

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
