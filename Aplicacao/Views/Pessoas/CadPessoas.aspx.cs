using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Controller;

namespace System.Aplicacao.Views.Pessoas
{
    public partial class CadPessoas : System.Web.UI.Page
    {

        #region Fields

        PessoasC pessoas = PessoasC.GetSingleton();

        #endregion

        #region Methods

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (senha.Text.Equals(confirmarSenha.Text) && !senha.Text.Equals(String.Empty))
                if (pessoas.Salvar(nome.Text, login.Text, senha.Text, Sexo.SelectedValue.ToString()[0], Convert.ToInt16(idade.Text)))
                    Response.Write("Registro Salvo!");
        }
    }
}