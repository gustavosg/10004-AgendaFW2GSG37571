using System;
using Data.Models;
using Data.Util;

namespace Data.Controller
{
    public class LocaisC : Singleton<LocaisC>
    {
        LocaisM locais = LocaisM.GetSingleton();

        public void Salvar(Int16 id, String nome)
        {
            if (locais == null){
                locais = new LocaisM();
                locais.id = id;
                locais.nome = nome;
            }
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }
    }
}
