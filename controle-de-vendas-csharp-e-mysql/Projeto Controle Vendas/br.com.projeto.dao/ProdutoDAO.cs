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

        #region ListarProdutos
        public DataTable listarProdutos()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT
	                               p.id AS 'Código',
	                               p.descricao AS 'Descrição',
                                   p.preco AS 'Preço',
                                   p.qtd_estoque AS 'Qtd Estoque',
                                   f.nome AS 'Fornecedor'
                               FROM tb_produtos p JOIN tb_fornecedores f ON (p.for_id = f.id);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region AlterarProduto
        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"UPDATE tb_produtos SET descricao=@descricao,
                                                      preco=@preco,
                                                      qtd_estoque=@qtdestoque,
                                                      for_id=@for_id
                               WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtdestoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
            }
        }
        #endregion

        #region ExcluirProduto
        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_produtos
                               WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluído com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
            }
        }
        #endregion

        #region ListarProdutosPorNome
        public DataTable listarProdutosPorNome(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT
	                               p.id AS 'Código',
	                               p.descricao AS 'Descrição',
                                   p.preco AS 'Preço',
                                   p.qtd_estoque AS 'Qtd Estoque',
                                   f.nome AS 'Fornecedor'
                               FROM tb_produtos p JOIN tb_fornecedores f ON (p.for_id = f.id)
                               WHERE p.descricao like @descricao;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region BuscarProdutosPorNome
        public DataTable buscarProdutosPorNome(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT
	                               p.id AS 'Código',
	                               p.descricao AS 'Descrição',
                                   p.preco AS 'Preço',
                                   p.qtd_estoque AS 'Qtd Estoque',
                                   f.nome AS 'Fornecedor'
                               FROM tb_produtos p JOIN tb_fornecedores f ON (p.for_id = f.id)
                               WHERE p.descricao = @descricao;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion
    }
}
