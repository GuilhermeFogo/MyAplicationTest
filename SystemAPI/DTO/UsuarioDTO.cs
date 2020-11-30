using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.DTO
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public UsuarioDTO(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }
        public UsuarioDTO()
        {

        }
    }
}
