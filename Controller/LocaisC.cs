#region Referências

using System;
using System.Data.SqlClient;
using Data.Models;
using Data.Util;

#endregion

namespace Data.Controller
{
    public class LocaisC : Singleton<LocaisC>
    {
        #region Campos

        // Controller
        LocaisM locais = LocaisM.GetSingleton();

        #endregion

        #region Propriedades

        public String ToString()
        {
            return locais.ToString();
        }

        #endregion

        #region Gravações

        /// <summary>
        /// Atualiza um local cadastrado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <returns>Valor lógico que informa se o cadastro foi atualizado</returns>
        public Boolean Atualizar(Int16 id, String nome)
        {
            locais.id = id;
            locais.nome = nome;
        
            return locais.Atualizar();
        }

        /// <summary>
        /// Salva um novo local
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Valor lógico que informa se o registro foi salvo</returns>
        public Boolean Salvar(String nome)
        {
            locais.nome = nome;
            
            return locais.Salvar();
        }

        /// <summary>
        /// Remove um registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Valor lógico que informa se houve remoção</returns>
        public Boolean Remover(Int16 id )
        {
            locais.id = id;
            
            return locais.Remover();
        }

        #endregion

        #region Consultas

        /// <summary>
        /// Retorna todos os locais registrados
        /// </summary>
        /// <returns>Um objeto SqlDataReader contendo todos os locais</returns>
        public SqlDataReader ConsultarTodos()
        {
            return locais.ConsultarTodos();
        }

        #endregion
    }
}
