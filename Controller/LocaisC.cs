using System;
using Data.Models;
using Data.Util;

namespace Data.Controller
{
    public class LocaisC : Singleton<LocaisC>
    {
        LocaisM locais = LocaisM.GetSingleton();

        public void Salvar(String nome)
        {
            if (locais == null){
                locais = new LocaisM();
                locais.nome = nome;
            }
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }
    }
}
