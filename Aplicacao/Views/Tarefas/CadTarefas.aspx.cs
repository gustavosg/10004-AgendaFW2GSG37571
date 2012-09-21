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
    public partial class CadTarefas : System.Web.UI.Page
    {
        #region Fields

        TarefasC tarefas = TarefasC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Trim().Equals(String.Empty))
                if (tarefas.Salvar(nome.Text))
                    Response.Write("Registro Salvo!");

        }
    }
}