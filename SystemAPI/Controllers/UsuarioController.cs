﻿using System;
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
        public Usuario Get(int id)
        {
            return  this.usuarioService.PesquisarUser(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Usuario user)
        {
            this.usuarioService.Salve(user);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut()]
        public void Put([FromBody] Usuario user)
        {
            this.usuarioService.Alterar(user);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.usuarioService.Deletar(id);
        }
    }
}
