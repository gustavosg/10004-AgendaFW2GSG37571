using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Util;


namespace System.Aplicacao.Views.RegistroLogs
{
    public partial class ExibirLog : System.Web.UI.Page
    {
        #region Campos

        LogFile logFile = LogFile.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Logs.Text = logFile.LogReader();    
        }
    }
}