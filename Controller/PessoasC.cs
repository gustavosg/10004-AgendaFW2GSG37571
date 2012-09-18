using System;
using System.Data.Sql;
using Data.Models;
using Data.Util;

namespace Data.Controller
{
    public class PessoasC : Singleton<PessoasC>
    {
        PessoasM pessoas = PessoasM.GetSingleton();

        public Boolean login(String nome, String senha)
        {
            pessoas.nome = nome;
            pessoas.senha = senha;

            return pessoas.Login();
        }

        public void Salvar(String nome, Char sexo, Int16 idade)
        {
            if (pessoas == null)
            {
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
