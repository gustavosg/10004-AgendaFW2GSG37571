using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.DataConnection;
using Data.Controller;

namespace System.Aplicacao.Views.Pessoas
{
    public partial class EdPessoas : System.Web.UI.Page
    {
        #region fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            gvPessoas.DataSource = pessoas.PesquisarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection(conexao.OpenConnection());

        }
    }
}