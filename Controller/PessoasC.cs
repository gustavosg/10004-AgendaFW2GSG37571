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
        #region Fields

        PessoasM pessoas = PessoasM.GetSingleton();

        #endregion

        #region Consultas

        /// <summary>
        /// Confere se existe o login e senha
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Boolean login(String nome, String senha)
        {
            pessoas.nome = nome;
            pessoas.senha = senha;

            return pessoas.Login();
        }

        public SqlDataReader ConsultarTodos()
        {
            return pessoas.ConsultarTodos();
        }

        #endregion

        #region Gravações

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <param name="sexo"></param>
        /// <param name="idade"></param>
        /// <returns></returns>
        public Boolean Atualizar(Int16 id, String nome, String login, String senha, Char sexo, Int16 idade)
        {
            pessoas.id = id;
            pessoas.nome = nome;
            pessoas.login = login;
            pessoas.senha = senha;
            pessoas.sexo = sexo;
            pessoas.idade = idade;

            return pessoas.Atualizar();
        }

        /// <summary>
        /// Grava uma nova Pessoa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <param name="sexo"></param>
        /// <param name="idade"></param>
        public Boolean Salvar(String nome, String login, String senha, Char sexo, Int16 idade)
        {
            pessoas.nome = nome;
            pessoas.login = login;
            pessoas.senha = senha;
            pessoas.sexo = sexo;
            pessoas.idade = idade;

            return pessoas.Inserir();
        }

        #endregion

        #region Exclusões

        /// <summary>
        /// Exclui uma pessoa do sistema
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        public Boolean Remover(Int16 id = 0)
        {
            pessoas.id = id;

            return pessoas.Excluir();
        }

        #endregion

    }
}
