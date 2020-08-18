using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    public abstract class Pessoas
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Endereco endereco { get; set; }

        public Pessoas(string nome, string telefone, string email, string rua, string estado, string cep, 
            string complemento, string cidade)
        {
            this.endereco = new Endereco(rua, cep, estado, cidade, complemento);
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public Pessoas() {
            this.endereco = new Endereco();
        }
    }
}
