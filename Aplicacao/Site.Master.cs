#region Referências

using System;
using System.Web.UI.WebControls;
using Data.Util;

#endregion

namespace Aplicacao
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        #region Campos

        // Registro de logs
        Log log = Log.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            String currentUrl = Request.ServerVariables["SCRIPT_NAME"].ToString().Trim();
            if (!currentUrl.Contains("Login.aspx") && Session.Keys.Count.Equals(0))
                Response.Redirect("~/Account/Login.aspx");
        }

        /// <summary>
        /// Ação executada ao efetuar log-off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            log.Info("Usuário desconectado: ", Session["username"].ToString().Trim());   
            Session.Clear();
        }
    }
}
