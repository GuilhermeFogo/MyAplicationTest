using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Modal;
using Auth.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SystemAPI.DTO;
using SystemAPI.Modal;
using SystemAPI.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUsuarioService usuarioService;

        public AuthController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioDTO usuario)
        {
            var token = this.usuarioService.Autenticar(usuario);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            else
            {
                return Ok(token);
            }
        }
    }
}
