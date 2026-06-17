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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastroClientes_Click(object sender, EventArgs e)
        {
            new Frmclientes().ShowDialog();
        }

        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            Frmclientes frmclientes = new Frmclientes();
            frmclientes.tabClientes.SelectedTab = frmclientes.tabPage2;

            frmclientes.ShowDialog();
        }

        private void menuCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            new Frmfuncionarios().ShowDialog();
        }

        private void menuConsultaFuncionarios_Click(object sender, EventArgs e)
        {
            Frmfuncionarios frmfuncionarios = new Frmfuncionarios();
            frmfuncionarios.tabFuncionarios.SelectedTab = frmfuncionarios.tabPage2;

            frmfuncionarios.ShowDialog();
        }

        private void menuCadastroFornecedores_Click(object sender, EventArgs e)
        {
            new Frmfornecedores().ShowDialog();
        }

        private void menuConsultaFornecedores_Click(object sender, EventArgs e)
        {
            Frmfornecedores frmfornecedores = new Frmfornecedores();
            frmfornecedores.tabFornecedores.SelectedTab = frmfornecedores.tabPage2;

            frmfornecedores.ShowDialog();
        }

        private void menuCadastroProdutos_Click(object sender, EventArgs e)
        {
            new Frmprodutos().ShowDialog();
        }

        private void menuConsultaProdutos_Click(object sender, EventArgs e)
        {
            Frmprodutos frmprodutos = new Frmprodutos();
            frmprodutos.tabProdutos.SelectedTab = frmprodutos.tabPage2;

            frmprodutos.ShowDialog();
        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            new Frmvendas().ShowDialog();
        }

        private void menuHistoricoVendas_Click(object sender, EventArgs e)
        {
            new Frmhistorico().ShowDialog();
        }

        private void menuSairSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair da aplicação?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void menuTrocarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Frmlogin().ShowDialog();
        }

        private void menuEstatisticas_Click(object sender, EventArgs e)
        {

        }
    }
}
