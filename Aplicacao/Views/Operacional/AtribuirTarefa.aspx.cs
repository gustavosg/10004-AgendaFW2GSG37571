using System.Collections.Generic;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;

namespace System.Aplicacao.Views.Operacional
{
    public partial class AtribuirTarefa : System.Web.UI.Page
    {
        #region Campos

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        TarefasC tarefas = TarefasC.GetSingleton();
        LocaisC locais = LocaisC.GetSingleton();
        PessoasC pessoas = PessoasC.GetSingleton();

        AtribuirTarefaC atribuirTarefas = AtribuirTarefaC.GetSingleton();

        List<Int16> ids = new List<Int16>();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            { }
            else
            {
                CarregarTarefas();
                CarregarLocais();
                CarregarPessoas();
            }
        }

        /// <summary>
        /// Popula a grade de tarefas
        /// </summary>
        private void CarregarTarefas()
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection();
        }

        /// <summary>
        /// Popula a grade de locais
        /// </summary>
        private void CarregarLocais()
        {
            gvLocais.DataSource = locais.ConsultarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection();
        }

        /// <summary>
        /// Popula a grade de pessoas
        /// </summary>
        private void CarregarPessoas()
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection();
        }

        /// <summary>
        /// Confere quais registros foram selecionados no grid para marcar o agendamento.
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
                    
                    //Procura componente Selecionar dentro do Grid, confere se está selecionado
                    gvRowSelected = row.FindControl("cbxSelecionar") as CheckBox;

                    if (gvRowSelected.Checked == true)
                        ids.Add(Convert.ToInt16(rowSelected.Cells[1].Text));
                    else
                        ids.Remove(Convert.ToInt16(rowSelected.Cells[1].Text));
                }
            }
        }

        /// <summary>
        /// Atribui tarefa para as pessoas selecionadas
        /// </summary>
        protected void Atribuir_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();

            foreach (Int16 id in ids)
                if (atribuirTarefas.MarcarTarefas(id, Convert.ToInt16(gvTarefas.SelectedRow.Cells[1].Text),
                        Convert.ToInt16(gvLocais.SelectedRow.Cells[1].Text), data.SelectedDate))
                    Aviso.Text = "Registro gravado com sucesso!";
                else
                    Aviso.Text = "Houve erro ao inserir, favor consultar log!";

            //Fecha conexão
            conexao.CloseConnection();
        }

        #endregion
    }
}