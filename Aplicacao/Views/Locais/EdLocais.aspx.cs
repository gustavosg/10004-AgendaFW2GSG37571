using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.DataConnection;
using Data.Controller;
using System.Drawing;

namespace System.Aplicacao.Views.Locais
{
    public partial class EdLocais : System.Web.UI.Page
    {
        #region fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridLocais();
        }



        protected void Editar_Click(object sender, EventArgs e)
        {
            if (gvLocais.SelectedRow == null)
            {
                Aviso.Text = "É necessário um registro estar selecionado!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
            else
            {
                id.Text = gvLocais.SelectedRow.Cells[1].Text.Trim();
                nome.Text = HttpUtility.HtmlDecode(gvLocais.SelectedRow.Cells[2].Text.Trim());
            }
        }

        protected void Atualizar_Click(object sender, EventArgs e)
        {
            if (nome.Text.Equals(HttpUtility.HtmlDecode(gvLocais.SelectedRow.Cells[2].Text.Trim())))
            {
                Aviso.Text = "É necessário informar um novo nome!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 12;
            }
            else if(!nome.Text.Equals(String.Empty))
            {
                Aviso.Text = String.Empty;
                if (locais.Atualizar(Convert.ToInt16(id.Text), nome.Text))
                    Response.Write("Registro atualizado!");

                CarregarGridLocais();
            }
            else
            {
                Aviso.Text = "É necessário informar um nome!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
        }

        private void CarregarGridLocais()
        {
            gvLocais.DataSource = locais.PesquisarTodos();
            gvLocais.DataBind();

            conexao.CloseConnection(conexao.OpenConnection());
        }
    }
}