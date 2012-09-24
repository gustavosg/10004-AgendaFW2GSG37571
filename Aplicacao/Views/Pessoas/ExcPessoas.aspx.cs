#region Referencias

using Data.Controller;
using Data.DataConnection;
using Data.Util;
using System.Web.UI.WebControls;
using System.Collections.Generic;

#endregion

namespace System.Aplicacao.Views.Pessoas
{
    public partial class ExcPessoas : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        PessoasC pessoas = PessoasC.GetSingleton();

        // Variáveis
        List<Int16> ids = new List<Int16>();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {

            }
            else
            {
                CarregarGridPessoas();
            }
        }

        /// <summary>
        /// Popula grade de pessoas
        /// </summary>
        private void CarregarGridPessoas()
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection();
        }

        /// <summary>
        /// Confere quais registros foram selecionados no grid para remover o agendamento.
        /// </summary>
        protected void VerificarCheckBox()
        {
            CheckBox gvRowSelected = new CheckBox();
            GridViewRow rowSelected = null;
            foreach (GridViewRow row in gvPessoas.Rows)
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
        /// Exclui registros selecionados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Excluir_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();

            foreach (Int16 id in ids)
                if (pessoas.Remover(id))
                    Aviso.Text = "Registro removido!";
                else
                    Aviso.Text = "Houve erro ao remover, favor consultar log!";

            CarregarGridPessoas();
        }

        #endregion
    }
}