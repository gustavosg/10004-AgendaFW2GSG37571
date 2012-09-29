#region Referências

using System;
using System.Data.SqlClient;
using Data.DataConnection;
using Data.Util;

#endregion

namespace Data.Models
{
    public class TarefasM : Singleton<TarefasM>
    {
        #region Campos

        // Conexão
        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        // Log do sistema
        Log log = Log.GetSingleton();

        // Usuário logado, que realiza as tarefas do sistema
        String usuario = PessoasM.GetSingleton().usuarioLogado;

        #endregion

        #region Propriedades

        public Int16 id { get; set; }
        public String nome { get; set; }

        public override string ToString()
        {
            return "Tarefa: " + this.nome + ".";
        }

        #endregion

        #region Gravações

        /// <summary>
        /// Atualiza um registro existente
        /// </summary>
        /// <returns>Retorna valor lógico informando se foi atualizado ou não</returns>
        public Boolean Atualizar()
        {
            try
            {
                String query = "UPDATE TAREFAS SET nome = '" + this.nome + "' WHERE ID = '" + this.id + "'";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();

                connection.CloseConnection();

                log.Info("Registro atualizado com sucesso: " + this.ToString(), usuario);
                return true;
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao atualizar: " + ex.Message, usuario);
                throw ex;
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
            }
            catch (SqlException ex)
            {
                log.Error("Exceção ao salvar tarefa: " + ex.Message, usuario);
                throw ex;
            }

            log.Info("Tarefa salva: " + this.ToString(), usuario);

            return true;
        }

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <returns>Valor booleano que informa se foi excluído</returns>
        public Boolean Remover()
        {
            try
            {
                String query = "DELETE FROM TAREFAS WHERE id LIKE '" + this.id + "'";
                SqlConnection conexao = connection.OpenConnection();
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                log.Error("Exceção ao remover tarefa: " + ex.Message, usuario);
                throw ex;
            }
            
            log.Info("Registro removido: " + this.ToString(), usuario);

            return true;
        }

        #endregion

        #region Consultas

        /// <summary>
        /// Consulta Tarefas
        /// </summary>
        /// <returns>Retorna todas as tarefas cadastradas</returns>
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
            catch (SqlException ex)
            {
                log.Error("Exceção ao consultar dados! " + ex.Message, usuario);
                throw ex;
            }
        }

        #endregion
    }
}
