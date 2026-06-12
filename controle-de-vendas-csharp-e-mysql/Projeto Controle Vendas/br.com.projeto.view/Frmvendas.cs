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

                if (cliente != null)
                {
                    txtnome.Text = cliente.nome;
                }
                else
                {
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.retornaProdutoPorCodigo(int.Parse(txtcodigo.Text));

                if (produto != null)
                {
                    txtdescricao.Text = produto.descricao;
                    txtpreco.Value = produto.preco;
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Digite o código do Produto!");
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txttotal.Value = total;

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataatual);
            tela.txttotal.Value = total;

            tela.ShowDialog();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
    }
}
