using GerenciadorDeEstoque.DAO;
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
using GerenciadorDeEstoque.Apresentação.Cliente;
using GerenciadorDeEstoque.Apresentação.Pedido;
using GerenciadorDeEstoque.Apresentação.Usuário;
using System.Windows.Forms.DataVisualization.Charting;

namespace GerenciadorDeEstoque.Apresentação
{
    // NOME DO BANCO DE DADOS: ESTOQUE
    public partial class TelaLogado : Form
    {
        SqlCommand cmdListView = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        // variáveis necessárias para pegar os dados do BD e atribuir na list view
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        public TelaLogado()
        {
            InitializeComponent();   
            CriandoGraficoVendas(); // Método para criar o gráfico de vendas

            // Métodos pra esconder as telas da form TelaLogado
            EsconderBotoesEstoque();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderGroupBoxUsuario();
            EsconderAlaytics();
            EsconderSuporteTecnico();

            // Métodos para gerar as colunas das List Views das forms escondidas
            GerarColunasClientes();
            GerarColunas();
            GerarColunasUsuarios();
            AdicionarItemListViewPedidos();
            GerarColunaListViewAnaliseVendas();
        }

        public TelaLogado(AddProduct formProduct) // Métodos para abrir a form TelaLogado na aba Produtos
        {
            AdicionarItemListView();
            EsconderGroupBoxUsuario();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderAlaytics();
            EsconderSuporteTecnico();
            ExibirEstoque();
            RefreshList();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e) // Botão sair do menu superior (arquivo --> sair)
        {
            Application.Exit();
        }

        #region Estoque
        private void EsconderBotoesEstoque() // Esconder interface gráfica do estoque
        {
            picture_AddProd.Hide();
            picture_Edit.Hide();
            label_AddProd.Hide();
            label_EditEstoq.Hide();
            listView_Cliente.Hide();
            gpb_Estoque.Hide();
        }

        private void ExibirEstoque() // Exibir interface gráfica do estoque
        {
            gpb_Estoque.Show();
            listView_Cliente.Show();
            picture_AddProd.Show();
            picture_Edit.Show();
            label_AddProd.Show();
            label_EditEstoq.Show();
        }

