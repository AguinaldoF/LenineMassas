using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LenineMassas.View
{
    public partial class PesquisarCliente : Form
    {
        private SqlDataAdapter AdapterPesquisar = new SqlDataAdapter();
        private BindingSource bindingSourcePesquisar = new BindingSource();

        public PesquisarCliente()
        {
            InitializeComponent();
        }

        // Metodo que pesquisa os clientes no banco de dados

        private void btnPesquisar1_Click(object sender, EventArgs e)
        {            

            // String de conexão com o banco de dados

            var connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aguin\Desktop\Projetos\LenineMassas\LenineMassas\LenineMassas\LenineMassas\Model\BdLenineMassas.mdf;Integrated Security=True";

            var sql = new StringBuilder();

            using (var conn = new SqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand()
                    {
                        CommandText = sql.ToString(),
                        Connection = conn
                    };
            
                    // Comando de Select na table CadastroCliente

                    sql.Append("select * from cadastroCliente");
                    cmd.CommandText = sql.ToString();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    bindingSourcePesquisar.DataSource = dt;
                    dataGridView1.DataSource = bindingSourcePesquisar;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + " Erro ao cadastrar informações no sistema", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        // Metodo para retornar a TelaMenu

        private void btnVoltar_Pesquisa_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaMenu a = new telaMenu();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
