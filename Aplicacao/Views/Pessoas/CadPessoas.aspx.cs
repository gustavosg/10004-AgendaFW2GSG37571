#region Referências

using Data.Controller;

#endregion

namespace System.Aplicacao.Views.Pessoas
{
    public partial class CadPessoas : System.Web.UI.Page
    {
        #region Campos

        // Controller
        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        #region Métodos

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Salva um registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (senha.Text.Equals(confirmarSenha.Text) && !senha.Text.Equals(String.Empty))
                if (pessoas.Salvar(nome.Text, login.Text, senha.Text, Sexo.SelectedValue.ToString()[0], Convert.ToInt16(idade.Text)))
                    Aviso.Text = "Registro Salvo!";
                else
                    Aviso.Text = "Erro ao gravar registro! Favor verificar log!";
        }

        #endregion
    }
}