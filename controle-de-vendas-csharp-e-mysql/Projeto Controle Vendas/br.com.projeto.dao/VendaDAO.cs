using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
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

                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda Cadastrada com Sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
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
    }
}
