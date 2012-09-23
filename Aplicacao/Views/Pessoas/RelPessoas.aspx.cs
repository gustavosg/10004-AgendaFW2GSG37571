using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.Util;
using Data.DataConnection;

namespace System.Aplicacao.Views.Pessoas
{
    public partial class RelPessoas : System.Web.UI.Page
    {

        #region fields

        PessoasC pessoas = PessoasC.GetSingleton();
        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            connection.CloseConnection();


        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            Response.Write("oi");
        }

       
    }
}