using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.DTO
{
    public class MensageroDTO
    {
        public int idUser { get; set; }
        public string Para { get; set; }
        public string Conteudo { get; set; }
        public string Assunto { get; set; }

        public MensageroDTO()
        {

        }

        public MensageroDTO(int id ,string para, string conteudo, string assunto)
        {
            this.idUser = id;
            this.Assunto = assunto;
            this.Conteudo = conteudo;
            this.Para = para;
        }
    }
}
