using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    [Table("dbo.Cliente")]
    public class Cliente : Pessoas
    {
        [Key]
        public string Id_Cliente { get; set; }
        
        public Cliente(string id_cliente, string idEndereco, string nome, string telefone, string email, string rua, string estado, string cep, string complemento, string cidade) : 
            base(idEndereco, nome, telefone, email, rua, estado, cep, complemento, cidade)
        {
            this.Id_Cliente = id_cliente;
        }
        public Cliente(): base() {}

    }
}
