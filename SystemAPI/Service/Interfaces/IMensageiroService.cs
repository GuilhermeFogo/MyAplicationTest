using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Service.Interfaces
{
    public interface IMensageiroService
    {
        void EnviarEmailProgramado();

        void EnvioDeEmail(string para, string assunto, string conteudo);
    }
}