        private void GerarColunas() // Gerar colunas da List View Produtos
        {
            listView_Cliente.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Nome", 220).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Tipo", 100).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Categoria", 80).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Quantidade", 80).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Preço venda", 80).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Preço custo", 80).TextAlign = HorizontalAlignment.Center;
            listView_Cliente.Columns.Add("Lucro", 80).TextAlign = HorizontalAlignment.Center;
        }

        public void AdicionarItemListView() // Método para passar os dados do BD para a List View
        {
            ExibirEstoque();
            con.Open();
            cmdListView = new SqlCommand("select idproduto, nomeproduto, tipo, categoria, quantidade, preco, precovenda, customarketplace from produtos;", con);
            da = new SqlDataAdapter(cmdListView);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Cliente.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
            }
        }
                
        private void pictureBox1_Click(object sender, EventArgs e) // Botão com imagem (ESTOQUE)
        {
            AdicionarItemListView();
            EsconderGroupBoxUsuario();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderAlaytics();
            EsconderSuporteTecnico();
            ExibirEstoque();
            RefreshList();
        }
        
        private void picture_AddProd_Click(object sender, EventArgs e) // Imagem do "Criar novo produto"
        {
            AddProduct telaProduto = new AddProduct();
            telaProduto.ShowDialog();
            RefreshList();
        }
                
        public void RefreshList() // Método para atualizar a ListView Produtos
        {
            listView_Cliente.Items.Clear(); // Limpar o campo da List View
            con.Open();
            cmdListView = new SqlCommand("select idproduto, nomeproduto, tipo, categoria, quantidade, preco, precovenda, customarketplace from produtos", con);
            da = new SqlDataAdapter(cmdListView);
            ds = new DataSet();
            da.Fill(ds, "estoque");

            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Cliente.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Cliente.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
            }
        }
        
        private void picture_Edit_Click(object sender, EventArgs e) // Botão Editar Produtos do estoque
        {
            EditarProduto abrirfrmEditarProduto = new EditarProduto();
            abrirfrmEditarProduto.ShowDialog();
            RefreshList();
        }
        #endregion

        #region Clientes
        private void MostrarBotoesCliente() // Mostrar interface gráfica do cliente
        {
            gpb_Cliente.Show();
        }

        private void EsconderBotoesCliente() // Esconder interface gráfica do cliente
        {
            gpb_Cliente.Hide();
        }

        private void GerarColunasClientes() // Gerar colunas da List View Clientes
        {
            listView_Clientes.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Nome", 250).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Data de nascimento", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Telefone", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Celular", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("RG", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("CPF / CNPJ", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Endereço", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("E-mail", 100).TextAlign = HorizontalAlignment.Center;
            listView_Clientes.Columns.Add("Observações", 100).TextAlign = HorizontalAlignment.Center;
        }

        private void pictureBoxEditarCliente_Click(object sender, EventArgs e) // Método para abrir a tela Editar Cliente
        {
            EditarCliente abrirfrmEditarCliente = new EditarCliente();
            abrirfrmEditarCliente.ShowDialog();
            RefreshListClient(); // Atualizar a list view de clientes
        }

        private void btnImg_Cliente_Click(object sender, EventArgs e) // Botão imagem cliente
        {
            EsconderSuporteTecnico();
            EsconderBotoesEstoque();
            EsconderGroupBoxUsuario();
            EsconderAlaytics();
            MostrarBotoesCliente();
            EsconderTelaPedidos();
            AdicionarItemListViewCliente();
            RefreshListClient();
        }
                
        private void btn_NovoCliente_Click(object sender, EventArgs e) // Botão cadastrar novo cliente
        {
            AddClient abrirfrmAddCliente = new AddClient();
            abrirfrmAddCliente.ShowDialog();
            RefreshListClient(); // Método para atualizar a list view de clientes
        }
                
        private void pictureBox2_Click(object sender, EventArgs e) // Botão para cadastrar novo cliente jurídico
        {
            AddClienteCNPJ abrirfrmClienteCNPJ = new AddClienteCNPJ();
            abrirfrmClienteCNPJ.ShowDialog();
            RefreshListClient();
        }
        
        public void AdicionarItemListViewCliente() // Método para passar os dados do BD para a List View (clientes)
        {
            con.Open();
            cmdListView = new SqlCommand("select * from clientefisico", con);
            da = new SqlDataAdapter(cmdListView);
            ds = new DataSet();
            da.Fill(ds, "estoque");

            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Clientes.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
            }
        }

        private void RefreshListClient() // Método para atualizar a ListView Cliente
        {            
            listView_Clientes.Items.Clear(); // Limpar o campo da List View
            con.Open();
            cmdListView = new SqlCommand("select * from clientefisico", con);
            da = new SqlDataAdapter(cmdListView);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Clientes.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listView_Clientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
            }
        }
        #endregion

        #region Pedidos
        private void EsconderTelaPedidos() // Método para esconder a tela de pedidos
        {
            groupBox_pedidos.Hide();
        }
                
        private void MostrarTelaPedidos() // Método para mostrar a tela de pedidos
        {
            groupBox_pedidos.Show();
        }
                
        private void btn_pedido_Click(object sender, EventArgs e) // Botão com imagem dos pedidos
        {
            EsconderBotoesEstoque();
            EsconderGroupBoxUsuario();
            EsconderBotoesCliente();
            EsconderAlaytics();
            EsconderSuporteTecnico();
            MostrarTelaPedidos();
        }
                
        private void btn_criarPedido_Click(object sender, EventArgs e) // Botão para fazer um novo pedido, joga para a tela "Pedidos"
        {
            Pedidos formPedidos = new Pedidos();
            formPedidos.ShowDialog();
            RefreshPedidos(); // Atualizar lista pedidos quando fecha a form
        }
                
        public void GerarColunasPedidos() // Gerar as colunas da list view pedidos
        {
            listView_Pedido.Columns.Add("Data", 80).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("ID", 35).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Estado", 70).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Produto", 100).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Comprador", 180).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Venda", 60).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Marketplace", 80).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Forma pagamento", 90).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Valor unitário", 80).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Quantidade", 80).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Desconto (%)", 75).TextAlign = HorizontalAlignment.Center;
            listView_Pedido.Columns.Add("Valor total", 70).TextAlign = HorizontalAlignment.Center;
        }
                
        public void AdicionarItemListViewPedidos() // Adicionar os itens na LIST VIEW de PEDIDOS
        {
            GerarColunasPedidos();
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"select dataAddPedido, idpedido, estado, produto, comprador, plataforma, marketplace, formapgt, valorunitario, quantidade, desconto, valortotal from pedidos_encerrados;", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[11].ToString());
            }
            
        }

        public void RefreshPedidos() // Refresh na LIST VIEW de PEDIDOS
        {
            listView_Pedido.Items.Clear();
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"select dataAddPedido, idpedido, estado, produto, quantidade, valorunitario, comprador, plataforma, marketplace, formapgt, desconto, valortotal from pedidos_encerrados;", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[11].ToString());
            }
        }
        
        private void pictureAlterarEstadoPedido_Click(object sender, EventArgs e) // Abrir Form Encerrar Pedido
        {
            EncerrarPedido abrirfrmEncerrarPedido = new EncerrarPedido();
            abrirfrmEncerrarPedido.ShowDialog();
            RefreshPedidos();
        }

        private void MetodoExibirPedidosporEstado() // Método para exibir somente pedidos PENDENTES, PAGOS ou CANCELADOS
        {
            // Se TODAS AS BOX tiverem desmarcadas
            if (checkBoxPendentes.Checked == false && checkBoxPago.Checked == false && checkBoxCancelados.Checked == false)
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados;", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }

            if (checkBoxPendentes.Checked == true) // Se marcar somente a BOX PENDENTES
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Pendente%';", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
                        
            if (checkBoxPago.Checked == true) // Se marcar somente a BOX PAGO
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Concluído%';", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }

            if (checkBoxCancelados.Checked == true) // Se marcar somente a BOX CANCELADO
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Cancelado%';", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
                        
            if (checkBoxPago.Checked == true && checkBoxPendentes.Checked == true) // Se marcar somente a BOX PAGO e a PENDENTE
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados  order by estado desc;", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
                        
            if (checkBoxPago.Checked == true && checkBoxCancelados.Checked == true) // Se marcar somente a BOX PAGO e CANCELADO
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Concluído%' or estado LIKE '%Cancelado%' order by estado desc;", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }

            if (checkBoxPendentes.Checked == true && checkBoxCancelados.Checked == true) // Se marcar somente a BOX PENDENTE e CANCELADO
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Pendente%' or estado LIKE '%Cancelado%' order by estado desc;", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }

            if (checkBoxPago.Checked == true && checkBoxPendentes.Checked == true && checkBoxCancelados.Checked == true) // Se marcar somente a BOX PAGO, PENDENTE e CANCELADO
            {
                listView_Pedido.Items.Clear();
                con.Open();
                SqlCommand cmdAddPedido = new SqlCommand($"select * from pedidos_encerrados where estado LIKE '%Concluído%' or estado LIKE '%Pendente%' or estado LIKE '%Cancelado%' order by estado desc;", con);

                da = new SqlDataAdapter(cmdAddPedido);
                ds = new DataSet();
                DataTable dt = new DataTable();

                da.Fill(ds, "estoque");
                con.Close();
                dt = ds.Tables["estoque"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listView_Pedido.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listView_Pedido.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
        }

        private void checkBoxPendentes_CheckedChanged(object sender, EventArgs e) // Check box pendentes
        {
            MetodoExibirPedidosporEstado();
        }

        private void checkBoxPago_CheckedChanged(object sender, EventArgs e) // Check box pagos
        {
            MetodoExibirPedidosporEstado();
        }

        private void checkBoxCancelados_CheckedChanged(object sender, EventArgs e) // Check box cancelados
        {
            //MetodoExibirPedidosporEstado();
        }
        #endregion

        #region Usuário
        private void EsconderGroupBoxUsuario() // Esconder o Group Box Usuário
        {
            gpBoxUsuario.Hide();
        }

        private void MostrarGroupBoxUsuario() // Mostrar Group Box Usuário
        {
            gpBoxUsuario.Show();
        }

        public void GerarColunasUsuarios()
        {
            listViewUsuario.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            listViewUsuario.Columns.Add("Nome", 250).TextAlign = HorizontalAlignment.Center;
            listViewUsuario.Columns.Add("E-mail", 350).TextAlign = HorizontalAlignment.Center;
            listViewUsuario.Columns.Add("Celular", 150).TextAlign = HorizontalAlignment.Center;
        }

        public void AdicionarItensListaUsuario()
        {
            listViewUsuario.Items.Clear();
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"select idfuncionario, nome, email, celular from funcionario;", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewUsuario.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Botão para atualizar a lista de clientes
        {
            RefreshListClient();
        }

        private void picBoxUsuarios_Click(object sender, EventArgs e) // Botão usuário, quando clica exibe a tela
        {
            EsconderBotoesEstoque();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderAlaytics();
            EsconderSuporteTecnico();
            MostrarGroupBoxUsuario();
            AdicionarItensListaUsuario();
        }

        private void pictureBox6_Click(object sender, EventArgs e) // Botão com imagem editar usuário
        {
            EditarUsuario abrirfrmEditarUsuario = new EditarUsuario();
            abrirfrmEditarUsuario.ShowDialog();
            RefreshUsuario();
        }

        private void RefreshUsuario() // Refresh para atualizar a list view de Usuário
        {
            listViewUsuario.Items.Clear();
            con.Open();
            cmdListView = new SqlCommand("select idfuncionario, nome, email, celular from funcionario;", con);
            da = new SqlDataAdapter(cmdListView);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewUsuario.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewUsuario.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }
        #endregion

        #region Analise de vendas
        private void EsconderAlaytics() // método para esconder a tela de Analise
        {
            gpBoxAnalise.Hide();
        }

        private void imgSuporte_Click(object sender, EventArgs e) // Botão com imagem da Análise
        {
            EsconderBotoesEstoque();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderGroupBoxUsuario();
            EsconderSuporteTecnico();
            MostrarGroupBoxUsuario();
            MostrarAnalytics();
            AdicionarItensColunaAnaliseDeVendas();
            GerarGraficoVendas();
        }

        private void MostrarAnalytics() // método para mostrar a tela de Analise
        {
            gpBoxAnalise.Show();
        }

        public void CriandoGraficoVendas() // Método para criar o gráfico de vendas (informações da formatação)
        {
            Title title = new Title(); // Instanciando var do tipo title
            title.Font = new Font("Arial", 14, FontStyle.Bold); // Bold = negrito
            title.ForeColor = Color.Brown;
            title.Text = "Vendas mensais";

            // Título do eixo X e Y; Eixo X = meses; Eixo Y = Valores
            // Eixo X
            graficoVendas.ChartAreas["ChartArea1"].AxisX.Title = "Ano de 2021"; // Deixe sempre o "ChartArea1", não mude se não da erro!!!
            graficoVendas.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            // Eixo Y
            graficoVendas.ChartAreas["ChartArea1"].AxisY.Title = "Faturamento (R$)";
            graficoVendas.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            
            graficoVendas.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; // Removendo as "grades" verticais que aparecem de fundo do eixo X
            graficoVendas.Titles.Add(title); // Adicionando o título e a formatação no gráfico de vendas
        }

        private void GerarGraficoVendas()
        {
            graficoVendas.Series.Clear(); // Limpando o gráfico para não multiplicar os dados quando o usuário acessa várias vezes a sub tela
            graficoVendas.Series.Add("Vendas"); // Criando uma série chamada Vendas. Série = conjunto de barras do gráfico (jan, fev, mar, abr, ...)
            graficoVendas.Series["Vendas"].LegendText = "Faturamento"; // Legenda sobre o gráfico
            graficoVendas.Series["Vendas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Tipo do gráfico é o "Column" se fosse o pizza seria outro nome
            graficoVendas.Series["Vendas"].BorderWidth = 2; // Largura da barra do gráfico, no caso, defini como 4.

            con.Open(); 
            SqlCommand cmdAddPedido = new SqlCommand($"select sum(total) from analisevendas where dataPedido BETWEEN '01/01/2021' AND '31/01/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/02/2021' AND '28/02/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/03/2021' AND '31/03/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/04/2021' AND '30/04/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/05/2021' AND '30/05/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/06/2021' AND '30/06/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/07/2021' AND '31/07/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/08/2021' AND '31/08/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/09/2021' AND '30/09/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/10/2021' AND '31/10/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/11/2021' AND '30/11/2021' UNION ALL select sum(total) from analisevendas where dataPedido BETWEEN '01/12/2021' AND '31/12/2021';", con);
            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            // Gerando o gráfico de meses, janeiro a dezembro
            // No primeiro vai o X (meses), e depois os valores que estão no banco de dados
            graficoVendas.Series["Vendas"].Points.AddXY("Jan", dt.Rows[0].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Fev", dt.Rows[1].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Mar", dt.Rows[2].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Abr", dt.Rows[3].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Mai", dt.Rows[4].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Jun", dt.Rows[5].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Jul", dt.Rows[6].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Ago", dt.Rows[7].ItemArray[0].ToString());
            graficoVendas.Series["Vendas"].Points.AddXY("Set", dt.Rows[8].ItemArray[0].ToString());
        }

        public void GerarColunaListViewAnaliseVendas() // Método para gerar as colunas da List View de Análise de vendas
        {
            listViewAnaliseVendas.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            listViewAnaliseVendas.Columns.Add("Data", 200).TextAlign = HorizontalAlignment.Center;
            listViewAnaliseVendas.Columns.Add("Produto", 350).TextAlign = HorizontalAlignment.Center;
            listViewAnaliseVendas.Columns.Add("Quantidade", 150).TextAlign = HorizontalAlignment.Center;
            listViewAnaliseVendas.Columns.Add("Total", 150).TextAlign = HorizontalAlignment.Center;
        }

        public void AdicionarItensColunaAnaliseDeVendas()
        {
            listViewAnaliseVendas.Items.Clear();
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"select idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where estado = 'pago';", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnJaneiro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  janeiro
        {
            listViewAnaliseVendas.Items.Clear();
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/01/2021', 103); set @DataFinal= convert (datetime, '31/01/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnFevereiro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  fevereiro
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/02/2021', 103); set @DataFinal= convert (datetime, '28/02/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnMarco_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  março
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/03/2021', 103); set @DataFinal= convert (datetime, '31/03/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnAbril_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  abril
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/04/2021', 103); set @DataFinal= convert (datetime, '30/04/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnMaio_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  maio
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/05/2021', 103); set @DataFinal= convert (datetime, '31/05/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }
                
        private void btnJunho_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de  junho
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/06/2021', 103); set @DataFinal= convert (datetime, '30/06/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnJulho_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de julho
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/07/2021', 103); set @DataFinal= convert (datetime, '31/07/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnAgosto_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de agosto
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/08/2021', 103); set @DataFinal= convert (datetime, '31/08/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnSetembro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de setembro
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/09/2021', 103); set @DataFinal= convert (datetime, '30/09/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void btnOutubro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de outubro
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/10/2021', 103); set @DataFinal= convert (datetime, '31/10/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "estoque");

            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }
                
        private void btnNovembro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de novembro
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/11/2021', 103); set @DataFinal= convert (datetime, '30/11/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }
        
        private void btnDezembro_Click(object sender, EventArgs e) // Botão para fazer o filtro das datas na análise de vendas do mês de dezembro
        {
            listViewAnaliseVendas.Items.Clear();            
            con.Open();
            SqlCommand cmdAddPedido = new SqlCommand($"declare @DataInicial datetime, @DataFinal datetime; set @DataInicial= convert (datetime, '01/12/2021', 103); set @DataFinal= convert (datetime, '31/12/2021', 103); SELECT idpedido, dataAddPedido, produto, quantidade, valortotal from pedidos_encerrados where convert(datetime, dataAddPedido, 121) between @DataInicial and @DataFinal AND estado = 'pago'; ", con);

            da = new SqlDataAdapter(cmdAddPedido);
            ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewAnaliseVendas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewAnaliseVendas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }
        #endregion

        #region Suporte
        private void EsconderSuporteTecnico() // Método para esconder o Group Box do Suporte técnico
        {
            gpBoxSuporte.Hide();
        }
                
        private void MostrarSuporteTecnico() // Método para exibir o Group Box do suporte técnico
        {
            gpBoxSuporte.Show();
        }

        private void pictureBoxSuporte_Click(object sender, EventArgs e)
        {
            EsconderBotoesEstoque();
            EsconderBotoesCliente();
            EsconderTelaPedidos();
            EsconderAlaytics();
            EsconderGroupBoxUsuario();
            MostrarSuporteTecnico();
        }
        #endregion

        private void listViewAnaliseVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}