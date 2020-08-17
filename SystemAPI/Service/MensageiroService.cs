using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Mensagero;
using SystemAPI.Service.Interfaces;

namespace SystemAPI.Service
{
    public class MensageiroService : IMensageiroService
    {
        private readonly IMensageiro mensageiro;
        public MensageiroService(IMensageiro mensageiro)
        {
            this.mensageiro = mensageiro;
        }
        public void EnviarEmailProgramado()
        {
            this.mensageiro.EnviarEmail("", "", "");
        }

        public void EnvioDeEmail(string para, string assunto, string conteudo)
        {

            this.mensageiro.EnviarEmail(para, assunto, conteudo);
        }
    }
}
