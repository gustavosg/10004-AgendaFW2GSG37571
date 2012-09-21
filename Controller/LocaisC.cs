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

        #region Gravações

        public Boolean Atualizar(Int16 id, String nome)
        {
            locais.id = id;
            locais.nome = nome;
            return locais.Atualizar();
        }

        public Boolean Salvar(String nome)
        {
            locais.nome = nome;
            return locais.Salvar();
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }

        #endregion

        #region Consultas

        public SqlDataReader PesquisarTodos()
        {
            return locais.ConsultarTodos();
        }

        #endregion


    }
}
