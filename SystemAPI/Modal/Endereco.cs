using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Modal
{
    public class Endereco
    {
        public string IdEndereco { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

        public Endereco(string rua, string cep, string estado, string cidade, string complemento) 
        {
            this.Estado = estado;
            this.Rua = rua;
            this.CEP = cep;
            this.Complemento = complemento;
        }
    }
}
