
namespace GerenciadorDeEstoque.Apresentação.Cliente
{
    partial class EditarCliente
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
            this.clientefisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet2 = new GerenciadorDeEstoque.estoqueDataSet2();
            this.clientefisicoTableAdapter = new GerenciadorDeEstoque.estoqueDataSet2TableAdapters.clientefisicoTableAdapter();
            this.txbString = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDataNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbObservacoes = new System.Windows.Forms.TextBox();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnRemoverProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientefisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientefisicoBindingSource
            // 
            this.clientefisicoBindingSource.DataMember = "clientefisico";
            this.clientefisicoBindingSource.DataSource = this.estoqueDataSet2;
            // 
            // estoqueDataSet2
            // 
            this.estoqueDataSet2.DataSetName = "estoqueDataSet2";
            this.estoqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientefisicoTableAdapter
            // 
            this.clientefisicoTableAdapter.ClearBeforeFill = true;
            // 
            // txbString
            // 
            this.txbString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbString.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientefisicoBindingSource, "idclientefisico", true));
            this.txbString.DataSource = this.clientefisicoBindingSource;
            this.txbString.DisplayMember = "idclientefisico";
            this.txbString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txbString.FormattingEnabled = true;
            this.txbString.Location = new System.Drawing.Point(85, 16);
            this.txbString.Name = "txbString";
            this.txbString.Size = new System.Drawing.Size(56, 21);
            this.txbString.TabIndex = 0;
            this.txbString.ValueMember = "idclientefisico";
            this.txbString.SelectedIndexChanged += new System.EventHandler(this.txbString_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Location = new System.Drawing.Point(197, 17);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(309, 20);
            this.txbNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(156, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(521, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de nascimento";
            // 
            // txbDataNascimento
            // 
            this.txbDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDataNascimento.Location = new System.Drawing.Point(629, 18);
            this.txbDataNascimento.Name = "txbDataNascimento";
            this.txbDataNascimento.Size = new System.Drawing.Size(118, 20);
            this.txbDataNascimento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTelefone.Location = new System.Drawing.Point(85, 43);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(131, 20);
            this.txbTelefone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(236, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // txbCelular
            // 
            this.txbCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCelular.Location = new System.Drawing.Point(281, 43);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(184, 20);
            this.txbCelular.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(491, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "RG";
            // 
            // txbRG
            // 
            this.txbRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRG.Location = new System.Drawing.Point(520, 43);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(227, 20);
            this.txbRG.TabIndex = 11;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.labelCPF.Location = new System.Drawing.Point(9, 71);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(59, 13);
            this.labelCPF.TabIndex = 12;
            this.labelCPF.Text = "CPF/CNPJ";
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCPF.Location = new System.Drawing.Point(85, 68);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(250, 20);
            this.txbCPF.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label8.Location = new System.Drawing.Point(9, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Endereço";
            // 
            // txbEndereco
            // 
            this.txbEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEndereco.Location = new System.Drawing.Point(85, 94);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(662, 20);
            this.txbEndereco.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label9.Location = new System.Drawing.Point(348, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "E-mail";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Location = new System.Drawing.Point(403, 69);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(344, 20);
            this.txbEmail.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label10.Location = new System.Drawing.Point(9, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Observações";
            // 
            // txbObservacoes
            // 
            this.txbObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txbObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservacoes.Location = new System.Drawing.Point(85, 122);
            this.txbObservacoes.Name = "txbObservacoes";
            this.txbObservacoes.Size = new System.Drawing.Size(662, 20);
            this.txbObservacoes.TabIndex = 19;
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btnAlterarDados.FlatAppearance.BorderSize = 0;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDados.Location = new System.Drawing.Point(161, 159);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(215, 23);
            this.btnAlterarDados.TabIndex = 20;
            this.btnAlterarDados.Text = "ALTERAR DADOS";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // btnRemoverProdutos
            // 
            this.btnRemoverProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btnRemoverProdutos.FlatAppearance.BorderSize = 0;
            this.btnRemoverProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverProdutos.Location = new System.Drawing.Point(384, 159);
            this.btnRemoverProdutos.Name = "btnRemoverProdutos";
            this.btnRemoverProdutos.Size = new System.Drawing.Size(130, 23);
            this.btnRemoverProdutos.TabIndex = 21;
            this.btnRemoverProdutos.Text = "REMOVER CLIENTE";
            this.btnRemoverProdutos.UseVisualStyleBackColor = false;
            this.btnRemoverProdutos.Click += new System.EventHandler(this.btnRemoverProdutos_Click_1);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(91)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(763, 201);
            this.Controls.Add(this.btnRemoverProdutos);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbObservacoes);
            this.Controls.Add(this.txbString);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDataNascimento);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbCelular);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientefisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private estoqueDataSet2 estoqueDataSet2;
        private System.Windows.Forms.BindingSource clientefisicoBindingSource;
        private estoqueDataSet2TableAdapters.clientefisicoTableAdapter clientefisicoTableAdapter;
        public System.Windows.Forms.ComboBox txbString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbObservacoes;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnRemoverProdutos;
    }
}