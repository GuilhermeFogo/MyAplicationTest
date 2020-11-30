using Auth.Modal;
using Auth.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.DTO;
using SystemAPI.Modal;
using SystemAPI.Repository.Interfaces;
using SystemAPI.Service.Interfaces;

namespace SystemAPI.Service
{
    public class UsuarioService : IUsuarioService
    {
        private IAutchUserService autchUserService;
        private readonly IRepositoryUsuario repositoryUsuario;

        public UsuarioService(IRepositoryUsuario repositoryUsuario, IAutchUserService autchUserService)
        {
            this.repositoryUsuario = repositoryUsuario;
            this.autchUserService = autchUserService;
        }

        public void Alterar(Usuario usuario)
        {
            this.repositoryUsuario.Alterar(usuario);
        }

        public void Deletar(int id)
        {
            var usuarios = this.repositoryUsuario.PesquisarUser(id);
            this.repositoryUsuario.Deletar(usuarios);
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


        public string Autenticar(UsuarioDTO usuario)
        {
            var user = this.repositoryUsuario.LogarUser(usuario.Nome, usuario.Senha);

            if (!user.Ativado == false)
            {
                var userAuthOK = UsuarioAuthTOUser(user);
                return this.autchUserService.CriarToken(userAuthOK);
            }
            else
            {
                return null;
            }

        }

        private UsuarioAuth UsuarioAuthTOUser(Usuario user)
        {
            return new UsuarioAuth(
              nome: user.Nome,
              email: user.Email
            );
        }
    }
}
