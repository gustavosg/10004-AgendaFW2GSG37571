using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.Util;
using System.Web.Security;

namespace System.Aplicacao.Account
{
    public partial class Login : System.Web.UI.Page
    {
        #region Fields

        PessoasC pessoas = new PessoasC();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pessoas.login(Login1.UserName, Login1.Password))
                {
                    Session["username"] = Login1.UserName.ToString().Trim();
                    FormsAuthentication.SetAuthCookie(Session["username"].ToString().Trim(), true);
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Response.Redirect("Account/Login.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
