using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;

namespace SystemAPI.Service.Interfaces
{
    public interface IClienteService
    {
        void Salvar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(int id);
        IEnumerable<Cliente> VerTodosClientes();
        Cliente PesquisaCliente(int id);
    }
}
