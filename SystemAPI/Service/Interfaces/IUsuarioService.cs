using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;

namespace SystemAPI.Service.Interfaces
{
    public interface IUsuarioService
    {
        void Salve(Usuario usuario);
        void Deletar(int id);
        void Alterar(Usuario usuario);
    }
}
