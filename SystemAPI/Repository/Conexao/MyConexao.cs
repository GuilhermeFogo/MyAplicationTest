using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SystemAPI.Configuracoes.Interfaces;

namespace SystemAPI.Repository.Conexao
{
    public class MyConexao
    {
        private IConfiguracao configuracao;
        private string conn;
        public MyConexao(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            var arquivo = this.configuracao.LerArquivo("appsettings1.json");
            var connectionString = JsonConvert.DeserializeObject<Conn>(arquivo);
            this.conn = connectionString.ConnectionStrings;
        }

        public string Conectar()
        {
            return this.conn;
        }
    }


    class Conn
    {
        public string ConnectionStrings { get; set; }
    }

}
