#region Referências

using System.Collections.Generic;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;
using Data.Util;

#endregion

namespace System.Aplicacao.Views.Tarefas
{
    public partial class ExcTarefas : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        TarefasC tarefas = TarefasC.GetSingleton();

        // Variáveis
        List<Int16> ids = new List<Int16>();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            { }
            else
                CarregarGridTarefas();
        }

        /// <summary>
        /// Confere quais registros foram selecionados no grid para remover o agendamento.
        /// </summary>
        protected void VerificarCheckBox()
        {
            CheckBox gvRowSelected = new CheckBox();
            GridViewRow rowSelected = null;
            foreach (GridViewRow row in gvTarefas.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    rowSelected = row;

                    // Procura componente Selecionar dentro do Grid, confere se está selecionado
                    gvRowSelected = row.FindControl("cbxSelecionar") as CheckBox;

                    if (gvRowSelected.Checked == true)
                        ids.Add(Convert.ToInt16(rowSelected.Cells[1].Text.ConvertStringToInt16()));
                    else
                        ids.Remove(Convert.ToInt16(rowSelected.Cells[1].Text.ConvertStringToInt16()));
                }
            }
        }

        /// <summary>
        /// Remove registros selecionados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Remover_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();

            foreach (Int16 id in ids)
                if (tarefas.Remover(id))
                    Aviso.Text = "Registro removido!";
                else
                    Aviso.Text = "Houve erro ao remover, favor consultar log!";

            CarregarGridTarefas();
        }

        /// <summary>
        /// Popula grade de tarefas
        /// </summary>
        private void CarregarGridTarefas()
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}