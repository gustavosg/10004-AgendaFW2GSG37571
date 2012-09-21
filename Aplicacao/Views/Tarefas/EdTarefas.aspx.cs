using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;
using Data.DataConnection;
using System.Drawing;

namespace System.Aplicacao.Views.Tarefas
{
    public partial class EdTarefas : System.Web.UI.Page
    {
        #region Fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        TarefasC tarefas = TarefasC.GetSingleton();
        Button button1 = new Button();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarDados();
        }
        
        protected void Editar_Click(object sender, EventArgs e)
        {
            if (gvTarefas.SelectedRow == null)
            {
                Aviso.Text = "É necessário um registro estar selecionado!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
            else
            {
                id.Text = gvTarefas.SelectedRow.Cells[1].Text.Trim();
                nome.Text = HttpUtility.HtmlDecode(gvTarefas.SelectedRow.Cells[2].Text.Trim());
              
            }
        }

        protected void Atualizar_Click(object sender, EventArgs e)
        {
            if (!nome.Text.Trim().Equals(String.Empty))
                if (tarefas.Atualizar(Convert.ToInt16(id.Text), nome.Text))
                    Response.Write("Registro atualizado!");

            ConsultarDados();
        }

        protected void ConsultarDados()
        {
            gvTarefas.DataSource = tarefas.ConsultarTodos();
            gvTarefas.DataBind();

            conexao.CloseConnection(conexao.OpenConnection());
        }
    }
}