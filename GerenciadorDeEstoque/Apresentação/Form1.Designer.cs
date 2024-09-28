
namespace GerenciadorDeEstoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txb_register = new System.Windows.Forms.Button();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_join = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxDadosLogin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_register
            // 
            this.txb_register.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.txb_register, "txb_register");
            this.txb_register.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_register.Name = "txb_register";
            this.txb_register.UseVisualStyleBackColor = false;
            this.txb_register.Click += new System.EventHandler(this.txb_register_Click);
            // 
            // txb_email
            // 
            this.txb_email.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txb_email, "txb_email");
            this.txb_email.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_email.Name = "txb_email";
            this.txb_email.Click += new System.EventHandler(this.txb_email_Click);
            // 
            // txb_password
            // 
            this.txb_password.BackColor = System.Drawing.Color.SteelBlue;
            this.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txb_password, "txb_password");
            this.txb_password.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_password.HideSelection = false;
            this.txb_password.Name = "txb_password";
            this.txb_password.Click += new System.EventHandler(this.txb_password_Click_1);
            this.txb_password.TextChanged += new System.EventHandler(this.txb_password_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // txb_join
            // 
            this.txb_join.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.txb_join, "txb_join");
            this.txb_join.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_join.Name = "txb_join";
            this.txb_join.UseVisualStyleBackColor = false;
            this.txb_join.Click += new System.EventHandler(this.txb_join_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerenciadorDeEstoque.Properties.Resources.logo64x64;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerenciadorDeEstoque.Properties.Resources.passwordBlue24;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeEstoque.Properties.Resources.iconUser24Blue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxDadosLogin
            // 
            resources.ApplyResources(this.checkBoxDadosLogin, "checkBoxDadosLogin");
            this.checkBoxDadosLogin.Name = "checkBoxDadosLogin";
            this.checkBoxDadosLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.checkBoxDadosLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_join);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txb_register;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button txb_join;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.CheckBox checkBoxDadosLogin;
        public System.Windows.Forms.TextBox txb_email;
        public System.Windows.Forms.TextBox txb_password;
    }
}

