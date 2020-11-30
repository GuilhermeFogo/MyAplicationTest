using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SystemAPI.Modal;
using SystemAPI.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return this.usuarioService.PesquisarTodos();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(this.usuarioService.PesquisarUser(id));
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public IActionResult Post([FromBody] Usuario user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Nome) || string.IsNullOrEmpty(user.Senha))
            {
                return BadRequest();
            }
            else
            {
                this.usuarioService.Salve(user);
                return Ok();
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Usuario user)
        {
            if (string.IsNullOrEmpty(user.Email)|| string.IsNullOrEmpty(user.Nome)|| string.IsNullOrEmpty(user.Senha))
            {
                return BadRequest();
            }
            else
            {
                this.usuarioService.Alterar(user);
                return Ok();
            }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.usuarioService.Deletar(id);
            return Ok();
        }
    }
}
