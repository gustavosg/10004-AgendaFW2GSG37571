#region References

using System;
using Data.Util;
using Data.DataConnection;
using System.Data.SqlClient;

#endregion

namespace Data.Models
{
    public class PessoasM : Singleton<PessoasM>
    {
        #region Campos

        // Conexão
        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        // Registro de Log
        Log log = Log.GetSingleton();

        #endregion

        #region Propriedades

        public Int16 id { get; set; }
        public String nome { get; set; }
        public String login { get; set; }
        public String senha { get; set; }
        public Char sexo { get; set; }
        public Int16 idade { get; set; }
        public String usuarioLogado { get; set; }

        public override String ToString()
        {
            return "Nome: " + this.nome + ", login: " + this.login + ".";
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Efetua login do sistema
        /// </summary>
        /// <returns>Informa se há um usuário e senha registrados</returns>
        public Boolean Login()
        {
            String query = "SELECT * FROM PESSOAS WHERE login = '" + this.login + "' AND senha = '" + this.senha + "'";
            Boolean hasUser = false;

            try
            {
                SqlConnection connectionSql = connection.OpenConnection();

                SqlCommand command = new SqlCommand(query, connectionSql);
                SqlDataReader dr = command.ExecuteReader();
                hasUser = dr.HasRows;

                connection.CloseConnection();

                if (hasUser)
                    usuarioLogado = login;

            }
            catch (SqlException ex)
            {
                log.Error("Erro ao efetuar login com o seguinte login: " + this.login + ". Mensagem de erro: " + ex.Message, this.usuarioLogado);
                throw ex;
            }

            log.Info("Usuario logado: " + this.ToString(), this.login);
            return hasUser;
        }

        /// <summary>
        /// Insere um novo registro
        /// </summary>
        /// <returns></returns>
        public Boolean Inserir()
        {
            String query = "INSERT INTO PESSOAS (nome, login, senha, sexo, idade) VALUES ('"
                + this.nome + "', '" + this.login + "', '" + this.senha + "', '" + this.sexo + "', '" + this.idade + "')";

            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();
                connection.CloseConnection();

                log.Info("Pessoa cadastrada com sucesso: " + this.ToString(), this.usuarioLogado);
                return true;
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao cadastrar: " + ex.Message, this.usuarioLogado);
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza um registro de pessoa
        /// </summary>
        /// <returns>Valor lógico que informa se teve sucesso.</returns>
        public Boolean Atualizar()
        {
            try
            {
                String query = "UPDATE PESSOAS SET nome = '" + this.nome + "', login = '" + this.login + "', senha = '" + this.senha + "',  sexo = '" + this.sexo + "', idade = '" + this.idade + "' WHERE id LIKE '" + this.id + "'";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                connection.CloseConnection();
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao atualizar: " + ex.Message, this.usuarioLogado);
                throw ex;
            }

            log.Info("Registro atualizado com sucesso: " + this.ToString(), this.usuarioLogado);
            return true;
        }

        /// <summary>
        /// Exclui um registro
        /// </summary>
        /// <returns>Retorna um valor lógico que informa se o registro foi excluído com sucesso</returns>
        public Boolean Excluir()
        {
            try
            {
                String query = "DELETE FROM PESSOAS WHERE ID LIKE ('" + this.id + "')";

                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao excluir registro: " + ex.Message, this.usuarioLogado);
                throw ex;
            }

            log.Info("Registro removido com sucesso: " + this.ToString(), this.usuarioLogado);
            return true;
        }

        /// <summary>
        /// Retorna todas as pessoas cadastradas
        /// </summary>
        /// <returns>Relatório de Pessoas formato SqlDataReader</returns>
        public SqlDataReader ConsultarTodos()
        {
            SqlDataReader dataReader;

            try
            {
                String query = "SELECT * FROM PESSOAS";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                dataReader = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao consultar registros! " + ex.Message, this.usuarioLogado);
                throw;
            }

            return dataReader;
        }

        #endregion
    }
}
