using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.Modelo;
using GerenciadorDeEstoque.Apresentação;
using GerenciadorDeEstoque.DAO;
using GerenciadorDeEstoque.Properties;
using GerenciadorDeEstoque.Apresentação.Pedido;
using GerenciadorDeEstoque.Apresentação.Cliente;
using System.Threading;

namespace GerenciadorDeEstoque.DAO
{
    public class LoginDaoComandos : Cadastrar
    {
        public bool check = false;
        public string mensagem = "";
        SqlCommand comando = new SqlCommand();
        SqlCommand comandoVar = new SqlCommand();
        Conexao conect = new Conexao();
        SqlDataReader armazenardados;

        private void telaLogada() // Método para abrir a tela após logar
        {
            Application.Run(new TelaLogado());
        }

        public bool VerificarLogin(string login, string senha) // Método que verifica se login e senha estão corretos, passando a string true or false
        {
            comando.CommandText = "select * from funcionario where email = @email and senha = @senha";
            comando.Parameters.AddWithValue("@email", login);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                comando.Connection = conect.Conectar();
                armazenardados = comando.ExecuteReader();

                if (armazenardados.HasRows)
                {
                    check = true;
                    // Cmds para abrir a tela "TelaLogado" após a checagem dos logins
                    this.Visible = false;
                    TelaLogado formLogado = new TelaLogado();
                    formLogado.Show();
                    Form1 telaForm1 = new Form1();
                }

                conect.Desconectar();
                armazenardados.Close();
            }

            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados joao!";
            }
            return check;
        }

        public string RemoverProdutoEstoque(string id) // Método para remover o produto do estoque
        {
            if (!id.Equals(""))
            {
                comando.CommandText = "delete from produtos where idproduto = @id;";
                comando.Parameters.AddWithValue("@id", id);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Produto removido!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na removação do produto!";
                }
            }
            return mensagem;
        }

        public string EditarProdutoRemoverQnt(string id, string quantidade) // Método para editar o Produto no estoque (EDITAR)
        {
            if (!id.Equals("") && !quantidade.Equals(""))
            {
                comando.CommandText = "update produtos set quantidade = quantidade - @quantidade where idproduto = @id;";
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@quantidade", quantidade);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Quantidade removida com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na remoção da quantia do produto!";
                }
            }
            return mensagem;
        }

        public string EditarProduto(string id, string quantidade) // Método para editar o Produto no estoque (ADICIONAR)
        {
            if (!id.Equals("") && !quantidade.Equals(""))
            {
                comando.CommandText = "update produtos set quantidade = quantidade + @quantidade where idproduto = @id;";
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@quantidade", quantidade);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Quantidade adicionada com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na adição de quantidade do produto!";
                }
            }
            return mensagem;
        }


        public string CadastrarProduto(string nome, string cor, string preco, string quantidade, string tamanho, string preco_custo, string custo_marketplace) // Método para cadastrar o Produto no estoque
        {
            // Lógica para calcular o lucro da venda (preço da venda - custo da peça - custo marketplace)
            double precocusto = Convert.ToDouble(preco); // convertendo valor preço custo para int
            double precovenda = Convert.ToDouble(preco_custo); // convertendo valor preço venda para int
            double lucrodavenda = precovenda - precocusto; // efetuando a conta

            if (!nome.Equals("") && !preco.Equals("") && !quantidade.Equals(""))
            {
                comando.CommandText = "insert into produtos(nomeproduto, tipo, preco, quantidade, categoria, precovenda, customarketplace, lucro_venda)values(@nomeproduto, @cor, @precovenda, @quantidade, @tamanho, @preco, @customarketplace, @lucrodavenda);";
                comando.Parameters.AddWithValue("@nomeproduto", nome);
                comando.Parameters.AddWithValue("@cor", cor);
                comando.Parameters.AddWithValue("@preco", preco);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@tamanho", tamanho);
                comando.Parameters.AddWithValue("@precovenda", preco_custo);
                comando.Parameters.AddWithValue("@customarketplace", custo_marketplace);
                comando.Parameters.AddWithValue("@lucrodavenda", lucrodavenda);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Produto cadastrado!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro no cadastro do produto!";
                }
            }
            return mensagem;
        }

        // Método para adicionar novo Cliente Físico
        public string AddClienteFisico(string nome, string datanascimento, string telefone, string celular, string rg, string cpf, string endereco, string email, string observacoes)
        {
            if (!nome.Equals("") && !datanascimento.Equals("") && !celular.Equals("") && !cpf.Equals("") && !endereco.Equals("") && !email.Equals(""))
            {
                comando.CommandText = "insert into ClienteFisico(nome, datanascimento, telefone, celular, rg, cpf, endereco, email, observacoes)values(@nome, @datanascimento, @telefone, @celular, @rg, @cpf, @endereco, @email, @observacoes)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@datanascimento", datanascimento);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@observacoes", observacoes);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Cliente adicionado com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro no cadastro do cliente!";
                }
            }
            return mensagem;
        }

        // Método para adicionar novo Cliente Juridico / CNPJ
        public string AddClienteJuridico(string nome, string telefone, string celular, string cpf, string endereco, string email, string observacoes)
        {
            if (!nome.Equals("") && !celular.Equals("") && !cpf.Equals("") && !endereco.Equals("") && !email.Equals(""))
            {
                comando.CommandText = "insert into ClienteFisico(nome, telefone, celular, cpf, endereco, email, observacoes)values(@nome, @telefone, @celular, @cpf, @endereco, @email, @observacoes)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@observacoes", observacoes);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Cliente adicionado com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro no cadastro do cliente!";
                }
            }
            return mensagem;
        }


        public string Cadastrar(string nome, string email, string senha, string confirmarsenha, string celular, string lembretesenha)
        {
            // Validar se o e-mail digitado contem @ e .com
            string check_email = email;
            bool valor_checkemail = check_email.Contains("@") && check_email.Contains(".com");
            if (valor_checkemail == true)
            {
                // checar se campos não estão em branco
                if (!nome.Equals("") && !email.Equals("") && !senha.Equals("") && !celular.Equals("") && !lembretesenha.Equals(""))
                {
                    // checar se senha e email tem caracteres minimos
                    if (senha.Length >= 5 && email.Length >= 8)
                    {
                        // checar se senha é igual a confirmar senha
                        if (senha.Equals(confirmarsenha))
                        {
                            comando.CommandText = "insert into funcionario(nome, email, senha, celular, lembretesenha)values(@nome, @email, @senha, @celular, @lembretesenha);";
                            comando.Parameters.AddWithValue("@nome", nome);
                            comando.Parameters.AddWithValue("@email", email);
                            comando.Parameters.AddWithValue("@senha", senha);
                            comando.Parameters.AddWithValue("@celular", celular);
                            comando.Parameters.AddWithValue("@lembretesenha", lembretesenha);

                            check = false;
                            try
                            {
                                comando.Connection = conect.Conectar();
                                comando.ExecuteNonQuery();
                                conect.Desconectar();
                                this.mensagem = "Cadastrado com sucesso!";

                                check = true;
                            }

                            catch (SqlException)
                            {
                                this.mensagem = "Erro com o banco de dados!";
                            }
                        }

                        else
                        {
                            MessageBox.Show("As senhas devem ser iguais!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, use uma senha com mais de 5 caracteres!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, não deixe campos em branco!");
                }
            }
            else
            {
                MessageBox.Show("Digite um e-mail válido!");
            }

            return mensagem;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginDaoComandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LoginDaoComandos";
            this.Load += new System.EventHandler(this.LoginDaoComandos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Método para cadastrar o Pedidos de clientes
        public string CadastrarPedidos(string produto, string qntestoque, string qntproduto, string valorproduto, string nomecliente, string tipodevenda, string formapgt, string desconto, string valortotalpedido, string marketplace)
        {
            if (!produto.Equals("") && !qntproduto.Equals("") && !valorproduto.Equals("") && !nomecliente.Equals("") && !formapgt.Equals("") && !valortotalpedido.Equals(""))
            {
                // Convertendo o valor da txtBox que diz a quantidade do produtos x em estoque
                int qntestoque_ = Convert.ToInt32(qntestoque);
                // Convertendo o valor da txtBox que diz a quantidade que o usuário quer informar no pedido
                int qntproduto_ = Convert.ToInt32(qntproduto);

                // Condição: se a quantidade em estoque for maior que a quantidade que o usuário quer no pedido, aí o pedido pode entrar no sistema
                if (qntestoque_ >= qntproduto_)
                {
                    // fazendo a subtração do que tem em estoque menos o que o usuário informou no pedido
                    int qntotal = qntestoque_ - qntproduto_;
                    // passando para string para passar para o banco de dados de novo
                    string qntotal_ = Convert.ToString(qntotal);

                    // comando para subtrair o valor do estoque, pelo valor solicitado no pedido do cliente
                    comandoVar.CommandText = "update produto set quantidade = @quantidadepedido where comprador = @produto;";
                    comandoVar.Parameters.AddWithValue("@quantidadepedido", qntotal_);
                    comandoVar.Parameters.AddWithValue("@produto", produto);

                    comando.CommandText = "INSERT INTO pedidos_encerrados (estado, produto, quantidade, valorunitario, comprador, plataforma, formapgt, desconto, valortotal, marketplace) \n    VALUES ('Pendente', @produto, @quantidadepedido, @valorunitario, @cliente, @tipodevenda, @formadepgt, @desconto, @valortotalpedido, @marketplace);";
                    comando.Parameters.AddWithValue("@produto", produto);
                    comando.Parameters.AddWithValue("@quantidadepedido", qntproduto);
                    comando.Parameters.AddWithValue("@valorunitario", valorproduto);
                    comando.Parameters.AddWithValue("@cliente", nomecliente);
                    comando.Parameters.AddWithValue("@tipodevenda", tipodevenda);
                    comando.Parameters.AddWithValue("@formadepgt", formapgt);
                    comando.Parameters.AddWithValue("@desconto", desconto);
                    comando.Parameters.AddWithValue("@valortotalpedido", valortotalpedido);
                    comando.Parameters.AddWithValue("@marketplace", marketplace);

                    check = false;
                    try
                    {
                        comandoVar.Connection = conect.Conectar();
                        comandoVar.ExecuteNonQuery();

                        comando.Connection = conect.Conectar();
                        comando.ExecuteNonQuery();
                        conect.Desconectar();
                        this.mensagem = "Produto cadastrado!";

                        check = true;
                    }

                    catch (SqlException)
                    {
                        this.mensagem = "Erro no cadastro do produto!";
                    }
                }
                else
                {
                    this.mensagem = "Quantidade do pedido é maior que a quantidade do produto em estoque!";
                }
            }
            return mensagem;
        }

        public string PedidosEncerrados(string id, Boolean pago, Boolean cancelado) // Método para cadastrar pedidos encerrados
        {
            // Se o campo ID do pedido não estiver em branco
            if (!id.Equals(""))
            {
                // Checando se o usuário não deixou marcado as duas Check Box (tanto pago, quanto cancelado)...
                // Nesse caso, retornar erro
                if (pago == true && cancelado == true)
                {
                    this.mensagem = "Seleciona apenas uma opção!";
                }

                // Caso tenha selecionado somente uma opção, executamos a inserção
                else
                {
                    // Se ele selecionou que o pedido está pago, executa estes comandos
                    if (pago == true)
                    {
                        // Tem três comandos:
                        //1.  Atualizando o estado do pedido para PAGO
                        //2. Formata todos os dados da tabela analisevendas (que é onde faz o analytics das vendas)
                        //3. Passa todos os dados de valores para a tabela analisevendas
                        comando.CommandText = "update pedidos_encerrados set estado = 'Concluido' where idpedido = @id; truncate table analisevendas; INSERT INTO analisevendas(total, dataPedido) SELECT valortotal, dataAddPedido FROM pedidos_encerrados where estado = 'pago';";
                        comando.Parameters.AddWithValue("@id", id);

                        check = false;
                        try
                        {
                            comando.Connection = conect.Conectar();
                            comando.ExecuteNonQuery();
                            conect.Desconectar();
                            this.mensagem = "Estado do pedido modificado!";

                            check = true;
                        }

                        catch (SqlException)
                        {
                            this.mensagem = "Erro no cadastro do produto!";
                        }
                    }

                    // Se ele selecionou que o pedido está cancelado, executa estes comandos
                    if (cancelado == true)
                    {
                        // Atualizando o estado do pedido para CANCELADO
                        comando.CommandText = "update pedidos_encerrados set estado = 'Cancelado' where idpedido = @id;";
                        comando.Parameters.AddWithValue("@id", id);

                        check = false;
                        try
                        {
                            comando.Connection = conect.Conectar();
                            comando.ExecuteNonQuery();
                            conect.Desconectar();
                            this.mensagem = "Estado do pedido modificado!";

                            check = true;
                        }

                        catch (SqlException)
                        {
                            this.mensagem = "Erro no cadastro do produto!";
                        }
                    }
                }
            }

            return mensagem;
        }

        // Método para adicionar Editar Cliente
        public string EditarCliente(string id, string nome, string datanascimento, string telefone, string celular, string rg, string cpf, string endereco, string email, string observacoes)
        {
            if (!nome.Equals("") && !datanascimento.Equals("") && !celular.Equals("") && !celular.Equals("") && !cpf.Equals("") && !endereco.Equals("") && !email.Equals(""))
            {
                comando.CommandText = @"
                UPDATE clientefisico 
                SET 
                    nome = @nome, 
                    datanascimento = @datanascimento, 
                    telefone = @telefone, 
                    celular = @celular, 
                    rg = @rg, 
                    cpf = @cpf, 
                    endereco = @endereco, 
                    email = @email, 
                    observacoes = @observacoes 
                WHERE idclientefisico = @id;
            ";

                // Adicionando os parâmetros necessários
                comando.Parameters.AddWithValue("@nome", nome);                // Substitua 'nome' pela variável correspondente
                comando.Parameters.AddWithValue("@datanascimento", datanascimento); // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@telefone", telefone);        // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@celular", celular);          // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@rg", rg);                    // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@cpf", cpf);                  // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@endereco", endereco);        // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@email", email);              // Substitua pela variável correspondente
                comando.Parameters.AddWithValue("@observacoes", observacoes);  // Substitua pela variável correspondente
                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Cliente editado com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na edição do cliente!";
                }
            }
            return mensagem;
        }

        public string RemoverCliente(string id) // Método para remover cliente
        {
            if (!id.Equals(""))
            {
                comando.CommandText = "delete from clientefisico where idclientefisico = @id;";
                comando.Parameters.AddWithValue("@id", id);

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
            }
            return mensagem;
        }

        public string RemoverPedido(string id) // Método para remover Pedido
        {
            if (!id.Equals(""))
            {
                comando.CommandText = "delete from pedidos_encerrados where idpedido = @id;";
                comando.Parameters.AddWithValue("@id", id);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Pedido removido com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na remoção do pedido!";
                }
            }
            return mensagem;
        }

        public string EditarUsuario(string nome, string email, string celular, string nomeantigo) // Método para Editar Usuário
        {
            if (!nome.Equals("") && !email.Equals("") && !celular.Equals(""))
            {
                // A variável name eu passo da form EditarUsuario, pois é o valor do nome sem edição que o usuário selecionou
                comando.CommandText = $"update funcionario set nome = @nome, email = @email, celular = @celular where nome = @nomeantigo;";
                
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@nomeantigo", nomeantigo);

                check = false;
                try
                {
                    comando.Connection = conect.Conectar();
                    comando.ExecuteNonQuery();
                    conect.Desconectar();
                    this.mensagem = "Usuário editado com sucesso!";

                    check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro na edição do cliente!";
                }
            }
            return mensagem;
        }

        public string SalvarDados(string email, string senha, string salvar) // Método para checar se é para salvar dados do login
        {
            // comando.CommandText = "insert into salvar_dados(email, senha, salvar)values(@email, @senha, @salvar);";
            comando.CommandText = "update salvar_dados set EMAIL = @email, SENHA = @senha, SALVAR = @salvar where ID = 1";
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@salvar", salvar);

            check = false;
            try
            {
                comando.Connection = conect.Conectar();
                comando.ExecuteNonQuery();
                conect.Desconectar();
                this.mensagem = "Usuário memorizado!";
                check = true;
            }

            catch (SqlException)
            {
                this.mensagem = "Erro!";
            }
            return mensagem;
        }

        private void LoginDaoComandos_Load(object sender, EventArgs e)
        {

        }
    }
}
