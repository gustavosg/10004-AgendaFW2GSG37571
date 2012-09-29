#region Referências

using System;
using System.Data.SqlClient;
using Data.DataConnection;
using Data.Util;

#endregion

namespace Data.Models
{
    public class AtribuirTarefaM : Singleton<AtribuirTarefaM>
    {
        #region Campos

        // Utilitário de conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Registro de Logs
        Log log = Log.GetSingleton();

        String usuario = PessoasM.GetSingleton().usuarioLogado;

        #endregion

        #region Propriedades

        public Int16 id { get; set; }
        public Int16 id_pessoas { get; set; }
        public Int16 id_tarefas { get; set; }
        public Int16 id_locais { get; set; }
        public DateTime data { get; set; }

        public override string ToString()
        {
            return "Código da pessoa: " + this.id_pessoas + ", Código da tarefa: " + this.id_tarefas + ", Código do local: " + this.id_locais + ", Data: " + this.data + ".";
        }

        #endregion

        #region Gravações

        /// <summary>
        /// Método que marca tarefas na agenda dos participantes
        /// </summary>
        /// <returns>Valor lógico que informa se a tarefa foi atribuida</returns>
        public Boolean MarcarTarefas()
        {
            String consulta = "INSERT INTO AGENDAMENTOS (id_pessoas, id_tarefas, id_locais, data) VALUES ('" + this.id_pessoas + "','" +
                    this.id_tarefas + "', '" + this.id_locais + "', '" + this.data + "');";

            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                SqlCommand comando = new SqlCommand(consulta, conexaoSql);
                comando.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                log.Error("Erro ao marcar tarefas na agenda! " + ex.Message, usuario);
                throw ex;
            }

            log.Info("Registro gravado com sucesso: " + this.ToString(), usuario);
            return true;
        }

        #endregion

        #region Consultas

        /// <summary>
        /// Retorna todos os registros cadastrados no banco de dados
        /// </summary>
        /// <returns>Um objeto SqlDataReader contendo os registros.</returns>
        public SqlDataReader ConsultarTodos()
        {
            String consulta = "SELECT Ag.id , pe.nome as nome, ta.nome as tarefa, lo.nome as local, data FROM Agendamentos as Ag, Pessoas as Pe, Tarefas as Ta, Locais as Lo where " +
                                "id_pessoas = Pe.id and ta.id = ag.id_tarefas  and lo.id = ag.id_locais";
            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                SqlCommand comando = new SqlCommand(consulta, conexaoSql);

                return comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao consultar: " + ex.Message, usuario);
                throw ex;
            }
        }

        /// <summary>
        /// Remove um agendamento do sistema
        /// </summary>
        /// <returns>Valor lógico que informa se o registro foi removido com sucesso</returns>
        public Boolean RemoverAgendamentos()
        {
            String consulta = "DELETE FROM Agendamentos WHERE id = '" + this.id + "'";

            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                SqlCommand comando = new SqlCommand(consulta, conexaoSql);

                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                log.Error("Erro ao remover: " + ex.Message, usuario);
                throw ex;
            }
            log.Info("Registro removido com sucesso: " + this.id, usuario);
            return true;
        }

        #endregion
    }
}
