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
        public PessoasM id_pessoas { get; set; }
        public TarefasM id_tarefas { get; set; }
        public LocaisM id_locais { get; set; }
        public DateTime data { get; set; }

        #endregion

        #region Gravações

        public Boolean MarcarTarefas()
        {
            List<String> consultas = null;

            consultas.Add("INSERT INTO AGENDAMENTOS (id_pessoas, id_tarefas, id_locais, data) VALUES ('" + this.id_pessoas.id + "','" +
                    this.id_tarefas.id + "', '" + this.id_locais.id + "', '" + this.data + "');");

            try
            {
                SqlConnection conexaoSql = conexao.OpenConnection();
                foreach (var consulta in consultas)
                {
                    SqlCommand comando = new SqlCommand(consulta, conexaoSql);
                    comando.ExecuteNonQuery();
                }

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
