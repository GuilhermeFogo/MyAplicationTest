using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.DTO;

namespace SystemAPI.Service.Interfaces
{
    public interface IMensageiroService
    {
        void EnviarEmailProgramado();

        void EnvioDeEmailCadastrado(MensageroDTO mensagero);
        void EnvioDeEmail(MensageroDTO mensagero);
    }
}
