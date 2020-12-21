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
        void Salve(UsuarioInput usuario);
        void Deletar(int id);
        void Alterar(UsuarioInput usuario);
        UsuarioInput PesquisarUser(int id);
        IEnumerable<UsuarioInput> PesquisarTodos();

        string Autenticar(UsuarioDTO usuario);
    }
}
