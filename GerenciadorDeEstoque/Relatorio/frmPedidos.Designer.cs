
namespace GerenciadorDeEstoque.Relatorio
{
    partial class frmPedidos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtViewPedidos = new System.Windows.Forms.DataGridView();
            this.estoquePedidos = new GerenciadorDeEstoque.estoquePedidos();
            this.estoquePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoquePedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GerenciadorDeEstoque.Relatorio.RelatorioPedidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1401, 686);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtViewPedidos
            // 
            this.dtViewPedidos.AutoGenerateColumns = false;
            this.dtViewPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewPedidos.DataSource = this.estoquePedidosBindingSource1;
            this.dtViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtViewPedidos.Location = new System.Drawing.Point(0, 0);
            this.dtViewPedidos.Name = "dtViewPedidos";
            this.dtViewPedidos.Size = new System.Drawing.Size(1401, 686);
            this.dtViewPedidos.TabIndex = 2;
            this.dtViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtViewPedidos_CellContentClick);
            // 
            // estoquePedidos
            // 
            this.estoquePedidos.DataSetName = "estoquePedidos";
            this.estoquePedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoquePedidosBindingSource
            // 
            this.estoquePedidosBindingSource.DataSource = this.estoquePedidos;
            this.estoquePedidosBindingSource.Position = 0;
            // 
            // estoquePedidosBindingSource1
            // 
            this.estoquePedidosBindingSource1.DataSource = this.estoquePedidos;
            this.estoquePedidosBindingSource1.Position = 0;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 686);
            this.Controls.Add(this.dtViewPedidos);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPedidos";
            this.Text = "frmPedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquePedidosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.DataGridView dtViewPedidos;
        private System.Windows.Forms.BindingSource estoquePedidosBindingSource;
        private estoquePedidos estoquePedidos;
        private System.Windows.Forms.BindingSource estoquePedidosBindingSource1;
    }
}