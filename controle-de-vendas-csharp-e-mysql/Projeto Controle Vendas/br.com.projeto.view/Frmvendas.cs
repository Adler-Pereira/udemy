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
    public partial class Frmvendas : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        private int qtd;
        private decimal preco;
        private decimal subtotal, total;

        DataTable carrinho = new DataTable();

        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preco", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCpf(txtcpf.Text);

                txtnome.Text = cliente.nome;
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.retornaProdutoPorCodigo(int.Parse(txtcodigo.Text));

                txtdescricao.Text = produto.descricao;
                txtpreco.Value = produto.preco;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtqtd.Text);
            preco = txtpreco.Value;

            subtotal = qtd * preco;

            total += subtotal;

            carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);
            txttotal.Value = total;

            txtcodigo.Clear();
            txtdescricao.Clear();
            txtqtd.Value = 0;
            txtpreco.Value = 0;

            txtcodigo.Focus();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {

        }
    }
}
