using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;

namespace System.Aplicacao.Views.Tarefas
{
    public partial class RelTarefas : System.Web.UI.Page
    {
        #region Fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        TarefasC tarefas = TarefasC.GetSingleton();

        #endregion

        #region Methods

        protected void Page_Load(object sender, EventArgs e)
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection(conexao.OpenConnection());            
        }

        #endregion
    }
}