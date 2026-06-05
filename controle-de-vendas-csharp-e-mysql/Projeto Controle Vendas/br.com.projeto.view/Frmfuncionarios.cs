using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtcomp.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            FuncionarioDAO dao = new FuncionarioDAO();

            obj.codigo = int.Parse(txtcodigo.Text);

            dao.deletarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            FuncionarioDAO dao = new FuncionarioDAO();

            obj.codigo = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            dao.alterarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;
            FuncionarioDAO dao = new FuncionarioDAO();
            
            tabelaFuncionario.DataSource = dao.buscarFuncionarioPorNome(nome);

            if (tabelaFuncionario.Rows.Count == 0 || txtpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado!");
                tabelaFuncionario.DataSource = dao.listarFuncionarios();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";
            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionario.DataSource = dao.listarFuncionarioPorNome(nome);
        }
    }
}
