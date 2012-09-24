#region Referências

using Data.Controller;

#endregion

namespace System.Aplicacao.Views.Tarefas
{
    public partial class CadTarefas : System.Web.UI.Page
    {
        #region Campos

        // Controller
        TarefasC tarefas = TarefasC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Salva um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Trim().Equals(String.Empty))
                if (tarefas.Salvar(nome.Text.Trim()))
                    Aviso.Text = "Registro Salvo!";
                else
                    Aviso.Text = "Erro ao gravar registro! Favor verificar log!";

        }
    }
}