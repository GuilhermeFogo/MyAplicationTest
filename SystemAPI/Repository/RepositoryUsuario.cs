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
        }

        public void Deletar(Usuario usuario)
        {

        }

        public IEnumerable<Usuario> PesquisarTodos()
        {
            IList<Usuario> listaTeste = new List<Usuario>();
            listaTeste.Add(new Usuario("0","Guilherme","123456789","jfcdsjfs@sdchsaud", true));
            listaTeste.Add(new Usuario("1","Guilherme","123456789","jfcdsjfs@sdchsaud", true));
            listaTeste.Add(new Usuario("2","Guilherme","123456789","jfcdsjfs@sdchsaud", false));
            listaTeste.Add(new Usuario("3","Guilherme","123456789","jfcdsjfs@sdchsaud", false));
            return listaTeste;
        }

        public Usuario PesquisarUser(int id)
        {
            throw new NotImplementedException();
        }

        public void Salve(Usuario usuario)
        {
        }
    }
}
