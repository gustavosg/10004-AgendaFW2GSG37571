using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;

namespace System.Aplicacao.Views.Locais
{
    public partial class RelLocais : System.Web.UI.Page
    {
        #region Fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        #region Methods

        /// <summary>
        /// Page_load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvLocais.DataSource = locais.PesquisarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection(conexao.OpenConnection());



        }

        #endregion
    }
}