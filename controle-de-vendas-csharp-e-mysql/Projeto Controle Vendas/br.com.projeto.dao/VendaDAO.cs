using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarVenda
        public void cadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                               VALUES (@cliente_id, @data_venda, @total_venda, @obs);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda Cadastrada com Sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region ListarVendas
        public DataTable listarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT
	                                v.id			AS 'Código',
	                                v.data_venda	AS 'Data da Venda',
	                                c.nome			AS 'Cliente',
	                                v.total_venda	AS 'Total',
	                                v.observacoes	AS 'Obs'
	                           FROM tb_vendas v JOIN tb_clientes c ON (v.cliente_id = c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);
                conexao.Close();

                return tabelaHistorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region RetornaIdUltimaVenda
        public int retornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = @"SELECT MAX(id) id FROM tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                    conexao.Close();
                }

                return idvenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return 0;
            }
        }
        #endregion

        #region ListarVendasPorPeriodo
        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT
	                                v.id			AS 'Código',
	                                v.data_venda	AS 'Data da Venda',
	                                c.nome			AS 'Cliente',
	                                v.total_venda	AS 'Total',
	                                v.observacoes	AS 'Obs'
	                           FROM tb_vendas v JOIN tb_clientes c ON (v.cliente_id = c.id)
	                           WHERE v.data_venda BETWEEN @datainicio AND @datafim;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaHistorico);

                conexao.Close();

                return tabelaHistorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region ListarGastoTotalPorCliente
        public DataTable ListarGastoTotalPorCliente()
        {
            try
            {
                DataTable tabelaVendas = new DataTable();
                string sql = @"SELECT
                                   c.nome AS 'Nome',
                                   SUM(v.total_venda) AS 'Total Gasto'
                                   FROM tb_vendas v JOIN tb_clientes c ON (v.cliente_id = c.id)
                               GROUP BY c.nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                    executacmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                    da.Fill(tabelaVendas);

                conexao.Close();

                return tabelaVendas;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region ListarTotalVendasPorCliente
        public DataTable ListarTotalVendasPorCliente()
        {
            try
            {
                DataTable tabelaVendas = new DataTable();
                string sql = @"SELECT
	                               c.nome AS 'Nome',
	                               COUNT(v.total_venda) AS 'Total de Vendas'
                               FROM tb_vendas v JOIN tb_clientes c ON (v.cliente_id = c.id)
                               GROUP BY c.nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                    executacmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                    da.Fill(tabelaVendas);
                conexao.Close();

                return tabelaVendas;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion
    }
}
