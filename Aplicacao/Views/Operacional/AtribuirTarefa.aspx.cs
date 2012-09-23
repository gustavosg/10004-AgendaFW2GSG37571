using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;
using Data.Models;

namespace System.Aplicacao.Views.Operacional
{
    public partial class AtribuirTarefa : System.Web.UI.Page
    {
        #region Fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        TarefasC tarefas = TarefasC.GetSingleton();
        LocaisC locais = LocaisC.GetSingleton();
        PessoasC pessoas = PessoasC.GetSingleton();
        
        TarefasM tarefaAgendar = TarefasM.GetSingleton();
        LocaisM localAgendar = LocaisM.GetSingleton();
        PessoasM pessoaAgendar = PessoasM.GetSingleton();

        AtribuirTarefaC atribuirTarefas = AtribuirTarefaC.GetSingleton();

        List<Int16> ids = new List<Int16>();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.IsPostBack)
            {

            }
            else
            {
                CarregarTarefas();
                CarregarLocais();
                CarregarPessoas();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CarregarTarefas()
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection();
        }

        private void CarregarLocais()
        {
            gvLocais.DataSource = locais.ConsultarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection();
        }

        private void CarregarPessoas()
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection();

        }

        /// <summary>
        /// 
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
                    gvRowSelected = row.FindControl("cbxSelecionar") as CheckBox;
                }

            }


            if (gvRowSelected.Checked == true)
                cbxSelecionar_CheckedAdd(Convert.ToInt16(rowSelected.Cells[1].Text));
            else
                cbxSelecionar_CheckedRemove(Convert.ToInt16(rowSelected.Cells[1].Text));
        }

        void cbxSelecionar_CheckedAdd(Int16 id)
        {
            ids.Add(id);
        }

        void cbxSelecionar_CheckedRemove(Int16 id)
        {
            ids.Remove(id);
        }

        protected void Atribuir_Click(object sender, EventArgs e)
        {
            VerificarCheckBox();

            foreach (Int16 id in ids)
            {
                //atribuirTarefas.MarcarTarefas(id, pessoas, tarefaAgendar, localAgendar, null);
                
            }
        }

        protected void pessoasSelecionadas()
        {
            //var query = from list in gvPessoas.Rows[0] select list;
            
        }

        protected void gvTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarefaAgendar.id = Convert.ToInt16(gvTarefas.SelectedRow.Cells[1]);
            tarefaAgendar.nome = HttpUtility.HtmlDecode(gvTarefas.SelectedRow.Cells[2].Text);
        }

        protected void gvLocais_SelectedIndexChanged(object sender, EventArgs e)
        {
            localAgendar.id = Convert.ToInt16(gvLocais.SelectedRow.Cells[1]);
            localAgendar.nome = HttpUtility.HtmlDecode(gvLocais.SelectedRow.Cells[2].Text);

        }

    }
}