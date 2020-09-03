using Dapper;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Configuracoes.Interfaces;
using SystemAPI.Modal;
using SystemAPI.Repository.Conexao;
using SystemAPI.Repository.Interfaces;

namespace SystemAPI.Repository
{
    public class RepositoryCliente : IRepositoryCliente
    {
        private string conn;
        private readonly IConfiguracao configuracao;
        public RepositoryCliente(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            this.conn = new MyConexao(configuracao).Conectar();

        }

        public void Alterar(Cliente cliente)
        {
            string sqlcliente = @"update Cliente set nome =@nome, email=@email, telefone =@telefone 
                               where id_cliente = @id_Cliente";
            string sqlendereco = @"update Endereco set rua= @rua, estado = @estado, CEP = @cep, cidade = @cidade, complemento= @complemento 
                        where id_endereco = @IdEndereco";


            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                connection.Execute(sqlcliente.Trim(), new { nome = cliente.Nome, email = cliente.Email, telefone = cliente.Telefone, id_Cliente = cliente.Id_Cliente });
                connection.Execute(sqlendereco.Trim(), new
                {
                    idEndereco = cliente.endereco.Id_Endereco,
                    rua = cliente.endereco.Rua,
                    estado = cliente.endereco.Estado,
                    cep = cliente.endereco.CEP,
                    cidade = cliente.endereco.Cidade,
                    complemento = cliente.endereco.Complemento
                });

                connection.Close();
            }
        }

        public void Deletar(Cliente cliente)
        {
            string sqlcliente = @"delete from Cliente where id_cliente = @id_Cliente";
            string sqlendereco = @"delete from Endereco where id_endereco = @IdEndereco";


            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                connection.Execute(sqlcliente, new { id_Cliente = cliente.Id_Cliente });
                connection.Execute(sqlendereco, new { idEndereco = cliente.endereco.Id_Endereco });

                connection.Close();
            }
        }

        public void Salve(Cliente cliente)
        {
            string sqlcliente = @"INSERT INTO Cliente(id_endereco, nome, email, telefone) values(@IdEndereco, @nome, @email,@telefone)";
            string sqlendereco = @"INSERT INTO Endereco(rua, CEP, estado, cidade, complemento) values(@rua, @CEP, @estado, @cidade, @complemento)";
            string sqlHelper = @"select current_value from sys.sequences where name ='SEQ_Endereco'";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                connection.Execute(sqlendereco, new
                {
                    cliente.endereco.Rua,
                    cliente.endereco.CEP,
                    cliente.endereco.Estado,
                    cliente.endereco.Cidade,
                    cliente.endereco.Complemento
                });
                var id_end = connection.Query<int>(sqlHelper);
                var id = id_end.FirstOrDefault();
                connection.Execute(sqlcliente, new { IdEndereco = id, cliente.Nome, cliente.Email, cliente.Telefone });

                connection.Close();
            }
        }

        public Cliente PesquisaCliente(int id)
        {
            string sql = @"select * from Clientes where id_cliente =@id_cliente";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                var clientes = connection.Query<Cliente, Endereco, Cliente>(sql, (cliente, endereco) =>
                 {
                     cliente.endereco = endereco;
                     return cliente;
                 }, new { id_cliente = id }, splitOn: "id_endereco, rua"
                 ).AsQueryable();
                connection.Close();

                return clientes.FirstOrDefault();
            }

        }

        public IEnumerable<Cliente> PesquisaTodosClientes()
        {
            string sql = @"select * from Clientes";
            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();

                var clientes = connection.Query<Cliente, Endereco, Cliente>(sql, (cliente, endereco) =>
                {
                    cliente.endereco = endereco;
                    return cliente;
                }, splitOn: "id_endereco, rua"
                 ).AsQueryable();

                connection.Close();

                return clientes;
            }
        }

    }
}
