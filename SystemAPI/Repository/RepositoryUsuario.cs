using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using SystemAPI.Configuracoes.Interfaces;
using SystemAPI.Modal;
using SystemAPI.Repository.Conexao;
using SystemAPI.Repository.Interfaces;

namespace SystemAPI.Repository
{
    public class RepositoryUsuario : IRepositoryUsuario
    {

        private string conn;
        private readonly IConfiguracao configuracao;
        public RepositoryUsuario(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            this.conn = new MyConexao(configuracao).Conectar();

        }
        public void Alterar(Usuario usuario)
        {
            string sql = @"update Usuarios set nome=@nome, senha =@senha, email =@email, ativado=@ativado, roles=@roles where id =@id";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                connection.Query<Usuario>(sql, new 
                { 
                    nome = usuario.Nome,
                    senha = usuario.Senha,
                    email =usuario.Email,
                    ativado =usuario.Ativado,
                    roles = usuario.Roles,
                    id = usuario.Id
                });

                connection.Close();

            }
        }

        public void Deletar(Usuario usuario)
        {
            string sql = @"delete from Usuarios where id= @id";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                 connection.Query<Usuario>(sql, new { id = usuario.Id});
                connection.Close();
            }
        }

        public IEnumerable<Usuario> PesquisarTodos()
        {
            string sql = @"select * from Usuarios";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                var usuarios = connection.Query<Usuario>(sql);

                connection.Close();

                return usuarios;
            }
        }

        public Usuario PesquisarUser(int id)
        {
            string sql = @"select * from Usuarios where id =@id";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                var usuarios = connection.Query<Usuario>(sql, new { id= id});

                connection.Close();

                return usuarios.FirstOrDefault();
            }
        }

        public void Salve(Usuario usuario)
        {
            string sql = @"Insert Into Usuarios(nome, email, senha, ativado, roles) values(@nome,@email, @senha,@ativado, @roles)";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                connection.Execute(sql, new {
                    usuario.Nome,
                    usuario.Email,
                    usuario.Senha,
                    usuario.Ativado,
                    usuario.Roles
                });

                connection.Close();
            }
        }

        public Usuario LogarUser(string nome, string senha)
        {
            string sql = @"select * from Usuarios where nome =@nome and senha=@senha";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                var usuarios = connection.Query<Usuario>(sql, new { nome = nome, senha = senha });

                connection.Close();

                return usuarios.FirstOrDefault();
            }
        }
    }
}
