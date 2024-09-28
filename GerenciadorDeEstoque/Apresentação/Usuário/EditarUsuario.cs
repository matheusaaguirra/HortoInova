using GerenciadorDeEstoque.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação.Usuário
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        // Variáveis para conexão com o banco de dados
        Controle controle = new Controle();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();
        string nomeantigo;

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet3.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.estoqueDataSet3.funcionario);

        }

        
        public void btnEditar_Click(object sender, EventArgs e) // Botão para editar o usuário
        {
            if (!comboBox_Produto.Text.Equals(""))
            {
                if (!txbEmail.Text.Equals(""))
                {
                    if (!txbCelular.Text.Equals("")){
                        
                        string mensagem = controle.EditarUsuarios(comboBox_Produto.Text, txbEmail.Text, txbCelular.Text, nomeantigo);
                        MessageBox.Show("Usuário editado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, não deixe o campo CELULAR em branco!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, não deixe o campo E-MAIL em branco!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, não deixe o campo NOME em branco!");
            }           
        }

        private void EmailUsuario() // Método para exibir na list view o e-mail do usuário
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            con.Open();

            string nome = Convert.ToString(comboBox_Produto.SelectedValue); // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String

            
            SqlCommand cmdComboBox = new SqlCommand($"select email from funcionario where nome = '{nome}';", con); // Variável do tipo SqlCOmmand para executar os cmds do BD

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbEmail.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void CelularUsuario() // Método para exibir na list view o e-mail do usuário
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            con.Open();

            string nome = Convert.ToString(comboBox_Produto.SelectedValue); // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            SqlCommand cmdComboBox = new SqlCommand($"select celular from funcionario where nome = '{nome}';", con); // Variável do tipo SqlCOmmand para executar os cmds do BD
            
            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbCelular.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        public void comboBox_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeantigo = comboBox_Produto.Text;
            EmailUsuario();
            CelularUsuario();
        }
    }
}
