using GerenciadorDeEstoque.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }
        // Variáveis para conexão com o banco de dados
        Controle controle = new Controle();

        // ADICIONAR QUANTIDADE DO PRODUTO
        private void btn_AddQnt_Click(object sender, EventArgs e)
        {
            if (!txb_idProduto.Text.Equals(""))
            {
                if (!txb_Quantidade.Text.Equals(""))
                {
                    string mensagem = controle.EditarProdutos(txb_idProduto.Text, txb_Quantidade.Text);
                    MessageBox.Show("Quantidade adicionada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Por favor, informe a quantidade do produto!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe a ID do produto!");
            }
        }

        // REMOVER QUANTIDADE DO PRODUTO
        private void btn_rmvQnt_Click(object sender, EventArgs e)
        {
            if (!txb_idProduto.Text.Equals(""))
            {
                if (!txb_Quantidade.Text.Equals(""))
                {
                    string mensagem = controle.EditarProdutosRemvQnt(txb_idProduto.Text, txb_Quantidade.Text);
                    MessageBox.Show("Quantidade removida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Por favor, informe a quantidade do produto!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe a ID do produto!");
            }
        }

        // BOTÃO REMOVER PRODUTO DO ESTOQUE
        private void btn_deleteProduto_Click(object sender, EventArgs e)
        {
            if (!txb_idProduto.Text.Equals(""))
            {
                string mensagem = controle.RemoverProductEstoque(txb_idProduto.Text);
                MessageBox.Show("Produto removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, informe a ID do produto!");
            }
        }
    }
}
