using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Modal
{
    public class UsuarioAuth
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public UsuarioAuth(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public UsuarioAuth()
        {

        }
    }
}
