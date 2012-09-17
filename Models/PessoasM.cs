using System;
using Data.Util;
using Data.DataConnection;
using System.Data.SqlClient;


namespace Data.Models
{
    public class PessoasM : Singleton<PessoasM>
    {
        #region Fields

        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        #endregion


        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }
        public Char sexo { get; set; }
        public Int16 idade { get; set; }

        #endregion

        #region Methods

        public void Inserir()
        {
            String query = "INSERT INTO PESSOAS (nome, sexo, idade) VALUES (" + this.nome + ", " + this.sexo + ", " + this.idade + ")";
            SqlConnection conexao = connection.OpenConnection();
            SqlCommand comando = new SqlCommand(query, conexao);

            connection.CloseConnection(conexao);

        }

        public void Excluir(String option)
        {
            String query = String.Empty;
            if (option.Equals(""))
                query = "DELETE FROM PESSOAS WHERE ID LIKE (" + this.id + ")";
            else
                query = "DELETE FROM PESSOAS WHERE nome LIKE (" + this.nome + ")";
            SqlConnection conexao = connection.OpenConnection();
            SqlCommand comando = new SqlCommand(query, conexao);

            connection.CloseConnection(conexao);
        }

        #endregion
    }
}
