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

namespace GerenciadorDeEstoque.Apresentação.Pedido
{
    public partial class EncerrarPedido : Form
    {
        public EncerrarPedido()
        {
            InitializeComponent();
        }

        Controle controle = new Controle(); // Instanciando a classe Controle

        private void CheckarCheckedBox()
        {
            if (checkBox_Pago.Checked == true)
            {
                checkBox_Pago.Checked = false;
            }

            if (checkBox_Pago.Checked == true)
            {
                checkBox_Pago.Checked = false;
            }
        }

        // Botão para ALTERAR o ESTADO do PEDIDO
        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_Id.Text != "")
            {
                if (checkBox_Pago.Checked != false || checkBox_Pago.Checked != false)
                {
                    string mensagem = controle.CadastrarPedidoEstado(txb_Id.Text, checkBox_Pago.Checked, checkBox_Pago.Checked);

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
                    MessageBox.Show("Por favor, selecione um estado para o pedido!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe a ID do pedido!");
            }
        }

        // Botão de remoção dos pedidos
        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            if (txb_Id.Text != "")
            {
                string mensagem = controle.RemovePedidos(txb_Id.Text);
                if (!txb_Id.Text.Equals(""))
                {
                    MessageBox.Show("Pedido removido com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Por favor, informe a ID do pedido!");
            }
        }

        private void EncerrarPedido_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_Cancelado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
