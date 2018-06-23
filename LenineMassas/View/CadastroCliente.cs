using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LenineMassas.View
{
    public partial class CadastroCliente : Form
    {

       // private SqlConnection conn;
       // private SqlCommand cmd;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        // Metodo que preenche o campo Nome

        private void txtNome(object sender, EventArgs e)
        {
            TextBox txtNome = sender as TextBox;

            if (txtNome != null)
            {
                string TextNome = txtNomeCadastro.Text;
            }
        }

        // Metodo que preenche o campo Endereço

        private void txtEndereco(object sender, EventArgs e)
        {

            TextBox txtEndereco = sender as TextBox;
            string TextEndereco = txtEnderecoCadastro.Text;

        }

        // Metodo que preenche o campo CEP
        
        private void txtCep(object sender, EventArgs e)
        {

            TextBox txtCep = sender as TextBox;
            string TextCep = txtCepCadastro.Text;

        }

        // Metodo que preenche o campo Número

        private void txtNumero(object sender, EventArgs e)
        {

            TextBox txtNumero = sender as TextBox;
            string TextNumero = txtNumeroCadastro.Text;

        }

        // Metodo que preenche o campo Telefone

        private void txtTelefone(object sender, EventArgs e)
        {

            TextBox txtTelefone = sender as TextBox;
            string TextNumero = txtTelefoneCadastro.Text;

        }

        // Metodo que preenche o campo Celular

        private void txtCelular(object sender, EventArgs e)
        {

            TextBox txtCelular = sender as TextBox;
            string TextNumero = txtCelularCadastro.Text;

        }

        // Metodo que finaliza a janela de CadastroCliente

        private void btnCancelaCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            cadastroProdutoCliente a = new cadastroProdutoCliente();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        // Metodo que ira inserir as informações no banco de dados

        private void btnIncluirCadastro_Click(object sender, EventArgs e)
        {

            // String de conexão com o banco de dados

            var connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aguin\Desktop\Projetos\LenineMassas\LenineMassas\LenineMassas\LenineMassas\Model\BdLenineMassas.mdf;Integrated Security=True";

            var sql = new StringBuilder();

            using (var conn = new SqlConnection(connectionstring))
            {
                try
                {

                    conn.Open();
                    sql.Append("INSERT INTO CadastroCliente (nome, endereco, telefone, celular, cep, numero) VALUES ('" + txtNomeCadastro.Text + "','" + txtEnderecoCadastro.Text + "','" + txtTelefoneCadastro.Text + "','" + txtCelularCadastro.Text + "','" + txtCepCadastro.Text + "','" + txtNumeroCadastro.Text + "')");
                    var cmd = new SqlCommand()
                    {
                        CommandText = sql.ToString(),
                        Connection = conn
                    };

                    cmd.ExecuteReader();

                    //cmd.Parameters.Add(new SqlParameter("@nome", txtNomeCadastro.Text));
                    //cmd.Parameters.Add(new SqlParameter("@endereco", txtEnderecoCadastro.Text));
                    //cmd.Parameters.Add(new SqlParameter("@telefone", txtTelefoneCadastro.Text));
                    //cmd.Parameters.Add(new SqlParameter("@celular", txtCelularCadastro.Text));
                    //cmd.Parameters.Add(new SqlParameter("@cep", txtCepCadastro.Text));
                    //cmd.Parameters.Add(new SqlParameter("@numero", txtNumeroCadastro.Text));
                    //cmd.ExecuteReader();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + " Erro ao cadastrar informações no sistema", " Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Cliente salvo com sucesso.", "Aviso", MessageBoxButtons.OK);

                    conn.Close();                                
            }
        }

        // Metodo que abri janela PesquisarCliente

        private void btnPesquisarCliente(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarCliente b = new PesquisarCliente();
            b.Closed += (s, args) => this.Close();
            b.Show();
        }
    }
}

// Comando para dar select

//sql.Append("select * from cadastroCliente");
//cmd.CommandText = sql.ToString();
//DataTable dt = new DataTable();
//dt.Load(cmd.ExecuteReader());