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

        public void Excluir(Int16 id = 0, String nome = "")
        {
            if (id != 0)
                tarefas.id = id;

            if (!nome.Equals(String.Empty))
                tarefas.nome = nome;

            tarefas.Excluir();

        }

        public SqlDataReader ConsultarTodos()
        {
            return tarefas.ConsultarTodos();
        }

        public SqlDataReader Consultar(String nome)
        {
            if (tarefas == null)
            {
                tarefas = new TarefasM();
                tarefas.nome = nome;
            }

            return tarefas.Consultar();
        }
        #endregion
    }
}
