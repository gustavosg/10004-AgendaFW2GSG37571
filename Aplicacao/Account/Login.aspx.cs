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
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }


       
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //Response.Write(pessoas.login(nome.Text, senha.Text));
            if (pessoas.login(Login1.UserName, Login1.Password))
            {
                FormsAuthentication.SetAuthCookie("username", true);
                
                RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);

            }
        }

    }
}
