using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;

namespace System.Aplicacao.Views.Locais
{
    public partial class CadLocais : System.Web.UI.Page
    {
        #region fields

        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                nome.Text = String.Empty;

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Equals(String.Empty))
                if (locais.Salvar(nome.Text))
                    Response.Write("Registro salvo");
        }
    }
}