#region Referências

using Data.Controller;
using Data.Util;

#endregion

namespace System.Aplicacao.Views.Locais
{
    public partial class CadLocais : System.Web.UI.Page
    {
        #region Campos
               
        // Controller
        LocaisC locais = LocaisC.GetSingleton();

        //Logs
        Log log = Log.GetSingleton();

        // Variáveis
        String usuario = String.Empty;

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = Session["username"].ToString().Trim();

            if (!this.IsPostBack)
                nome.Text = String.Empty;
        }

        /// <summary>
        /// Salva um novo local
        /// </summary>
        protected void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!nome.Text.Equals(String.Empty))
                    if (locais.Salvar(nome.Text))
                    {
                        Aviso.Text = "Registro salvo";
                        log.Info("Local inserido no sistema: " + locais.ToString(), usuario);
                    }
                    else
                    {
                        Aviso.Text = "É necessário um nome para cadastrar um novo local!";
                        log.Info("Não foi possível inserir um novo local pois não foi informado o nome.", usuario);
                    }
            }
            catch (Exception ex)
            {
                log.Error("Erro ao realizar operação: " + ex.Message, usuario);
            }
        }

        #endregion
    }
}