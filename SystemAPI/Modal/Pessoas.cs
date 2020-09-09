using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public Pessoas(string idEndereco ,string nome, string telefone, string email, string rua, string estado, string cep, 
            string complemento, string cidade, string bairro)
        {
            this.endereco = new Endereco(idEndereco, rua, cep, estado, cidade, complemento,bairro);
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public Pessoas() {
            this.endereco = new Endereco
            {
            };
        }
    }
}
