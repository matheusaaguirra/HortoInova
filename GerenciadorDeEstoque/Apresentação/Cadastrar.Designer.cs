
namespace GerenciadorDeEstoque.Apresentação
{
    partial class Cadastrar
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
            this.txb_password_c = new System.Windows.Forms.TextBox();
            this.txb_email_c = new System.Windows.Forms.TextBox();
            this.txb_register = new System.Windows.Forms.Button();
            this.txb_confirmpassword = new System.Windows.Forms.TextBox();
            this.txtb_reminderpassword = new System.Windows.Forms.TextBox();
            this.txb_celphone = new System.Windows.Forms.MaskedTextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_password_c
            // 
            this.txb_password_c.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_password_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_password_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password_c.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_password_c.Location = new System.Drawing.Point(42, 103);
            this.txb_password_c.MaxLength = 25;
            this.txb_password_c.Name = "txb_password_c";
            this.txb_password_c.Size = new System.Drawing.Size(220, 15);
            this.txb_password_c.TabIndex = 11;
            this.txb_password_c.Text = "Senha";
            this.txb_password_c.Click += new System.EventHandler(this.txb_password_c_Click);
            this.txb_password_c.TextChanged += new System.EventHandler(this.txb_password_c_TextChanged);
            // 
            // txb_email_c
            // 
            this.txb_email_c.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_email_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email_c.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_email_c.Location = new System.Drawing.Point(42, 69);
            this.txb_email_c.MaxLength = 50;
            this.txb_email_c.Name = "txb_email_c";
            this.txb_email_c.Size = new System.Drawing.Size(220, 15);
            this.txb_email_c.TabIndex = 9;
            this.txb_email_c.Text = "Email";
            this.txb_email_c.Click += new System.EventHandler(this.txb_email_c_Click);
            // 
            // txb_register
            // 
            this.txb_register.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txb_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb_register.Location = new System.Drawing.Point(51, 239);
            this.txb_register.Name = "txb_register";
            this.txb_register.Size = new System.Drawing.Size(177, 37);
            this.txb_register.TabIndex = 7;
            this.txb_register.Text = "CADASTRE-SE";
            this.txb_register.UseVisualStyleBackColor = false;
            this.txb_register.Click += new System.EventHandler(this.txb_register_Click);
            // 
            // txb_confirmpassword
            // 
            this.txb_confirmpassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_confirmpassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_confirmpassword.Location = new System.Drawing.Point(42, 134);
            this.txb_confirmpassword.MaxLength = 25;
            this.txb_confirmpassword.Name = "txb_confirmpassword";
            this.txb_confirmpassword.Size = new System.Drawing.Size(220, 15);
            this.txb_confirmpassword.TabIndex = 13;
            this.txb_confirmpassword.Text = "Confirmar senha";
            this.txb_confirmpassword.Click += new System.EventHandler(this.txb_confirmpassword_Click);
            this.txb_confirmpassword.TextChanged += new System.EventHandler(this.txb_confirmpassword_TextChanged);
            // 
            // txtb_reminderpassword
            // 
            this.txtb_reminderpassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtb_reminderpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_reminderpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_reminderpassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtb_reminderpassword.Location = new System.Drawing.Point(42, 199);
            this.txtb_reminderpassword.MaxLength = 50;
            this.txtb_reminderpassword.Name = "txtb_reminderpassword";
            this.txtb_reminderpassword.Size = new System.Drawing.Size(220, 15);
            this.txtb_reminderpassword.TabIndex = 17;
            this.txtb_reminderpassword.Text = "Lembrete da senha";
            this.txtb_reminderpassword.Click += new System.EventHandler(this.txtb_reminderpassword_Click);
            // 
            // txb_celphone
            // 
            this.txb_celphone.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_celphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_celphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_celphone.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_celphone.HideSelection = false;
            this.txb_celphone.Location = new System.Drawing.Point(42, 165);
            this.txb_celphone.Mask = "(999) 00000-0000";
            this.txb_celphone.Name = "txb_celphone";
            this.txb_celphone.Size = new System.Drawing.Size(220, 15);
            this.txb_celphone.TabIndex = 18;
            // 
            // txb_name
            // 
            this.txb_name.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_name.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_name.Location = new System.Drawing.Point(42, 37);
            this.txb_name.MaxLength = 50;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(220, 15);
            this.txb_name.TabIndex = 22;
            this.txb_name.Text = "Nome";
            this.txb_name.Click += new System.EventHandler(this.txb_name_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(42, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 1);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(42, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 1);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(42, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 1);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(42, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(42, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 1);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(42, 220);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 1);
            this.panel6.TabIndex = 24;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(51, 282);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(177, 37);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(302, 348);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_password_c);
            this.Controls.Add(this.txb_register);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_confirmpassword);
            this.Controls.Add(this.txb_email_c);
            this.Controls.Add(this.txtb_reminderpassword);
            this.Controls.Add(this.txb_celphone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_password_c;
        private System.Windows.Forms.Button txb_register;
        private System.Windows.Forms.TextBox txb_confirmpassword;
        private System.Windows.Forms.TextBox txtb_reminderpassword;
        private System.Windows.Forms.MaskedTextBox txb_celphone;
        public System.Windows.Forms.TextBox txb_email_c;
        public System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnVoltar;
    }
}