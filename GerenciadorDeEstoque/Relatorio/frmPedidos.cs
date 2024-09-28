using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Relatorio
{
    public partial class frmPedidos : Form
    {
        DataTable dt = new DataTable(); // Instanciar uma variável do tipo DataTable
        public frmPedidos(DataTable dt) // Recebendo a variável
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmPedidos_Load(object sender, EventArgs e) // Aqui é o método que chama o Report Viewer
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RlPedidos", dt));
            this.reportViewer1.RefreshReport();

        }

        private void dtViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
