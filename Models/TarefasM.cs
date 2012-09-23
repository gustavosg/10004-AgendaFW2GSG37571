using System;
using System.Data.SqlClient;
using Data.DataConnection;
using Data.Util;

namespace Data.Models
{
    public class TarefasM : Singleton<TarefasM>
    {
        #region Fields

        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        #endregion

        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }

        #endregion

        #region Gravações

        public Boolean Atualizar()
        {
            try
            {
                String query = "UPDATE TAREFAS SET nome = '" + this.nome + "' WHERE ID = '" + this.id + "'";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                connection.CloseConnection();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Grava uma tarefa no banco de dados
        /// </summary>
        /// <returns>Retorna valor lógico se a gravação foi sucedida</returns>
        public Boolean Salvar()
        {
            try
            {
                String query = "INSERT INTO TAREFAS (nome ) VALUES ('" + this.nome + "')";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                connection.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir()
        {

        }

        public SqlDataReader Consultar()
        {
            String query = "SELECT * FROM TAREFAS WHERE nome LIKE " + this.nome;
            SqlConnection conexao = connection.OpenConnection();
            SqlCommand comando = new SqlCommand(query, conexao);

            SqlDataReader dr = comando.ExecuteReader();

            connection.CloseConnection();

            return dr;

        }

        #endregion

        #region Consultas

        public SqlDataReader ConsultarTodos()
        {
            try
            {
                String query = "SELECT * FROM TAREFAS";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                SqlDataReader dr = comando.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
