using MySql.Data.MySqlClient;
using Mysqlx;
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
    public class FornecedorDAO
    {
        private MySqlConnection conexao;
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFornecedor
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_fornecedores (nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                               VALUES (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region ListarFornecedores
        public DataTable ListarFornecedores() {
            try
            {
                string sql = "SELECT * FROM tb_fornecedores";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                DataTable tabelaFornecedor = new DataTable();

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor); 

                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region AlterarFornecedor
        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedores SET nome=@nome,
                                                      cnpj=@cnpj,
                                                      email=@email,
                                                      telefone=@telefone,
                                                      celular=@celular,
                                                      cep=@cep,
                                                      endereco=@endereco,
                                                      numero=@numero,
                                                      complemento=@complemento,
                                                      bairro=@bairro,
                                                      cidade=@cidade,
                                                      estado=@estado
                               WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
            }
        }
        #endregion

        #region ExcluirFornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_fornecedores
                           WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
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
