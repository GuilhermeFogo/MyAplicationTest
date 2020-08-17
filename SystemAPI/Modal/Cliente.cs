using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    public class Cliente : Pessoas
    {

        [Key]
        public string Id { get; set; }
        public Cliente(string id,string nome, string telefone, string email, string rua, string estado, string cep, string complemento, string cidade) : 
            base(nome, telefone, email, rua, estado, cep, complemento, cidade)
        {
            this.Id = id;
        }

        public Cliente() {}
    }
}
