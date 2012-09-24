using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data.Util;
using Data.Models;
using System.Data.SqlClient;

namespace Data.Controller
{
    public class TarefasC : Singleton<TarefasC>
    {
        #region Fields

        TarefasM tarefas = TarefasM.GetSingleton();

        #endregion

        #region Methods

        public Boolean Atualizar(Int16 id, String nome)
        {
            tarefas.id = id;
            tarefas.nome = nome;
            return tarefas.Atualizar();

        }

        public Boolean Salvar(String nome)
        {
            tarefas.nome = nome;
            return tarefas.Salvar();
        }

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Boolean Remover(Int16 id = 0)
        {
            tarefas.id = id;

            return tarefas.Remover();

        }

        /// <summary>
        /// Retorna todas as tarefas cadastradas
        /// </summary>
        /// <returns>Tarefas cadastradas</returns>
        public SqlDataReader ConsultarTodos()
        {
            return tarefas.ConsultarTodos();
        }

        #endregion
    }
}
