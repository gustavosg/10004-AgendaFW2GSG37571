#region Referências

using System.Drawing;
using System.Web;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;
using Data.Util;

#endregion

namespace System.Aplicacao.Views.Tarefas
{
    public partial class EdTarefas : System.Web.UI.Page
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
            ConsultarDados();
        }
        
        /// <summary>
        /// Prepara dados para edição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Editar_Click(object sender, EventArgs e)
        {
            if (gvTarefas.SelectedRow == null)
                Aviso.Text = "É necessário um registro estar selecionado!";
            else
            {
                id.Text = gvTarefas.SelectedRow.Cells[1].Text.Trim();
                nome.Text = gvTarefas.SelectedRow.Cells[2].Text.Trim().ConvertStringToHTMLDecode();
            }
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Atualizar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Trim().Equals(String.Empty))
                if (tarefas.Atualizar(Convert.ToInt16(id.Text), nome.Text))
                    Response.Write("Registro atualizado!");

            ConsultarDados();
        }

        /// <summary>
        /// Popula grade de tarefas
        /// </summary>
        protected void ConsultarDados()
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}