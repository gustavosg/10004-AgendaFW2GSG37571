#region Métodos

using System.Web.Security;
using Data.Controller;
using Data.Util;

#endregion

namespace System.Aplicacao.Account
{
    public partial class Login : System.Web.UI.Page
    {
        #region Campos

        // Controller
        PessoasC pessoas = PessoasC.GetSingleton();

        // Registro de Logs
        Log log = Log.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (pessoas.login(Login1.UserName, Login1.Password))
            {
                Session["username"] = Login1.UserName.ToString().Trim();
                FormsAuthentication.SetAuthCookie(Session["username"].ToString().Trim(), true);
                log.Info("Usuário logado: " + Login1.UserName.Trim(), Login1.UserName.Trim());
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                log.Error("Tentativa de login inválida com o seguinte login: ", Login1.UserName.Trim());
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}
