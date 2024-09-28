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
using System.Threading;

namespace GerenciadorDeEstoque.Apresentação.Pedido
{
    public partial class Pedidos : Form
    {

        public Pedidos()
        {
            InitializeComponent();
            QuantidadeDisponivel();
            comboBoxPlataformaVirtual.Enabled = false;
            ComboBoxPlataformaVendaOnline();
        }

        // Variáveis para conexão com o banco de dados
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();
        Controle controle = new Controle();

        private void ComboBoxPlataformaVendaOnline() // Criando as opções da Combo Box para o Marketplace
        {
            comboBoxPlataformaVirtual.Items.Add("Mercado Livre");
            comboBoxPlataformaVirtual.Items.Add("OLX");
            comboBoxPlataformaVirtual.Items.Add("Shopee");
            comboBoxPlataformaVirtual.Items.Add("Enjoei");
            comboBoxPlataformaVirtual.Items.Add("Amazon");
            comboBoxPlataformaVirtual.Items.Add("Craigslist");
            comboBoxPlataformaVirtual.Items.Add("Submarino");
            comboBoxPlataformaVirtual.Items.Add("Skina");
            comboBoxPlataformaVirtual.Items.Add("Elo7");
            comboBoxPlataformaVirtual.Items.Add("Extra");
            comboBoxPlataformaVirtual.Items.Add("Casas Bahia");
            comboBoxPlataformaVirtual.Items.Add("Ponto Frio");
            comboBoxPlataformaVirtual.Items.Add("Tanlup");
            comboBoxPlataformaVirtual.Items.Add("Holipet");
            comboBoxPlataformaVirtual.Items.Add("Hotmart");
            comboBoxPlataformaVirtual.Items.Add("Netshoes");
            comboBoxPlataformaVirtual.Items.Add("Magazine Luiza");
            comboBoxPlataformaVirtual.Items.Add("Facebook");
            comboBoxPlataformaVirtual.Items.Add("E-commerce");

        }

        private void ComboBoxFormaPgmt() // Método que adicionar os itens da Combo Box método de pagamento
        {
            comboBox_FormaPgt.Items.Add("Dinheiro");
            comboBox_FormaPgt.Items.Add("Cartão");
            comboBox_FormaPgt.Items.Add("Boleto");
        }

        private void Pedidos_Load(object sender, EventArgs e) // Método que carrega o nome dos Clientes e o nome dos produtos
        {
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet1.clientefisico'. Você pode movê-la ou removê-la conforme necessário.
            this.clientefisicoTableAdapter.Fill(this.estoqueDataSet1.clientefisico);
            // TODO: esta linha de código carrega dados na tabela 'nomeClientes.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.nomeClientes.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.estoqueDataSet.produtos);
        }

        private void QuantidadeDisponivel()
        {
            // Conectar com o BD
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            // Abrindo a conexão
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string nome = Convert.ToString(comboBox_Produto.SelectedValue);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select quantidade from produtos where nome = '{nome}';", con);
            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();
            da.Fill(ds, "estoque");

            con.Close();

            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txb_QntEstoque.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        // Método para exibir o valor total do pedido (preço do produto * quantidade do pedido)
        private void ValorTotal()
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string nome = Convert.ToString(comboBox_Produto.SelectedValue);
            // String quantidade para ver qual a quantidade do pedido
            string quantidade = txbQnt.Text;

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select preco * {quantidade} from produtos where nome = '{nome}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbValorTotal.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        private void ValorProduto() // Método para exibir o valor da unidade do produto selecionado
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            con.Open();

            // Criei a string nome, e estou convertendo o nome do produto selecionado pelo usuário na ComboBox para String
            string produto = Convert.ToString(comboBox_Produto.SelectedValue);

            // Variável do tipo SqlCOmmand para executar os cmds do BD
            SqlCommand cmdComboBox = new SqlCommand($"select preco from produtos where nome = '{produto}';", con);

            da = new SqlDataAdapter(cmdComboBox);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txbValorPorUnidade.Text = dt.Rows[i].ItemArray[0].ToString();
            }
        }

        // Método para aplicar desconto no valorTotal do pedido
        private void PorcentagemValorTotalProduto()
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            con.Open();

            // As strings abaixos pegam o valor da quantidade do item e do valor, para chegar no total
            // A desconto pega o desconto informado pelo usuário em %, ex. 10%
            // Total calcula o valor total do produto (qnt * valor)
            double qnt = Convert.ToInt32(txbQnt.Text);
            double valor = Convert.ToInt32(txbValorPorUnidade.Text);
            double desconto = Convert.ToInt32(txbDesconto.Text);
            double total = qnt * valor;

            // Aqui aplicamos o desconto no valor
            double valorcomdesconto = total - (total * (desconto / 100));

            // Passamos o valor com desconto para a textbox do valor total, porem, convertendo para string novamente
            txbValorTotal.Text = Convert.ToString(valorcomdesconto);
        }

        private void comboBox_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantidadeDisponivel();
            ValorProduto();
        }

        // Métodos chamados quando o usuário escreve a quantidade do pedido
        private void txbQnt_TextChanged(object sender, EventArgs e)
        {
            // Se o campo quantidade não estiver em branco
            if (!txbQnt.Text.Equals(""))
            {
                // É exibido o valor total
                ValorTotal();
            }

        }

        // Botão para aplicar o desconto no valor total do pedido
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // Método para aplicar o desconto no valor total do pedido
            PorcentagemValorTotalProduto();
        }

        // Botão cadastrar Pedido
        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (comboBoxVenda.Text != "Selecione")
            {
                if (comboBox_FormaPgt.Text != "Selecione")
                {
                    string mensagem = controle.CadastrarPedidoCliente(comboBox_Produto.Text, txb_QntEstoque.Text, txbQnt.Text, txbValorPorUnidade.Text, comboBox_Cliente.Text, comboBoxVenda.Text, comboBox_FormaPgt.Text, txbDesconto.Text, txbValorTotal.Text, comboBoxPlataformaVirtual.Text);
                    if (controle.verificacao)
                    {
                        MessageBox.Show("Cadastrado com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro ao realizar o cadastro!");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o meio do pagamento!");
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo da venda!");
            }
        }

        private void comboBoxVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVenda.SelectedIndex == 1)
            {
                comboBoxPlataformaVirtual.Enabled = true;
            }

            if(comboBoxVenda.SelectedIndex == 0)
            {
                comboBoxPlataformaVirtual.Text = "";
                comboBoxPlataformaVirtual.Enabled = false;

            }
        }
    }
}
