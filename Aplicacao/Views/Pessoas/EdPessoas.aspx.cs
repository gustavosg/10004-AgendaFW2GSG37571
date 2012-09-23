using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.DataConnection;
using Data.Controller;
using System.Drawing;

namespace System.Aplicacao.Views.Pessoas
{
    public partial class EdPessoas : System.Web.UI.Page
    {
        #region fields

        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridPessoas();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Editar_Click(object sender, EventArgs e)
        {
            if (gvPessoas.SelectedRow == null)
            {
                Aviso.Text = "É necessário um registro estar selecionado!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
            else
            {
                id.Text = gvPessoas.SelectedRow.Cells[1].Text.Trim();
                nome.Text = HttpUtility.HtmlDecode(gvPessoas.SelectedRow.Cells[2].Text.Trim());
                login.Text = HttpUtility.HtmlDecode(gvPessoas.SelectedRow.Cells[3].Text.Trim());
                switch (gvPessoas.SelectedRow.Cells[4].Text.Trim())
                {
                    case ("M"):
                        {
                            sexo.SelectedValue = "Masculino";
                            break;

                        }
                    case ("F"):
                        {
                            sexo.SelectedValue = "Feminino";
                            break;
                        }
                    default:
                        break;
                }
                idade.Text = gvPessoas.SelectedRow.Cells[5].Text.Trim();
            }
        }

        protected void Atualizar_Click(Object sender, EventArgs e)
        {
            if (nome.Text.Trim().Equals(String.Empty))
                Aviso.Text = "Campo nome não permitido ficar vazio!";

            if (senha.Text.Equals(confirmarSenha.Text) && !senha.Text.Equals(String.Empty))
            {
                if (pessoas.Atualizar(Convert.ToInt16(id.Text), nome.Text, login.Text, senha.Text, sexo.SelectedValue.ToString()[0], Convert.ToInt16(idade.Text)))
                    Response.Write("Registro atualizado!");

                CarregarGridPessoas();
            }
            else
            {
                Aviso.Text = "É necessário informar uma senha!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
        }

        private void CarregarGridPessoas()
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection();
        }

    }
}