using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GerenciadorDeEstoque.Apresentação;
using GerenciadorDeEstoque.Modelo;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        Controle controle = new Controle(); // Instanciando a classe Controle

        private void NotificacaoM(string elemento) // Notificação com palavra no masculino
        {
            MessageBox.Show($"Por favor, preencha o {elemento}");
        }

        private void NotificacaoF(string elemento) // Notificação com palavra no feminino
        {
            MessageBox.Show($"Por favor, preencha a {elemento}");
        }

        // botão cadastre-se
        private void txb_register_Click(object sender, EventArgs e)
        {
            if (!txb_name.Text.Equals(""))
            {
                if (!txb_email_c.Text.Equals(""))
                {
                    if (!txb_password_c.Text.Equals(""))
                    {
                        if (!txb_confirmpassword.Text.Equals(""))
                        {
                            if (!txb_celphone.Text.Equals("") || !txb_celphone.Text.Contains("_"))
                            {
                                if (!txtb_reminderpassword.Text.Equals("") || !txtb_reminderpassword.Text.Equals("Lembrete da senha"))
                                {
                                    string mensagem = controle.Cadastrar(txb_name.Text, txb_email_c.Text, txb_password_c.Text, txb_confirmpassword.Text, txb_celphone.Text, txtb_reminderpassword.Text);

                                    if (controle.verificacao)
                                    {
                                        MessageBox.Show("Cadastro realizado!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao realizar o cadastro!");
                                    }
                                }
                                else
                                {
                                    NotificacaoM("lembrete da senha");
                                }
                            }
                            else
                            {
                                NotificacaoM("celular");
                            }
                        }
                        else
                        {
                            NotificacaoM("confirmar senha");
                        }
                    }
                    else
                    {
                        NotificacaoM("senha");
                    }
                }
                else
                {
                    NotificacaoM("e-mail");
                }
            }
            else
            {
                NotificacaoM("nome");
            }
        }

        private void txb_name_Click(object sender, EventArgs e) // Quando o usuário clicar no text box Nome
        {
            txb_name.Clear();
        }

        private void txb_email_c_Click(object sender, EventArgs e) // Quando o usuário clicar no text box Email
        {
            txb_email_c.Clear();
        }

        private void txb_password_c_Click(object sender, EventArgs e) // Quando o usuário clicar no text box Senha
        {
            txb_password_c.Clear();
        }

        private void txb_confirmpassword_Click(object sender, EventArgs e) // Quando o usuário clicar no text box confirmar senha
        {
            txb_confirmpassword.Clear();
        }

        private void txtb_reminderpassword_Click(object sender, EventArgs e) // Quando o usuário clicar no text box Lembrete senha
        {
            txtb_reminderpassword.Clear();
        }

        private void txb_password_c_TextChanged(object sender, EventArgs e) // Quando o usuário digitar algo no text box senha
        {
            txb_password_c.PasswordChar = '*';
        }

        private void txb_confirmpassword_TextChanged(object sender, EventArgs e) // Quando o usuário digitar algo no text box confirmar senha
        {
            txb_confirmpassword.PasswordChar = '*';
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 TelaPrincipal = new Form1();
            TelaPrincipal.Show();
            this.Hide();
        }
    }
}
