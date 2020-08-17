using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public bool? Ativado { get; private set; }

        public Usuario(string nome, string senha, string email, bool? ativado )
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.Ativado = ativado;
        }

        public Usuario()
        {

        }
    }
}
