using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;
using Data.Models;
using System.Data.SqlClient;

namespace Data.Controller
{
    public class AtribuirTarefaC : Singleton<AtribuirTarefaC>
    {
        #region Fields

        AtribuirTarefaM atribuirTarefa = AtribuirTarefaM.GetSingleton();

        #endregion

        #region Metodos

        public Boolean MarcarTarefas(Int16 pessoas, Int16 tarefa, Int16 local, DateTime data)
        {
            atribuirTarefa.id_pessoas = pessoas;
            atribuirTarefa.id_tarefas = tarefa;
            atribuirTarefa.id_locais = local;
            atribuirTarefa.data = data;

            return atribuirTarefa.MarcarTarefas();
        }

        #endregion


        public SqlDataReader ConsultarTodos()
        {
            return atribuirTarefa.ConsultarTodos();
        }

        public Boolean RemoverAgendamentos(Int16 id)
        {
            atribuirTarefa.id = id;
            return atribuirTarefa.RemoverAgendamentos();
        }

    }
}
