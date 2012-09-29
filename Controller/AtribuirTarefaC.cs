#region Referências

using System;
using System.Data.SqlClient;
using Data.Models;
using Data.Util;

#endregion

namespace Data.Controller
{
    public class AtribuirTarefaC : Singleton<AtribuirTarefaC>
    {
        #region Campos

        AtribuirTarefaM atribuirTarefa = AtribuirTarefaM.GetSingleton();

        #endregion

        #region Metodos

        /// <summary>
        /// Marca tarefas na agenda para a pessoa escolhida
        /// </summary>
        /// <param name="pessoas">Dados da pessoa</param>
        /// <param name="tarefa">Tarefa selecionada</param>
        /// <param name="local">Local selecionado</param>
        /// <param name="data">Data informada</param>
        /// <returns>Retorna valor lógico que informa se foi marcado tarefa</returns>
        public Boolean MarcarTarefas(Int16 pessoas, Int16 tarefa, Int16 local, DateTime data)
        {
            atribuirTarefa.id_pessoas = pessoas;
            atribuirTarefa.id_tarefas = tarefa;
            atribuirTarefa.id_locais = local;
            atribuirTarefa.data = data;

            return atribuirTarefa.MarcarTarefas();
        }

        #endregion

        /// <summary>
        /// Retorna todas as tarefas atribuídas
        /// </summary>
        /// <returns>Tarefas atribuídas</returns>
        public SqlDataReader ConsultarTodos()
        {
            return atribuirTarefa.ConsultarTodos();
        }

        /// <summary>
        /// Remove agendamentos
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Valor lógico que informa se o registro foi removido</returns>
        public Boolean RemoverAgendamentos(Int16 id)
        {
            atribuirTarefa.id = id;
            return atribuirTarefa.RemoverAgendamentos();
        }
    }
}
