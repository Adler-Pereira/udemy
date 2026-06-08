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
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = string.Format("https://viacep.com.br/ws/{0}/xml/", cep);

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtcomp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Localização não encontrada. Por favor, preencha os campos manualmente.");
            }
        }

        private void btnlimpacampos_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            FornecedorDAO dao = new FornecedorDAO();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            dao.cadastrarFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.listarFornecedores();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            Fornecedor obj = new Fornecedor();
            FornecedorDAO dao = new FornecedorDAO();

            obj.codigo = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            dao.alterarFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtcomp.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tabFornecedores.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            FornecedorDAO dao = new FornecedorDAO();

            obj.codigo = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            dao.excluirFornecedor(obj);

            tabelaFornecedor.DataSource = dao.listarFornecedores();
            new Helpers().LimparTela(this);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0 || txtpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                tabelaFornecedor.DataSource = dao.listarFornecedores();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";
            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.listarFornecedorPorNome(nome);
        }
    }
}
