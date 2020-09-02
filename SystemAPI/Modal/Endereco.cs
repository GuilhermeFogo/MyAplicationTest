using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    [Table("dbo.Endereco")]
    public class Endereco
    {
        [Key]
        public string Id_Endereco { get; set; }
        
        public string Rua { get; set; }
        
        public string Complemento { get; set; }
        
        public string CEP { get; set; }
        
        public string Estado { get; set; }

        public string Cidade { get; set; }

        public Endereco( string idendereco, string rua, string cep, string estado, string cidade, string complemento) 
        {
            this.Id_Endereco = idendereco;
            this.Estado = estado;
            this.Rua = rua;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Complemento = complemento;
        }

        public Endereco()
        {
        }
    }
}
