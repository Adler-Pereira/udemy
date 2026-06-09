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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarProduto
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_produtos (descricao, preco, qtd_estoque, for_id)
                               VALUES (@descricao, @preco, @qtdestoque, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtdestoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto inserido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
            }
        }
        #endregion
    }
}
