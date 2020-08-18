using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SystemAPI.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagensController : ControllerBase
    {
        private readonly IMensageiroService mensageiroService;
        private readonly IClienteService clienteService;
        public MensagensController(IMensageiroService mensageiroService, IClienteService clienteService)
        {
            this.mensageiroService = mensageiroService;
            this.clienteService = clienteService;
        }

        // GET: api/<MensagensController>
        [HttpGet]
        public void Get()
        {
            var html = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3654.1858688342786!2d-46.52665808447375!3d-23.66931017147383!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce427b1eea8901%3A0x9d706269dc3132ff!2sAv.%20da%20Saudade%2C%2065%20-%20Vila%20Assun%C3%A7%C3%A3o%2C%20Santo%20Andr%C3%A9%20-%20SP%2C%2009030-030!5e0!3m2!1spt-BR!2sbr!4v1597772339440!5m2!1spt-BR!2sbr' width='600' height='450' frameborder='0' style='border:0;' allowfullscreen='' aria-hidden='false' tabindex='0'></iframe>";
            this.mensageiroService.EnvioDeEmail("jorge.fogo1@gmail.com", "Castre-se Já ", html.Trim());
        }

        //// GET api/<MensagensController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MensagensController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MensagensController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MensagensController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
