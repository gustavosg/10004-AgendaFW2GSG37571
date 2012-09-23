using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Util;
using Data.Models;

namespace Data.Controller
{
    public class AtribuirTarefaC : Singleton<AtribuirTarefaC>
    {
        #region Fields

        AtribuirTarefaM atribuirTarefa = AtribuirTarefaM.GetSingleton();

        #endregion

        #region Metodos

        public void MarcarTarefas(Int16 id, PessoasM pessoas, TarefasM tarefa, LocaisM local, DateTime data)
        {
            atribuirTarefa.id = id;
            atribuirTarefa.id_pessoas = pessoas;
            atribuirTarefa.id_tarefas = tarefa;
            atribuirTarefa.id_locais = local;
            atribuirTarefa.data = data;

            atribuirTarefa.MarcarTarefas();
        }

        #endregion

    }
}
