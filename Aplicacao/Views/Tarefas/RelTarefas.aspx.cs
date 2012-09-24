#region Referências

using Data.Controller;
using Data.DataConnection;

#endregion

namespace System.Aplicacao.Views.Tarefas
{
    public partial class RelTarefas : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        TarefasC tarefas = TarefasC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}