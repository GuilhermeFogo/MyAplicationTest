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

        public void Alterar(UsuarioInput usuario)
        {
            var usu = UsuarioInputTOUsuario(usuario);
            this.repositoryUsuario.Alterar(usu);
        }

        public void Deletar(int id)
        {
            var usuarios = this.repositoryUsuario.PesquisarUser(id);
            this.repositoryUsuario.Deletar(usuarios);
        }

        public IEnumerable<UsuarioInput> PesquisarTodos()
        {
            return UsuarioCollectionTOUsuarioInputCollection(this.repositoryUsuario.PesquisarTodos());
        }

        public UsuarioInput PesquisarUser(int id)
        {
            return UsuarioTOUsuarioInput(this.repositoryUsuario.PesquisarUser(id));
        }

        public void Salve(UsuarioInput usuario)
        {
            var usu = UsuarioInputTOUsuario(usuario);
            this.repositoryUsuario.Salve(usu);
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


        private Usuario UsuarioInputTOUsuario(UsuarioInput usuarioInput)
        {
            return new Usuario(
                id: usuarioInput.id,
                nome: usuarioInput.Nome,
                email: usuarioInput.Email,
                senha: usuarioInput.Senha,
                ativo: usuarioInput.Ativado
                );
        }


        private UsuarioInput UsuarioTOUsuarioInput(Usuario usuarioInput)
        {
            return new UsuarioInput(
                id: usuarioInput.Id,
                nome: usuarioInput.Nome,
                senha: usuarioInput.Senha,
                email: usuarioInput.Email,
                ativo: usuarioInput.Ativado
                );
        }


        public IEnumerable<UsuarioInput> UsuarioCollectionTOUsuarioInputCollection(IEnumerable<Usuario> usuariosList)
        {
            var lista = new List<UsuarioInput>();
            usuariosList.ToList().ForEach(usu => {
                var transform = UsuarioTOUsuarioInput(usu);
                lista.Add(transform);
            });

            return lista;
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
