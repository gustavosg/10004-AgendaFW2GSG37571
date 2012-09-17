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
        public DateTime data { get; set; }

        #endregion

        #region Methods

        public void Salvar()
        {

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

            connection.CloseConnection(conexao);

            return dr;

        }

        public SqlDataReader ConsultarTodos()
        {
            String query = "SELECT * FROM TAREFAS";
            SqlConnection conexao = connection.OpenConnection();
            SqlCommand comando = new SqlCommand(query, conexao);

            SqlDataReader dr = comando.ExecuteReader();

            connection.CloseConnection(conexao);

            return dr;
        }

        #endregion
    }
}
