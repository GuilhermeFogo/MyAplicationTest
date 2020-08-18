using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SystemAPI.Modal;
using SystemAPI.Repository.Interfaces;
using SystemAPI.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;
        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }
        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return this.clienteService.VerTodosClientes();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return this.clienteService.PesquisaCliente(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            this.clienteService.Salvar(cliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut()]
        public void Put([FromBody] Cliente cliente)
        {
            this.clienteService.Alterar(cliente);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.clienteService.Deletar(id);
        }
    }
}
