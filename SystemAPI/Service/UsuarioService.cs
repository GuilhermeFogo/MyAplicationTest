using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;
using SystemAPI.Repository.Interfaces;
using SystemAPI.Service.Interfaces;

namespace SystemAPI.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepositoryUsuario repositoryUsuario;

        public UsuarioService(IRepositoryUsuario repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        }

        public void Alterar(Usuario usuario)
        {
            this.repositoryUsuario.Alterar(usuario);
        }

        public void Deletar(int id)
        {
            var usuarios = this.repositoryUsuario.PesquisarUser(id);
            this.repositoryUsuario.Deletar(usuarios)
        }

        public IEnumerable<Usuario> PesquisarTodos()
        {
            return this.repositoryUsuario.PesquisarTodos();
        }

        public Usuario PesquisarUser(int id)
        {
            return this.repositoryUsuario.PesquisarUser(id);
        }

        public void Salve(Usuario usuario)
        {
            this.repositoryUsuario.Salve(usuario);
        }
    }
}
