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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            this.carrinho = carrinho;
            this.cliente = cliente;
            this.dataatual = dataatual;
            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                v_dinheiro = txtdinheiro.Value;
                v_cartao = txtcartao.Value;
                total = txttotal.Value;

                totalpago = v_dinheiro + v_cartao;

                if (totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda!");
                }
                else
                {
                    Venda venda = new Venda();
                    VendaDAO v_dao = new VendaDAO();

                    troco = totalpago - total;

                    venda.cliente_id = cliente.codigo;
                    venda.data_venda = dataatual;
                    venda.total_venda = total;
                    venda.obs = txtobs.Text;

                    txttroco.Value = troco;
                    v_dao.cadastrarVenda(venda);

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        ItemVendaDAO i_dao = new ItemVendaDAO();

                        item.venda_id = v_dao.retornaIdUltimaVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        i_dao.cadastrarItem(item);
                    }

                    MessageBox.Show("Venda Finalizada com Sucesso!");
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
    }
}
