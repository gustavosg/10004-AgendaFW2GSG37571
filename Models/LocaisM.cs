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

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <returns>Valor bool que informa se foi removido com sucesso</returns>
        public Boolean Remover()
        {
            String query = "DELETE FROM LOCAIS WHERE id LIKE = '" + this.id + "'";
            try
            {
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

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
                return true;
            }
            catch (Exception ex)
            {
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
