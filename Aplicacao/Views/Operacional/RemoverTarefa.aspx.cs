using System.Collections.Generic;
using System.Web.UI.WebControls;
using Data.DataConnection;
using Data.Controller;

namespace System.Aplicacao.Views.Operacional
{
    public partial class RemoverTarefa : System.Web.UI.Page
    {
        #region Campos

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        AtribuirTarefaC atribuirTarefa = AtribuirTarefaC.GetSingleton();

        List<Int16> ids = new List<Int16>();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                CarregarTarefasAtribuidas();
            }
            else
            { }
        }

        /// <summary>
        /// Carrega informações para a grade de Tarefas
        /// </summary>
        private void CarregarTarefasAtribuidas()
        {
            gvTarefasAtribuidas.DataSource = atribuirTarefa.ConsultarTodos();
            gvTarefasAtribuidas.DataBind();

            conexao.CloseConnection();
        }

        /// <summary>
        /// Confere quais registros foram selecionados no grid para remover o agendamento.
        /// </summary>
        protected void VerificarCheckBox()
        {
            CheckBox gvRowSelected = new CheckBox();
            GridViewRow rowSelected = null;
            foreach (GridViewRow row in gvTarefasAtribuidas.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    rowSelected = row;

                    // Procura componente Selecionar dentro do Grid, confere se está selecionado
                    gvRowSelected = row.FindControl("cbxSelecionar") as CheckBox;

                    if (gvRowSelected.Checked == true)
                        ids.Add(Convert.ToInt16(rowSelected.Cells[1].Text));
                    else
                        ids.Remove(Convert.ToInt16(rowSelected.Cells[1].Text));
                }
            }
        }

        /// <summary>
        /// Remove todos os registros selecionados
        /// </summary>
        protected void Remover_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();
            foreach (var id in ids)
                if (atribuirTarefa.RemoverAgendamentos(Convert.ToInt16(id)))
                    Aviso.Text = "Registro removido!";
                else
                    Aviso.Text = "Houve erro ao remover, favor consultar log!";

            // Fecha Conexão
            conexao.CloseConnection();
        }
        #endregion
    }
}