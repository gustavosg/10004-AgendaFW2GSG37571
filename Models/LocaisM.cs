#region Referências

using System;
using System.Data.SqlClient;
using Data.DataConnection;
using Data.Util;

#endregion

namespace Data.Models
{
    public class LocaisM : Singleton<LocaisM>
    {
        #region Fields

        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        Log log = Log.GetSingleton();

        #endregion

        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }

        public override String ToString()
        {
            return "Nome: " + this.nome;
        }

        #endregion

        #region Gravações

        /// <summary>
        /// Atualizar um local
        /// </summary>
        /// <returns>Valor bool que informa se foi atualizado com sucesso</returns>
        public Boolean Atualizar()
        {
            String query = "UPDATE LOCAIS SET nome = '" + this.nome + "' WHERE id = '" + this.id + "'";

            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();
                connection.CloseConnection();

                log.Info("Local atualizado: " + this.ToString(), PessoasM.GetSingleton().login);

                return true;
            }
            catch (SqlException ex)
            {
                log.Error(ex.Message, PessoasM.GetSingleton().login);
                throw ex;
            }
        }

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <returns>Valor bool que informa se foi removido com sucesso</returns>
        public Boolean Remover()
        {
            String query = "DELETE FROM LOCAIS WHERE id LIKE '" + this.id + "'";
            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();

                log.Info("Local removido código: " + this.id, PessoasM.GetSingleton().login);

                return true;
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao remover: " + ex.Message, PessoasM.GetSingleton().login);
                throw ex;
            }
        }

        /// <summary>
        /// Insere um novo local no BD
        /// </summary>
        /// <returns>Valor bool que informa se foi inserido com sucesso</returns>
        public Boolean Salvar()
        {
            String query = "INSERT INTO LOCAIS (nome) VALUES ('" + this.nome + "')";

            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();
                connection.CloseConnection();

                log.Info("Local gravado com sucesso: " + this.nome, PessoasM.GetSingleton().login);
                return true;
            }
            catch (SqlException ex)
            {
                log.Error(ex.Message, PessoasM.GetSingleton().login);
                throw ex;
            }
        }

        #endregion

        #region Consultas

        /// <summary>
        /// Retorna todas os locais cadastrados
        /// </summary>
        /// <returns>Relatório de Locais formato SqlDataReader</returns>
        public SqlDataReader ConsultarTodos()
        {
            try
            {
                String query = "SELECT * FROM LOCAIS";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                return comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                log.Error(ex.ToString(), PessoasM.GetSingleton().login);
                throw ex;
            }
        }

        #endregion

    }
}
