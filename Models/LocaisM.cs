using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;
using System.Data.SqlClient;
using Data.DataConnection;

namespace Data.Models
{
    public class LocaisM : Singleton<LocaisM>
    {
        #region Fields

        ConnectionUtil connection = ConnectionUtil.GetSingleton();
        #endregion

        #region Properties

        public Int16 id { get; set; }
        public String nome { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Insere um novo local no BD
        /// </summary>
        /// <returns>Valor bool que informa se foi inserido com sucesso</returns>
        public Boolean InserirBD()
        {
            String query = "INSERT INTO LOCAIS (nome) VALUES ('"+ this.nome + "')";

            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();
                connection.CloseConnection(conexao);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna todas os locais cadastrados
        /// </summary>
        /// <returns>Relatório de Locais formato SqlDataReader</returns>
        public SqlDataReader ConsultarTodos()
        {
            SqlDataReader dr;

            try
            {
                String query = "SELECT * FROM LOCAIS";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                dr = comando.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }

            return dr;
        }

        #endregion

    }
}
