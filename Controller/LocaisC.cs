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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Boolean Remover(Int16 id )
        {
            locais.id = id;
            return locais.Remover();

        }

        #endregion

        #region Consultas

        public SqlDataReader ConsultarTodos()
        {
            return locais.ConsultarTodos();
        }

        #endregion


    }
}
