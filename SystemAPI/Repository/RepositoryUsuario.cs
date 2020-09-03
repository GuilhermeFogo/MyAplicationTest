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
            string sql = @"update Usuarios set nome=@nome, senha =@senha, email =@email, ativado=@ativado where id =@id";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                connection.Query<Usuario>(sql, new 
                { 
                    nome = usuario.Nome,
                    senha = usuario.Senha,
                    email =usuario.Email,
                    ativado =usuario.Ativo,
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
            string sql = @"Insert Into Usuarios(nome, email, senha, ativado) values(@nome,@email,  @senha,@ativo)";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                connection.Execute(sql, new {
                    usuario.Nome,
                    usuario.Email,
                    usuario.Senha,
                    usuario.Ativo
                });

                connection.Close();
            }
        }
    }
}
