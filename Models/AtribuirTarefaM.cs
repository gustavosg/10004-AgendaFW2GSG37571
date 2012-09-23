using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;
using Data.DataConnection;
using System.Data.SqlClient;

namespace Data.Models
{
    public class AtribuirTarefaM : Singleton<AtribuirTarefaM>
    {
        #region Fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        public Int16 id { get; set; }
        public Int16 id_pessoas { get; set; }
        public Int16 id_tarefas { get; set; }
        public Int16 id_locais { get; set; }
        public DateTime data { get; set; }

        #endregion

        #region Gravações

        public Boolean MarcarTarefas()
        {
            String consulta = "INSERT INTO AGENDAMENTOS (id_pessoas, id_tarefas, id_locais, data) VALUES ('" + this.id_pessoas + "','" +
                    this.id_tarefas + "', '" + this.id_locais + "', '" + this.data + "');";

            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                SqlCommand comando = new SqlCommand(consulta, conexaoSql);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Consultas

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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean RemoverAgendamentos()
        {
            String consulta = "DELETE FROM Agendamentos WHERE id = '" + this.id + "'";

            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                SqlCommand comando = new SqlCommand(consulta, conexaoSql);
                
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        #endregion
    }
}
