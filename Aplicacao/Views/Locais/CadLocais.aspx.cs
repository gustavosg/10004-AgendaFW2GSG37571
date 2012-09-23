using Data.Controller;

namespace System.Aplicacao.Views.Locais
{
    public partial class CadLocais : System.Web.UI.Page
    {
        #region Campos

        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                nome.Text = String.Empty;
            
        }

        /// <summary>
        /// Salva um novo local
        /// </summary>
        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Equals(String.Empty))
                if (locais.Salvar(nome.Text))
                    Response.Write("Registro salvo");
        }

        #endregion
    }
}