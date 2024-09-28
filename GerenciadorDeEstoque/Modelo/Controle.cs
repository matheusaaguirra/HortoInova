using GerenciadorDeEstoque.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.Modelo
{
    public class Controle
    {
        public bool verificacao;
        public string mensagem = "";
        
        public bool Acessar(string login, string senha) // Método para acessar a acc
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            verificacao = loginDao.VerificarLogin(login, senha);
            
            if (!loginDao.mensagem.Equals("")) // Armazenando mensagem de erro
            {
                this.mensagem = loginDao.mensagem;
            }
            return verificacao;
        }

        // Método para cadastrar a acc
        public string Cadastrar(string nome, string email, string senha, string confirmarsenha, string celular, string lembretesenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.Cadastrar(nome, email, senha, confirmarsenha, celular, lembretesenha);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string RemoverProductEstoque(string id) // Método para remover o produto do estoque
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.RemoverProdutoEstoque(id);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }
        
        public string EditarProdutosRemvQnt(string id, string quantidade) // Método para editar o produto no estoque (REMOVER QNT)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.EditarProdutoRemoverQnt(id, quantidade);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string EditarProdutos(string id, string quantidade) // Método para editar o produto no estoque (ADICIONAR QNT)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.EditarProduto(id, quantidade);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string CadastrarProdutos(string nome, string cor, string preco, string quantidade, string tamanho, string preco_custo, string custo_marketplace) // Método para cadastrar um produto novo no estoque
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarProduto(nome, cor, preco, quantidade, tamanho, preco_custo, custo_marketplace);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        // Método para cadastrar cliente físico
        public string CadastrarClientesFisico(string nome, string datanascimento, string telefone, string celular, string rg, string cpf, string endereco, string email, string observacoes)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.AddClienteFisico(nome, datanascimento, telefone, celular, rg, cpf, endereco, email, observacoes);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        // Método para cadastrar cliente jurídico / CNPJ
        public string CadastrarClientesJuridicos(string nome, string telefone, string celular, string cpf, string endereco, string email, string observacoes)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.AddClienteJuridico(nome, telefone, celular, cpf, endereco, email, observacoes);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        // Método para editar cliente 
        public string EditarClientes(string id, string nome, string datanascimento, string telefone, string celular, string rg, string cpf, string endereco, string email, string observacoes)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.EditarCliente(id, nome, datanascimento, telefone, celular, rg, cpf, endereco, email, observacoes);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        // Método para cadastrar pedido do cliente
        public string CadastrarPedidoCliente(string produto, string qntestoque, string qntproduto, string valorproduto, string nomecliente, string tipodevenda, string formapgt, string desconto, string valortotalpedido, string marketplace)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarPedidos(produto, qntestoque, qntproduto, valorproduto, nomecliente, tipodevenda, formapgt, desconto, valortotalpedido, marketplace);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string CadastrarPedidoEstado(string id, Boolean pago, Boolean cancelado) // Método para alterar estado do pedido
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.PedidosEncerrados(id, pago, cancelado);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }
        
        public string RemoverClientes(string id) // Método para remover cliente
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.RemoverCliente(id);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string RemovePedidos(string id) // Método para remover pedido
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.RemoverPedido(id);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string EditarUsuarios(string nome, string email, string celular, string nomeantigo) // Método para editar usuário
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.EditarUsuario(nome, email, celular, nomeantigo);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }

        public string ChecarSaveDadosLogin(string email, string senha, string salvar)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.SalvarDados(email, senha, salvar);

            if (loginDao.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }
    }
}
