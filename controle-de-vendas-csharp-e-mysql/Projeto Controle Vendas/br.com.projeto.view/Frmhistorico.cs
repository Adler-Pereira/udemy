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
    }
}
