using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Modal;
using SystemAPI.Repository.Interfaces;
using SystemAPI.Service.Interfaces;

namespace SystemAPI.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ClienteService(IRepositoryCliente repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
        public void Alterar(Cliente cliente)
        {
            this.repositoryCliente.Alterar(cliente);
        }

        public void Deletar(int id)
        {
            var cliente = repositoryCliente.PesquisaCliente(id);
            this.repositoryCliente.Deletar(cliente);
        }

        public void Salvar(Cliente cliente)
        {
            this.repositoryCliente.Salve(cliente);
        }

        public IEnumerable<Cliente> VerTodosClientes()
        {
            return this.repositoryCliente.PesquisaTodosClientes();
        }
    }
}
