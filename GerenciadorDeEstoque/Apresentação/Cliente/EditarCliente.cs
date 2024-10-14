using GerenciadorDeEstoque.DAO;
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

namespace GerenciadorDeEstoque.Apresentação.Cliente
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.EditarCliente_Load);
        }
        public bool check = false;
        public string mensagem = "";

        // Variáveis para conexão com banco de dados
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();
        // Conectar com o BD
        SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        SqlCommand comando = new SqlCommand();
        Conexao conect = new Conexao();

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarClientes(); // Método para carregar dados dos clientes
                if (!string.IsNullOrEmpty(txbString.Text))
                {
                    // Carregar informações nos campos do formulário com base no ID
                    Nome();
                    DataNascimento();
                    Telefone();
                    Celular();
                    RG();
                    CPF();
                    Endereco();
                    Email();
                    Observacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as informações: " + ex.Message);
            }
        }

        private void CarregarClientes()
        {
            DataTable dataTable = new DataTable();
            string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=estoque; Integrated Security=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM clientefisico";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        // Aqui a consulta é executada e os resultados são preenchidos no DataTable
                        adapter.Fill(dataTable);
                    }
                }

                // A DataTable agora contém os dados retornados do banco de dados
               // TelaLogado.DataSource = dataTable; // Vincula os dados ao DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }


        private void Nome()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select nome from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];


            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbNome.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void DataNascimento()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select datanascimento from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbDataNascimento.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void Telefone()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select telefone from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbTelefone.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void Celular()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select celular from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbCelular.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void RG()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select rg from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbRG.Text = dt.Rows[i].ItemArray[0].ToString();
            }

        }

        private void CPF()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select cpf from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbCPF.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void Endereco()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select endereco from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbEndereco.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void Email()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select email from clientefisico where idclientefisico = '{id}';", con);

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

        private void Observacoes()
        {
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string id = Convert.ToString(txbString.Text);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select observacoes from clientefisico where idclientefisico = '{id}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbObservacoes.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void NotificacaoM(string elemento)
        {
            MessageBox.Show($"Por favor, preencha o {elemento}");
        }

        private void NotificacaoF(string elemento)
        {
            MessageBox.Show($"Por favor, preencha a {elemento}");
        }

        // EDITAR DADOS DO CLIENTE
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (!txbString.Text.Equals(""))
            {
                if (!txbNome.Text.Equals(""))
                {
                    if (!txbTelefone.Text.Equals(""))
                    {
                        if (!txbCelular.Text.Equals(""))
                        {
                            if (!txbEndereco.Text.Equals(""))
                            {
                                if (!txbEmail.Text.Equals(""))
                                {
                                    Controle controle = new Controle();
                                    string mensagem = controle.EditarClientes(txbString.Text, txbNome.Text, txbDataNascimento.Text, txbTelefone.Text, txbCelular.Text, txbRG.Text, txbCPF.Text, txbEndereco.Text, txbEmail.Text, txbObservacoes.Text);

                                    MessageBox.Show("Cliente editado!");
                                    RefreshCliente();
                                }
                                else
                                {
                                    NotificacaoM("e-mail");
                                }

                            }
                            else
                            {
                                NotificacaoM("endereço");
                            }
                        }
                        else
                        {
                            NotificacaoM("celular");
                        }

                    }
                    else
                    {
                        NotificacaoM("telefone");
                    }
                }
                else
                {
                    NotificacaoM("nome");
                }
            }
            else
            {
                NotificacaoM("ID");
            }
        }

        // Refresh cliente
        public string RefreshCliente()
        {
            // Limpar os campos
            txbNome.Clear();
            txbDataNascimento.Clear();
            txbTelefone.Clear();
            txbCelular.Clear();
            txbRG.Clear();
            txbCPF.Clear();
            txbEmail.Clear();
            txbEndereco.Clear();
            txbObservacoes.Clear();

            comando.CommandText = "select * from clientefisico;";

            check = false;
            try
            {
                comando.Connection = conect.Conectar();
                comando.ExecuteNonQuery();
                conect.Desconectar();
                this.mensagem = "Cliente removido com sucesso!";

                check = true;
            }

            catch (SqlException)
            {
                this.mensagem = "Erro na remoção do cliente!";
            }

            return mensagem;
        }

        // Passando os dados para os campos quando o usuário seleciona o ID
        private void txbString_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Nome();
            DataNascimento();
            Telefone();
            Celular();
            RG();
            CPF();
            Endereco();
            Email();
            Observacoes();
        }

        // Botão remover cliente
        private void btnRemoverProdutos_Click_1(object sender, EventArgs e)
        {
            if (!txbString.Text.Equals(""))
            {
                Controle controle = new Controle();
                string mensagem = controle.RemoverClientes(txbString.Text);
                MessageBox.Show("Cliente removido!");
            }
            else
            {
                NotificacaoM("ID");
            }

            // método para atualizar a lista de cliente
            RefreshCliente();
        }

        private void txbDataNascimento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbDataNascimento_Enter(object sender, EventArgs e)
        {
            if(txbDataNascimento.Text == "YYYY-MM-DD"){
                txbDataNascimento.Text = "";
                txbDataNascimento.ForeColor = Color.Black;
            }
        }

        private void txbDataNascimento_Leave(object sender, EventArgs e)
        {
            if (txbDataNascimento.Text == "")
            {
                txbDataNascimento.Text = "YYYY-MM-DD";
                txbDataNascimento.ForeColor = Color.LightGreen;
            }
        }
    }
}