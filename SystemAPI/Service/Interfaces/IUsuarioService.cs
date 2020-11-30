using Auth.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.DTO;
using SystemAPI.Modal;

namespace SystemAPI.Service.Interfaces
{
    public interface IUsuarioService
    {
        void Salve(Usuario usuario);
        void Deletar(int id);
        void Alterar(Usuario usuario);
        Usuario PesquisarUser(int id);
        IEnumerable<Usuario> PesquisarTodos();

        string Autenticar(UsuarioDTO usuario);
    }
}
