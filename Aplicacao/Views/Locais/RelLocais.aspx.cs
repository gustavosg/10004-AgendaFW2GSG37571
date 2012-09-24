#region Referências

using Data.Controller;
using Data.DataConnection;

#endregion

namespace System.Aplicacao.Views.Locais
{
    public partial class RelLocais : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        #region Métodos

        /// <summary>
        /// Page_load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvLocais.DataSource = locais.ConsultarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}