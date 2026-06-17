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
    public partial class Frmestatisticas : Form
    {
        public Frmestatisticas()
        {
            InitializeComponent();
        }

        private void Frmestatisticas_Load(object sender, EventArgs e)
        {

            VendaDAO vdao = new VendaDAO();

            chartEstatisticas.DataSource = vdao.ListarGastoTotalPorCliente();
            chartEstatisticas.Series["Total Gasto"].XValueMember = "Nome";
            chartEstatisticas.Series["Total Gasto"].YValueMembers = "Total Gasto";
        }
    }
}
