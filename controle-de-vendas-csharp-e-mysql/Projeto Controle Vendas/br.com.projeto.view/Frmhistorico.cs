using Projeto_Controle_Vendas.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            VendaDAO vdao = new VendaDAO();

            DateTime datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            DateTime datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            tabelaHistorico.DataSource = vdao.listarVendasPorPeriodo(datainicio, datafim);
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            VendaDAO vdao = new VendaDAO();

            tabelaHistorico.DataSource = vdao.listarVendas();
        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vendaId = Convert.ToInt32(tabelaHistorico.CurrentRow.Cells[0].Value);

            Frmdetalhes frmdetalhes = new Frmdetalhes(vendaId);

            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());

            frmdetalhes.txtdata.Text = dataVenda.ToString("dd/MM/yyyy");
            frmdetalhes.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            frmdetalhes.txttotal.Value = Convert.ToDecimal(tabelaHistorico.CurrentRow.Cells[3].Value);
            frmdetalhes.txtobs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();

            frmdetalhes.ShowDialog();
        }
    }
}
