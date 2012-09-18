using Data.Controller;

namespace System.Aplicacao.Views.Pessoas
{
    public partial class CadPessoas : System.Web.UI.Page
    {
        #region Fields
        
        PessoasC pessoas = PessoasC.GetSingleton();
        
        #endregion

        #region Methods

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            pessoas.Salvar(nome.ToString(), Sexo.SelectedValue[0], Convert.ToInt16(idade));
        }

        #endregion
    }
}