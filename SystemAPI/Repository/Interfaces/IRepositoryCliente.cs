using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;

namespace SystemAPI.Repository.Interfaces
{
    public interface IRepositoryCliente
    {
        void Salve(Cliente cliente);

        void Deletar(Cliente cliente);
        void Alterar(Cliente cliente);

        Cliente PesquisaCliente(int id);
        IEnumerable<Cliente> PesquisaTodosClientes();
    }
}
