#region Referências

using System.Drawing;
using Data.Controller;
using Data.DataConnection;
using Data.Util;

#endregion

namespace System.Aplicacao.Views.Locais
{
    public partial class EdLocais : System.Web.UI.Page
    {
        #region Campos

        // Conexão
        ConnectionUtil conexao = ConnectionUtil.GetSingleton();

        // Controller
        LocaisC locais = LocaisC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridLocais();
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            if (gvLocais.SelectedRow == null)
                Aviso.Text = "É necessário um registro estar selecionado!";
            else
            {
                id.Text = gvLocais.SelectedRow.Cells[1].Text.Trim();
                nome.Text = gvLocais.SelectedRow.Cells[2].Text.Trim().ConvertStringToHTMLDecode();
            }
        }

        /// <summary>
        /// Atualiza as informações editadas
        /// </summary>
        protected void Atualizar_Click(object sender, EventArgs e)
        {
            if (nome.Text.Equals(gvLocais.SelectedRow.Cells[2].Text.Trim().ConvertStringToHTMLDecode()))
                Aviso.Text = "É necessário informar um novo nome!";
        
            else if(!nome.Text.Equals(String.Empty))
            {
                Aviso.Text = String.Empty;
                if (locais.Atualizar(Convert.ToInt16(id.Text), nome.Text))
                    Aviso.Text = "Registro atualizado!";

                CarregarGridLocais();
            }
            else
            {
                Aviso.Text = "É necessário informar um nome!";
                Aviso.ForeColor = Color.Red;
                Aviso.Font.Size = 14;
            }
        }

        /// <summary>
        /// Popula a grade de locais
        /// </summary>
        private void CarregarGridLocais()
        {
            gvLocais.DataSource = locais.ConsultarTodos();
            gvLocais.DataBind();

            // Fecha conexão
            conexao.CloseConnection();
        }

        #endregion
    }
}