using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacao
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String currentUrl = Request.ServerVariables["SCRIPT_NAME"].ToString().Trim();
            if (!currentUrl.Contains("Login.aspx") && Session.Keys.Count.Equals(0))
                Response.Redirect("~/Account/Login.aspx");
        }
    }
}
