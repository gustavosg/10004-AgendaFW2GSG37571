#region Referências

using Data.Controller;
using Data.DataConnection;
using Data.Util;
using System.Web.UI.WebControls;
using System.Collections.Generic;

#endregion

namespace System.Aplicacao.Views.Locais
{
    public partial class ExcLocais : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        LocaisC locais = LocaisC.GetSingleton();

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
                CarregarGridLocais();
        }

        /// <summary>
        /// Confere quais registros foram selecionados no grid para remover o agendamento.
        /// </summary>
        protected void VerificarCheckBox()
        {
            CheckBox gvRowSelected = new CheckBox();
            GridViewRow rowSelected = null;
            foreach (GridViewRow row in gvLocais.Rows)
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
        /// Exclui um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Excluir_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();

            foreach (Int16 id in ids)
                if (locais.Remover(id))
                    Aviso.Text = "Registro removido!";
                else
                    Aviso.Text = "Houve erro ao remover, favor consultar log!";

        }

        /// <summary>
        /// Popula grade de locais
        /// </summary>
        private void CarregarGridLocais()
        {
            gvLocais.DataSource = locais.ConsultarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}