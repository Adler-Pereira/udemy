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
    public partial class Frmdetalhes : Form
    {
        private int vendaId;
        public Frmdetalhes(int vendaId)
        {
            this.vendaId = vendaId;
            InitializeComponent();
        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO ivdao = new ItemVendaDAO();

            tabelaDetalhes.DataSource = ivdao.ListarItensPorVenda(vendaId);
        }
    }
}
