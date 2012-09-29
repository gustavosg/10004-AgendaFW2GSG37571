#region Referências

using System;
using System.Data.SqlClient;
using Data.Models;
using Data.Util;

#endregion

namespace Data.Controller
{
    public class PessoasC : Singleton<PessoasC>
    {
        #region Campos

        // Controller
        PessoasM pessoas = PessoasM.GetSingleton();

        #endregion

        #region Consultas

        /// <summary>
        /// Confere se existe o login e senha
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Boolean login(String login, String senha)
        {
            pessoas.login = login;
            pessoas.senha = senha;

            return pessoas.Login();
        }

        /// <summary>
        /// Retorna todas as pessoas cadastradas
        /// </summary>
        /// <returns>Um objeto contendo todos os resultados</returns>
        public SqlDataReader ConsultarTodos()
        {
            return pessoas.ConsultarTodos();
        }

        #endregion

        #region Gravações

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="nome">Nome da pessoa</param>
        /// <param name="login">Login do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <param name="sexo">Sexo</param>
        /// <param name="idade">Idade</param>
        /// <returns>Valor lógico que informa se o registro foi atualizado</returns>
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
        /// <param name="nome">Nome da pessoa</param>
        /// <param name="senha">Senha do usuário</param>
        /// <param name="sexo">Sexo</param>
        /// <param name="idade">Idade</param>
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
        /// <param name="id">Código da pessoa</param>
        /// <returns>Valor lógico que informa se o registro foi removido</returns>
        public Boolean Remover(Int16 id = 0)
        {
            pessoas.id = id;

            return pessoas.Excluir();
        }

        #endregion

    }
}
