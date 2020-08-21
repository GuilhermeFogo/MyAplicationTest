using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Deletar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> PesquisarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario PesquisarUser(int id)
        {
            throw new NotImplementedException();
        }

        public void Salve(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
