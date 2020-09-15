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
        public IActionResult Get(int id)
        {
            return Ok(this.clienteService.PesquisaCliente(id));
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente.Id_Cliente.Equals("0"))
            {
                this.clienteService.Salvar(cliente);
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<ClienteController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            if (cliente.Id_Cliente != null && cliente.endereco.Id_Endereco != null)
            {
                this.clienteService.Alterar(cliente);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.clienteService.Deletar(id);
        }
    }
}
