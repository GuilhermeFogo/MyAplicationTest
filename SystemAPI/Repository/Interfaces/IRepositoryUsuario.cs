using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;

namespace SystemAPI.Repository.Interfaces
{
    public interface IRepositoryUsuario
    {
        void Salve(Usuario usuario);
        void Alterar(Usuario usuario);
        void Deletar(Usuario usuario);
        Usuario PesquisarUser(int id);

        IEnumerable<Usuario> PesquisarTodos();
    }
}
