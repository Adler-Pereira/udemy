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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO p_dao = new ProdutoDAO();
            tabelaProduto.DataSource = p_dao.listarProdutos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            ProdutoDAO f_dao = new ProdutoDAO();

            obj.descricao = txtdescricao.Text;
            obj.preco = Convert.ToDecimal(txtpreco.Text);
            obj.qtdestoque = Convert.ToInt32(txtqtdestoque.Value);
            obj.for_id = Convert.ToInt32(cbfornecedor.SelectedValue);

            f_dao.cadastrarProduto(obj);

            new Helpers().LimparTela(this);
        }

        private void btnlimpacampos_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
