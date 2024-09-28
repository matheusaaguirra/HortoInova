
namespace GerenciadorDeEstoque.Apresentação
{
    partial class EditarProduto
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
            this.btn_deleteProduto = new System.Windows.Forms.Button();
            this.btn_rmvQnt = new System.Windows.Forms.Button();
            this.txb_Quantidade = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_idProduto = new System.Windows.Forms.TextBox();
            this.btn_AddQnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_deleteProduto
            // 
            this.btn_deleteProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btn_deleteProduto.FlatAppearance.BorderSize = 0;
            this.btn_deleteProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btn_deleteProduto.Location = new System.Drawing.Point(98, 95);
            this.btn_deleteProduto.Name = "btn_deleteProduto";
            this.btn_deleteProduto.Size = new System.Drawing.Size(244, 23);
            this.btn_deleteProduto.TabIndex = 10;
            this.btn_deleteProduto.Text = "EXCLUIR PRODUTO";
            this.btn_deleteProduto.UseVisualStyleBackColor = false;
            this.btn_deleteProduto.Click += new System.EventHandler(this.btn_deleteProduto_Click);
            // 
            // btn_rmvQnt
            // 
            this.btn_rmvQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btn_rmvQnt.FlatAppearance.BorderSize = 0;
            this.btn_rmvQnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rmvQnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btn_rmvQnt.Location = new System.Drawing.Point(229, 66);
            this.btn_rmvQnt.Name = "btn_rmvQnt";
            this.btn_rmvQnt.Size = new System.Drawing.Size(113, 23);
            this.btn_rmvQnt.TabIndex = 9;
            this.btn_rmvQnt.Text = "REMOVER";
            this.btn_rmvQnt.UseVisualStyleBackColor = false;
            this.btn_rmvQnt.Click += new System.EventHandler(this.btn_rmvQnt_Click);
            // 
            // txb_Quantidade
            // 
            this.txb_Quantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Quantidade.Location = new System.Drawing.Point(98, 40);
            this.txb_Quantidade.Name = "txb_Quantidade";
            this.txb_Quantidade.Size = new System.Drawing.Size(244, 13);
            this.txb_Quantidade.TabIndex = 8;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label_nome.Location = new System.Drawing.Point(15, 17);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(18, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(15, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUANTIDADE";
            // 
            // txb_idProduto
            // 
            this.txb_idProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.txb_idProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_idProduto.Location = new System.Drawing.Point(98, 14);
            this.txb_idProduto.Name = "txb_idProduto";
            this.txb_idProduto.Size = new System.Drawing.Size(244, 13);
            this.txb_idProduto.TabIndex = 1;
            // 
            // btn_AddQnt
            // 
            this.btn_AddQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(140)))), ((int)(((byte)(48)))));
            this.btn_AddQnt.FlatAppearance.BorderSize = 0;
            this.btn_AddQnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddQnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.btn_AddQnt.Location = new System.Drawing.Point(98, 66);
            this.btn_AddQnt.Name = "btn_AddQnt";
            this.btn_AddQnt.Size = new System.Drawing.Size(113, 23);
            this.btn_AddQnt.TabIndex = 2;
            this.btn_AddQnt.Text = "ADICIONAR";
            this.btn_AddQnt.UseVisualStyleBackColor = false;
            this.btn_AddQnt.Click += new System.EventHandler(this.btn_AddQnt_Click);
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(91)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(369, 141);
            this.Controls.Add(this.btn_deleteProduto);
            this.Controls.Add(this.btn_rmvQnt);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.txb_Quantidade);
            this.Controls.Add(this.btn_AddQnt);
            this.Controls.Add(this.txb_idProduto);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Quantidade;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_idProduto;
        private System.Windows.Forms.Button btn_AddQnt;
        private System.Windows.Forms.Button btn_deleteProduto;
        private System.Windows.Forms.Button btn_rmvQnt;
    }
}