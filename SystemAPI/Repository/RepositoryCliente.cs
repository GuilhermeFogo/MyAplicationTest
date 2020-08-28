﻿using Dapper;
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
        }

        public void Deletar(Cliente cliente)
        {
            string sqlcliente = @"delete from Cliente where id_cliente = @id_cliente";
            string sqlendereco = @"delete from Endereco where id_enderenco = @id_endereco";


            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                var clientes = connection.Execute(sqlcliente, cliente.Id);
                var enderecos = connection.Execute(sqlendereco, cliente.endereco.IdEndereco);

                connection.Close();
            }
        }

        public void Salve(Cliente cliente)
        {
            string sequenceCliente = "NEXT VALUE FOR SEQ_Cliente";
            string sequenceEndereco = "NEXT VALUE FOR SEQ_Endereco";
            string sqlcliente = @$"INSERT INTO Cliente(id_cliente, id_endereco, nome, email, telefone) values({sequenceCliente}, @nome, @email,@telefone)";
            string sqlendereco = @$"INSERT INTO Endereco(id_endereco, rua, CEP, estado, cidade, complemento) values({sequenceEndereco}, @rua, @CEP, @estado, @cidade, @complemento)";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                var endereco = connection.QuerySingle<Endereco>(sqlendereco, new
                {
                    cliente.endereco.Rua,
                    cliente.endereco.CEP,
                    cliente.endereco.Estado,
                    cliente.endereco.Cidade,
                    cliente.endereco.Complemento
                });
                connection.Execute(sqlcliente, new { endereco.IdEndereco, cliente.Nome, cliente.Email, cliente.Telefone });

                connection.Close();
            }
        }

        public Cliente PesquisaCliente(int id)
        {
            string sql = @"select * from Clientes where id_cliente =@id";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                var cliente = connection.Query<Cliente>(sql, new { id_cliente = id });
                connection.Close();

                return cliente.FirstOrDefault();
            }

        }

        public IEnumerable<Cliente> PesquisaTodosClientes()
        {
            string sql = @"select * from Clientes";

            using (var connection = new SqlConnection(this.conn))
            {
                connection.Open();
                var cliente = connection.Query<Cliente>(sql);
                connection.Close();

                return cliente;
            }
        }
    }
}
