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
            bool verdade = ValidacaoUser(usu);
            if (verdade)
            {
                this.repositoryUsuario.Alterar(usu);
            }
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
            bool verdade = ValidacaoUser(usu);
            if (verdade)
            {
                this.repositoryUsuario.Salve(usu);
            }
        }


        public string Autenticar(UsuarioDTO usuario)
        {
            var user = this.repositoryUsuario.LogarUser(usuario.Nome, usuario.Senha);

            if (user != null)
            {
                if (user.Ativado == true)
                {
                    var userAuthOK = UsuarioAuthTOUser(user);
                    return this.autchUserService.CriarToken(userAuthOK);
                }
            }
            return "";

        }


        private Usuario UsuarioInputTOUsuario(UsuarioInput usuarioInput)
        {
            return new Usuario(
                id: usuarioInput.id,
                nome: usuarioInput.Nome,
                email: usuarioInput.Email,
                senha: usuarioInput.Senha,
                ativo: usuarioInput.Ativado,
                role: usuarioInput.Roles
                );
        }


        private UsuarioInput UsuarioTOUsuarioInput(Usuario usuarioInput)
        {
            return new UsuarioInput(
                id: usuarioInput.Id,
                nome: usuarioInput.Nome,
                senha: usuarioInput.Senha,
                email: usuarioInput.Email,
                ativo: usuarioInput.Ativado,
                roles: usuarioInput.Roles,
                roleString: null
                );
        }


        public IEnumerable<UsuarioInput> UsuarioCollectionTOUsuarioInputCollection(IEnumerable<Usuario> usuariosList)
        {
            var lista = new List<UsuarioInput>();
            usuariosList.ToList().ForEach(usu =>
            {
                var transform = UsuarioTOUsuarioInput(usu);
                // transform.Senha = "";
                transform.RoleString = identficadorRole(transform.Roles);
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


        private string identficadorRole(int index)
        {
            string role = null;
            switch (index)
            {
                case 1:
                    role = "Funcionario";
                    break;
                case 2:
                    role = "Cliente";
                    break;
                case 3:
                    role = "Gerente";
                    break;
                case 4:
                    role = "Administrador";
                    break;
                default:
                    role = "";
                    break;
            }

            return role;
        }


        private bool ValidacaoUser(Usuario usuario)
        {
            var cast = int.Parse(usuario.Id);
            var u = this.repositoryUsuario.PesquisarUser(cast);
            if (u == null)
            {
                return true;
            }
            else
            {
                if (u.Roles == 4)
                {
                    return true;
                }
                return usuario.Roles == u.Roles;
            }
        }
    }
}
