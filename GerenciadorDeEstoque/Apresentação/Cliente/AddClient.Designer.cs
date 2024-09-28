
namespace GerenciadorDeEstoque.Apresentação
{
    partial class AddClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Endereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_Observacoes = new System.Windows.Forms.TextBox();
            this.txb_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txb_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.txb_RG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txb_Nome
            // 
            this.txb_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Nome.Location = new System.Drawing.Point(128, 7);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(431, 20);
            this.txb_Nome.TabIndex = 2;
            this.txb_Nome.TextChanged += new System.EventHandler(this.txb_Nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA NASCIMENTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFONE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RG";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ENDEREÇO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txb_Endereco
            // 
            this.txb_Endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Endereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Endereco.Location = new System.Drawing.Point(128, 137);
            this.txb_Endereco.Name = "txb_Endereco";
            this.txb_Endereco.Size = new System.Drawing.Size(590, 20);
            this.txb_Endereco.TabIndex = 12;
            this.txb_Endereco.TextChanged += new System.EventHandler(this.txb_Endereco_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label8.Location = new System.Drawing.Point(343, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "CELULAR";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "E-MAIL";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txb_Email
            // 
            this.txb_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Email.Location = new System.Drawing.Point(128, 163);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(355, 20);
            this.txb_Email.TabIndex = 16;
            this.txb_Email.TextChanged += new System.EventHandler(this.txb_Email_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label10.Location = new System.Drawing.Point(12, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "OBSERVAÇÕES";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txb_Observacoes
            // 
            this.txb_Observacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Observacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Observacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Observacoes.Location = new System.Drawing.Point(128, 189);
            this.txb_Observacoes.Name = "txb_Observacoes";
            this.txb_Observacoes.Size = new System.Drawing.Size(590, 20);
            this.txb_Observacoes.TabIndex = 18;
            this.txb_Observacoes.TextChanged += new System.EventHandler(this.txb_Observacoes_TextChanged);
            // 
            // txb_DataNascimento
            // 
            this.txb_DataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_DataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_DataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_DataNascimento.Location = new System.Drawing.Point(128, 33);
            this.txb_DataNascimento.Mask = "00/00/0000";
            this.txb_DataNascimento.Name = "txb_DataNascimento";
            this.txb_DataNascimento.Size = new System.Drawing.Size(190, 20);
            this.txb_DataNascimento.TabIndex = 20;
            this.txb_DataNascimento.ValidatingType = typeof(System.DateTime);
            this.txb_DataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_DataNascimento_MaskInputRejected);
            // 
            // txb_Telefone
            // 
            this.txb_Telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Telefone.Location = new System.Drawing.Point(129, 59);
            this.txb_Telefone.Mask = "(000) 0000-0000";
            this.txb_Telefone.Name = "txb_Telefone";
            this.txb_Telefone.Size = new System.Drawing.Size(190, 20);
            this.txb_Telefone.TabIndex = 21;
            this.txb_Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_Telefone_MaskInputRejected);
            // 
            // txb_Celular
            // 
            this.txb_Celular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Celular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_Celular.Location = new System.Drawing.Point(416, 59);
            this.txb_Celular.Mask = "(000) 00000-0000";
            this.txb_Celular.Name = "txb_Celular";
            this.txb_Celular.Size = new System.Drawing.Size(190, 20);
            this.txb_Celular.TabIndex = 22;
            this.txb_Celular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_Celular_MaskInputRejected);
            // 
            // txb_CPF
            // 
            this.txb_CPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_CPF.Location = new System.Drawing.Point(129, 111);
            this.txb_CPF.Mask = "000.000.000-00";
            this.txb_CPF.Name = "txb_CPF";
            this.txb_CPF.Size = new System.Drawing.Size(190, 20);
            this.txb_CPF.TabIndex = 25;
            this.txb_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_CPF_MaskInputRejected);
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btn_CadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btn_CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(15, 223);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(703, 23);
            this.btn_CadastrarCliente.TabIndex = 24;
            this.btn_CadastrarCliente.Text = "CADASTRAR CLIENTE";
            this.btn_CadastrarCliente.UseVisualStyleBackColor = false;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.btn_CadastrarCliente_Click);
            // 
            // txb_RG
            // 
            this.txb_RG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_RG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.txb_RG.Location = new System.Drawing.Point(128, 85);
            this.txb_RG.Name = "txb_RG";
            this.txb_RG.Size = new System.Drawing.Size(191, 20);
            this.txb_RG.TabIndex = 8;
            this.txb_RG.TextChanged += new System.EventHandler(this.txb_RG_TextChanged);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(91)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(730, 266);
            this.Controls.Add(this.txb_CPF);
            this.Controls.Add(this.btn_CadastrarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Celular);
            this.Controls.Add(this.txb_Endereco);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_Telefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_DataNascimento);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_RG);
            this.Controls.Add(this.txb_Observacoes);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar cliente (Pessoa física)";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_Observacoes;
        private System.Windows.Forms.MaskedTextBox txb_DataNascimento;
        private System.Windows.Forms.MaskedTextBox txb_Telefone;
        private System.Windows.Forms.MaskedTextBox txb_Celular;
        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.MaskedTextBox txb_CPF;
        private System.Windows.Forms.TextBox txb_RG;
    }
}