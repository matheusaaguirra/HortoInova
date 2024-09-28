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

namespace GerenciadorDeEstoque.Apresentação.Cliente
{
    public partial class AddClienteCNPJ : Form
    {
        public AddClienteCNPJ()
        {
            InitializeComponent();
        }

        private void NotificacaoM(string elemento)// Notificação com palavra no masculino
        {
            MessageBox.Show($"Por favor, preencha o {elemento}");
        }

        private void NotificacaoF(string elemento) // Notificação com palavra no feminino
        {
            MessageBox.Show($"Por favor, preencha a {elemento}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txb_NomeCNPJ.Text.Equals(""))
            {
                if (!txb_telefoneCNPJ.Text.Equals(""))
                {
                    if (!txb_celularCNPJ.Text.Equals(""))
                    {
                        if (!txb_CNPJ.Text.Equals(""))
                        {
                            if (!txb_endereco.Text.Equals(""))
                            {
                                if (!txb_email.Text.Equals(""))
                                {
                                    Controle controle = new Controle();
                                    string mensagem = controle.CadastrarClientesJuridicos(txb_NomeCNPJ.Text, txb_telefoneCNPJ.Text, txb_celularCNPJ.Text, txb_CNPJ.Text, txb_endereco.Text, txb_email.Text, txb_observacoes.Text);
                                    MessageBox.Show("Cliente cadastrado!");
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
                            NotificacaoM("CNPJ");
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
                NotificacaoM("nome da empresa");
            }
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txb_telefoneCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txb_NomeCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_celularCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
