using System;
using Data.Models;
using Data.Util;

namespace Data.Controller
{
    public class LocaisC : Singleton<LocaisC>
    {
        #region Fields

        LocaisM locais = LocaisM.GetSingleton();

        #endregion

        #region Methods

        public void Salvar(String nome)
        {
            if (locais == null){
                locais = new LocaisM();
                locais.nome = nome;
                locais.InserirBD();
            }
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }

        #endregion
    }
}
