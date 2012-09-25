#region Referências

using System.Drawing;
using Data.Controller;
using Data.DataConnection;
using Data.Util;

#endregion

namespace System.Aplicacao.Views.Pessoas
{
    public partial class EdPessoas : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controllers
        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridPessoas();
        }

        /// <summary>
        /// Prepara os dados para edição
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
                nome.Text = gvPessoas.SelectedRow.Cells[2].Text.Trim().ConvertStringToHTMLDecode();
                login.Text = gvPessoas.SelectedRow.Cells[3].Text.Trim().ConvertStringToHTMLDecode();
            
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

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Atualizar_Click(Object sender, EventArgs e)
        {
            if (nome.Text.Trim().Equals(String.Empty))
                Aviso.Text = "Campo nome não permitido ficar vazio!";

            if (!senha.Text.Trim().Equals(confirmarSenha.Text.Trim()))
                Aviso.Text = "As senhas devem ser iguais!";

            if (senha.Text.Trim().Equals(confirmarSenha.Text.Trim()) && !senha.Text.Trim().Equals(String.Empty))
            {
                if (pessoas.Atualizar(id.Text.ConvertStringToInt16(), nome.Text.Trim(), login.Text.Trim(), senha.Text.Trim(), sexo.SelectedValue.ToString()[0], idade.Text.ConvertStringToInt16()))
                   Aviso.Text = "Registro atualizado!";

                CarregarGridPessoas();
            }
            else
            {
                Aviso.Text = "É necessário informar uma senha!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
        }

        /// <summary>
        /// Popula a grade de pessoas
        /// </summary>
        private void CarregarGridPessoas()
        {
            gvPessoas.DataSource = pessoas.ConsultarTodos();
            gvPessoas.DataBind();

            conexao.CloseConnection();
        }

        #endregion
    }
}