﻿#region References

using System;
using Data.Util;
using Data.DataConnection;
using System.Data.SqlClient;

#endregion

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
        public String login { get; set; }
        public String senha { get; set; }
        public Char sexo { get; set; }
        public Int16 idade { get; set; }

        #endregion

        #region Methods

        public Boolean Login()
        {

            String query = "SELECT * FROM PESSOAS WHERE nome = '" + this.nome + "'  AND senha = '" + this.senha + "'";
            Boolean teste = false;

            try
            {
                SqlConnection conexao = connection.OpenConnection();

                SqlCommand comando = new SqlCommand(query, conexao);
                SqlDataReader dr = comando.ExecuteReader();
                teste = dr.HasRows;

                connection.CloseConnection(conexao);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return teste;
        }

        public Boolean Inserir()
        {
            String query = "INSERT INTO PESSOAS (nome, login, senha, sexo, idade) VALUES ('"
                + this.nome + "', '" + this.login + "', '" + this.senha + "', '" + this.sexo + "', '" + this.idade + "')";

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
        /// Atualiza um registro de pessoa
        /// </summary>
        /// <returns>Valor lógico que informa se teve sucesso.</returns>
        public Boolean Atualizar()
        {
            try
            {
                String query = "UPDATE PESSOAS SET nome = '" + this.nome + "', login = '" + this.login + "', senha = '"+ this.senha + "',  sexo = '" + this.sexo + "', idade = '" + this.idade + "' WHERE id LIKE '" + this.id + "'";
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

        /// <summary>
        /// Retorna todas as pessoas cadastradas
        /// </summary>
        /// <returns>Relatório de Pessoas formato SqlDataReader</returns>
        public SqlDataReader ConsultarTodos()
        {
            SqlDataReader dr;

            try
            {
                String query = "SELECT * FROM PESSOAS";
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
