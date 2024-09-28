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

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class AddProduct : Form
    {

        public AddProduct()
        {
            InitializeComponent();
        }

        // Variáveis para conexão com o banco de dados
        Controle controle = new Controle();

        public void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (!txb_NomeProduto.Text.Equals(""))
            {
                if (!txb_Cor.Text.Equals(""))
                {
                    if (!txb_Preco.Text.Equals(""))
                    {
                        if (!txb_Quantidade.Text.Equals(""))
                        {
                            if (!txbPrecoVenda.Text.Equals(""))
                            {
                                if (!txbTamanho.Text.Equals(""))
                                {
                                    if (!txbCustoMarketPlace.Text.Equals("")){
                                        string precoVenda = Convert.ToString(txbPrecoVenda.Text);
                                        string mensagem = controle.CadastrarProdutos(txb_NomeProduto.Text, txb_Cor.Text, txb_Preco.Text, txb_Quantidade.Text, txbTamanho.Text, txbPrecoVenda.Text, txbCustoMarketPlace.Text);
                                        MessageBox.Show("Produto cadastrado com sucesso!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, informe o custo do MarketPlace! Caso não possua, coloque: 0");
                                    }                                    
                                }
                                else
                                {
                                    MessageBox.Show("Por favor, selecione o tamanho! Caso não possua, coloque: ÚNICO");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, adicione o preço de venda do produto!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, adicione a quantidade do produto!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, adicione o preço de custo do produto!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, adicione a cor do produto!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, adicione o nome do produto!");
            }
        }
    }
}
