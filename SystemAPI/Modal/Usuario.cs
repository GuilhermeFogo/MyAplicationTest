using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativado { get; set; }

        public Usuario(string id, string nome, string senha, string email, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.Ativado = ativo;
        }

        public Usuario()
        {

        }
    }
}
