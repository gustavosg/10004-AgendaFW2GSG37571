using System;
using Data.Models;
using Data.Util;
using System.Data.SqlClient;

namespace Data.Controller
{
    public class LocaisC : Singleton<LocaisC>
    {
        #region Fields

        LocaisM locais = LocaisM.GetSingleton();

        #endregion

        #region Methods

        public Boolean Salvar(String nome)
        {
            locais.nome = nome;
            return locais.InserirBD();
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }

        public SqlDataReader PesquisarTodos()
        {
            return locais.ConsultarTodos();
        }

        #endregion

       
    }
}
