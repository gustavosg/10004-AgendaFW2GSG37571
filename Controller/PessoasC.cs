using System;
using System.Data.Sql;
using Data.Models;
using Data.Util;
using System.Data;
using System.Data.SqlClient;

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

        /// <summary>
        /// Grava uma nova Pessoa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <param name="sexo"></param>
        /// <param name="idade"></param>
        public Boolean Salvar(String nome, String senha, Char sexo, Int16 idade)
        {
            pessoas.nome = nome;
            pessoas.senha = senha;
            pessoas.sexo = sexo;
            pessoas.idade = idade;

            return pessoas.Inserir();

        }

        /// <summary>
        /// Exclui uma pessoa do sistema
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        public void Excluir(Int16 id = 0, String nome = "")
        {
            String option = String.Empty;

            if (id != 0)
            {
                pessoas.id = id;
                option = "id";
            }
            if (!nome.Equals(String.Empty))
            {
                pessoas.nome = nome;
                option = "nome";
            }

            pessoas.Excluir(option);

        }

        public SqlDataReader PesquisarTodos()
        {
            return pessoas.ConsultarTodos();
        }
    }
}
