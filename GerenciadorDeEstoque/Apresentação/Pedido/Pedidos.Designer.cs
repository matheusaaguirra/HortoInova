
namespace GerenciadorDeEstoque.Apresentação.Pedido
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxVenda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbValorPorUnidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbQnt = new System.Windows.Forms.TextBox();
            this.txb_QntEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txbDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.comboBox_FormaPgt = new System.Windows.Forms.ComboBox();
            this.label_formPagt = new System.Windows.Forms.Label();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.clientefisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet1 = new GerenciadorDeEstoque.estoqueDataSet1();
            this.comboBox_Produto = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet = new GerenciadorDeEstoque.estoqueDataSet();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label_Qnt = new System.Windows.Forms.Label();
            this.label_Produto = new System.Windows.Forms.Label();
            this.funcionarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeClientes = new GerenciadorDeEstoque.NomeClientes();
            this.funcionarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new GerenciadorDeEstoque.estoqueDataSetTableAdapters.produtosTableAdapter();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new GerenciadorDeEstoque.NomeClientesTableAdapters.funcionarioTableAdapter();
            this.nomeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientefisicoTableAdapter = new GerenciadorDeEstoque.estoqueDataSet1TableAdapters.clientefisicoTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPlataformaVirtual = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientefisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVenda
            // 
            this.comboBoxVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.comboBoxVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.comboBoxVenda.FormattingEnabled = true;
            this.comboBoxVenda.Items.AddRange(new object[] {
            "Física",
            "Virtual"});
            this.comboBoxVenda.Location = new System.Drawing.Point(646, 36);
            this.comboBoxVenda.Name = "comboBoxVenda";
            this.comboBoxVenda.Size = new System.Drawing.Size(149, 21);
            this.comboBoxVenda.TabIndex = 23;
            this.comboBoxVenda.Text = "Selecione";
            this.comboBoxVenda.SelectedIndexChanged += new System.EventHandler(this.comboBoxVenda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(538, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Venda";
            // 
            // txbValorPorUnidade
            // 
            this.txbValorPorUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbValorPorUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorPorUnidade.Location = new System.Drawing.Point(335, 62);
            this.txbValorPorUnidade.Name = "txbValorPorUnidade";
            this.txbValorPorUnidade.ReadOnly = true;
            this.txbValorPorUnidade.Size = new System.Drawing.Size(193, 20);
            this.txbValorPorUnidade.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(239, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Valor por unidade";
            // 
            // txbQnt
            // 
            this.txbQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbQnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQnt.Location = new System.Drawing.Point(647, 12);
            this.txbQnt.Name = "txbQnt";
            this.txbQnt.Size = new System.Drawing.Size(148, 20);
            this.txbQnt.TabIndex = 19;
            this.txbQnt.TextChanged += new System.EventHandler(this.txbQnt_TextChanged);
            // 
            // txb_QntEstoque
            // 
            this.txb_QntEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_QntEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_QntEstoque.Location = new System.Drawing.Point(428, 12);
            this.txb_QntEstoque.Name = "txb_QntEstoque";
            this.txb_QntEstoque.ReadOnly = true;
            this.txb_QntEstoque.Size = new System.Drawing.Size(100, 20);
            this.txb_QntEstoque.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(302, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantidade em estoque";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorTotal.Location = new System.Drawing.Point(287, 88);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.ReadOnly = true;
            this.txbValorTotal.Size = new System.Drawing.Size(96, 20);
            this.txbValorTotal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(219, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TOTAL R$:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btnAplicar.Location = new System.Drawing.Point(143, 86);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 13;
            this.btnAplicar.Text = "APLICAR DESCONTO";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txbDesconto
            // 
            this.txbDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDesconto.Location = new System.Drawing.Point(80, 88);
            this.txbDesconto.Name = "txbDesconto";
            this.txbDesconto.Size = new System.Drawing.Size(54, 20);
            this.txbDesconto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Desconto %";
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btnPedido.Location = new System.Drawing.Point(14, 121);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(781, 23);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = "CADASTRAR PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // comboBox_FormaPgt
            // 
            this.comboBox_FormaPgt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.comboBox_FormaPgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_FormaPgt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.comboBox_FormaPgt.FormattingEnabled = true;
            this.comboBox_FormaPgt.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Boleto"});
            this.comboBox_FormaPgt.Location = new System.Drawing.Point(122, 61);
            this.comboBox_FormaPgt.Name = "comboBox_FormaPgt";
            this.comboBox_FormaPgt.Size = new System.Drawing.Size(111, 21);
            this.comboBox_FormaPgt.TabIndex = 7;
            this.comboBox_FormaPgt.Text = "Selecione";
            // 
            // label_formPagt
            // 
            this.label_formPagt.AutoSize = true;
            this.label_formPagt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label_formPagt.Location = new System.Drawing.Point(9, 65);
            this.label_formPagt.Name = "label_formPagt";
            this.label_formPagt.Size = new System.Drawing.Size(107, 13);
            this.label_formPagt.TabIndex = 6;
            this.label_formPagt.Text = "Forma de pagamento";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.comboBox_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientefisicoBindingSource, "nome", true));
            this.comboBox_Cliente.DataSource = this.clientefisicoBindingSource;
            this.comboBox_Cliente.DisplayMember = "nome";
            this.comboBox_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(61, 36);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(467, 21);
            this.comboBox_Cliente.TabIndex = 5;
            this.comboBox_Cliente.ValueMember = "nome";
            // 
            // clientefisicoBindingSource
            // 
            this.clientefisicoBindingSource.DataMember = "clientefisico";
            this.clientefisicoBindingSource.DataSource = this.estoqueDataSet1;
            // 
            // estoqueDataSet1
            // 
            this.estoqueDataSet1.DataSetName = "estoqueDataSet1";
            this.estoqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Produto
            // 
            this.comboBox_Produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.comboBox_Produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource7, "nome", true));
            this.comboBox_Produto.DataSource = this.produtosBindingSource7;
            this.comboBox_Produto.DisplayMember = "nome";
            this.comboBox_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Produto.FormattingEnabled = true;
            this.comboBox_Produto.Location = new System.Drawing.Point(61, 12);
            this.comboBox_Produto.Name = "comboBox_Produto";
            this.comboBox_Produto.Size = new System.Drawing.Size(235, 21);
            this.comboBox_Produto.TabIndex = 3;
            this.comboBox_Produto.ValueMember = "nome";
            this.comboBox_Produto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Produto_SelectedIndexChanged);
            // 
            // produtosBindingSource7
            // 
            this.produtosBindingSource7.DataMember = "produtos";
            this.produtosBindingSource7.DataSource = this.estoqueDataSetBindingSource;
            // 
            // estoqueDataSetBindingSource
            // 
            this.estoqueDataSetBindingSource.DataSource = this.estoqueDataSet;
            this.estoqueDataSetBindingSource.Position = 0;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label_cliente.Location = new System.Drawing.Point(11, 39);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 2;
            this.label_cliente.Text = "Cliente";
            // 
            // label_Qnt
            // 
            this.label_Qnt.AutoSize = true;
            this.label_Qnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label_Qnt.Location = new System.Drawing.Point(538, 14);
            this.label_Qnt.Name = "label_Qnt";
            this.label_Qnt.Size = new System.Drawing.Size(112, 13);
            this.label_Qnt.TabIndex = 1;
            this.label_Qnt.Text = "Quantidade do pedido";
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label_Produto.Location = new System.Drawing.Point(11, 15);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(44, 13);
            this.label_Produto.TabIndex = 0;
            this.label_Produto.Text = "Produto";
            // 
            // funcionarioBindingSource2
            // 
            this.funcionarioBindingSource2.DataMember = "funcionario";
            this.funcionarioBindingSource2.DataSource = this.nomeClientes;
            // 
            // nomeClientes
            // 
            this.nomeClientes.DataSetName = "NomeClientes";
            this.nomeClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource3
            // 
            this.funcionarioBindingSource3.DataMember = "funcionario";
            this.funcionarioBindingSource3.DataSource = this.nomeClientes;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.estoqueDataSet;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.estoqueDataSet;
            // 
            // produtosBindingSource5
            // 
            this.produtosBindingSource5.DataMember = "produtos";
            this.produtosBindingSource5.DataSource = this.estoqueDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.estoqueDataSet;
            // 
            // produtosBindingSource3
            // 
            this.produtosBindingSource3.DataMember = "produtos";
            this.produtosBindingSource3.DataSource = this.estoqueDataSet;
            // 
            // produtosBindingSource4
            // 
            this.produtosBindingSource4.DataMember = "produtos";
            this.produtosBindingSource4.DataSource = this.estoqueDataSetBindingSource;
            // 
            // produtosBindingSource6
            // 
            this.produtosBindingSource6.DataMember = "produtos";
            this.produtosBindingSource6.DataSource = this.estoqueDataSet;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.nomeClientes;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // nomeClientesBindingSource
            // 
            this.nomeClientesBindingSource.DataSource = this.nomeClientes;
            this.nomeClientesBindingSource.Position = 0;
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "funcionario";
            this.funcionarioBindingSource1.DataSource = this.nomeClientesBindingSource;
            // 
            // clientefisicoTableAdapter
            // 
            this.clientefisicoTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(538, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marketplace";
            // 
            // comboBoxPlataformaVirtual
            // 
            this.comboBoxPlataformaVirtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.comboBoxPlataformaVirtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPlataformaVirtual.FormattingEnabled = true;
            this.comboBoxPlataformaVirtual.Location = new System.Drawing.Point(646, 60);
            this.comboBoxPlataformaVirtual.Name = "comboBoxPlataformaVirtual";
            this.comboBoxPlataformaVirtual.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPlataformaVirtual.TabIndex = 26;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(91)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(813, 160);
            this.Controls.Add(this.comboBoxPlataformaVirtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbQnt);
            this.Controls.Add(this.comboBoxVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Produto);
            this.Controls.Add(this.txbValorPorUnidade);
            this.Controls.Add(this.label_Qnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.comboBox_Produto);
            this.Controls.Add(this.txb_QntEstoque);
            this.Controls.Add(this.comboBox_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_formPagt);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.comboBox_FormaPgt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDesconto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientefisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txbDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.ComboBox comboBox_FormaPgt;
        private System.Windows.Forms.Label label_formPagt;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.ComboBox comboBox_Produto;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Label label_Qnt;
        private System.Windows.Forms.Label label_Produto;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private estoqueDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.BindingSource produtosBindingSource3;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private System.Windows.Forms.BindingSource produtosBindingSource5;
        private System.Windows.Forms.BindingSource estoqueDataSetBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource4;
        private System.Windows.Forms.TextBox txb_QntEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQnt;
        private System.Windows.Forms.BindingSource produtosBindingSource6;
        private NomeClientes nomeClientes;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private NomeClientesTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource2;
        private System.Windows.Forms.BindingSource funcionarioBindingSource3;
        private System.Windows.Forms.BindingSource nomeClientesBindingSource;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
        private System.Windows.Forms.TextBox txbValorPorUnidade;
        private System.Windows.Forms.Label label2;
        private estoqueDataSet1 estoqueDataSet1;
        private System.Windows.Forms.BindingSource clientefisicoBindingSource;
        private estoqueDataSet1TableAdapters.clientefisicoTableAdapter clientefisicoTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource7;
        private System.Windows.Forms.ComboBox comboBoxVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPlataformaVirtual;
    }
}