#region Referências

using Data.Controller;

#endregion

namespace System.Aplicacao.Views.Locais
{
    public partial class CadLocais : System.Web.UI.Page
    {
        #region Campos

        // Controller
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
                    Aviso.Text= "Registro salvo";
                else
                    Aviso.Text = "Houve erro ao cadastrar, favor consultar log!";
        }

        #endregion
    }
}