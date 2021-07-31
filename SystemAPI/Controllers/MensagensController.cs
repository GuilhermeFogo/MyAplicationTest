using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SystemAPI.DTO;
using SystemAPI.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagensController : ControllerBase
    {
        private readonly IMensageiroService mensageiroService;

        public MensagensController(IMensageiroService mensageiroService)
        {
            this.mensageiroService = mensageiroService;
        }

        //// GET: api/<MensagensController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    this.mensageiroService.EnvioDeEmail("", "", "");
        //    return Ok();
        //}

        //// GET api/<MensagensController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MensagensController>
        //[HttpPost]
        //public IActionResult Post([FromBody] MensageroDTO mensageroDTO)
        //{
        //    if (mensageroDTO.Para != null || mensageroDTO.idUser != 0 || mensageroDTO.Assunto != null || mensageroDTO.Conteudo != null)
        //    {
        //        this.mensageiroService.EnvioDeEmailCadastrado(mensageroDTO);
        //        return Ok($"Email enviado para {mensageroDTO.Para}");
        //    }
        //    return BadRequest();

        //}



        [HttpPost]
        public IActionResult Envia_email([FromBody] MensageroDTO mensageroDTO)
        {
            if (mensageroDTO.Para != null || mensageroDTO.idUser != 0 || mensageroDTO.Assunto != null || mensageroDTO.Conteudo != null)
            {
                this.mensageiroService.EnvioDeEmail(mensageroDTO);
                return Ok($"Email enviado para {mensageroDTO.Para}");
            }
            return BadRequest();

        }

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
