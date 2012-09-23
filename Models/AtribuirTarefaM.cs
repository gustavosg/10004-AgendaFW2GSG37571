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
            String consulta = "INSERT INTO AGENDAMENTOS (id_pessoas, id_tarefas, id_locais, data) VALUES ('" + this.id_pessoas + "','" +
                    this.id_tarefas + "', '" + this.id_locais + "', '" + this.data + "')";

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
