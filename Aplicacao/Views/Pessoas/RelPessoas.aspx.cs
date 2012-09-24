#region Referências

using Data.Controller;
using Data.DataConnection;

#endregion

namespace System.Aplicacao.Views.Pessoas
{
    public partial class RelPessoas : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil connection = ConnectionUtil.GetSingleton();

        // Controller
        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            connection.CloseConnection();
        }

        #endregion
    }
}