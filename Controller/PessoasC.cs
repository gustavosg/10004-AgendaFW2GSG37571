using System;
using Data.Models;
using Data.Util;

namespace Data.Controller
{
    public class PessoasC : Singleton<PessoasC>
    {
        PessoasM pessoas = PessoasM.GetSingleton();

        public void Salvar(String nome, Char sexo, Int16 idade)
        {
            if (pessoas == null){
                pessoas = new PessoasM();
                
                pessoas.nome = nome;
                pessoas.sexo = sexo;
                pessoas.idade = idade;
            }
        }

        public void Excluir(Int16 id = 0, String nome = "")
        {

        }
    }
}
