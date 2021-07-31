using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.DTO;
using SystemAPI.Mensagero;
using SystemAPI.Service.Interfaces;

namespace SystemAPI.Service
{
    public class MensageiroService : IMensageiroService
    {
        private readonly IMensageiro mensageiro;
        private readonly IUsuarioService usuario;
        public MensageiroService(IMensageiro mensageiro, IUsuarioService usuarioService)
        {
            this.mensageiro = mensageiro;
            this.usuario = usuarioService;
        }
        public void EnviarEmailProgramado()
        {
            this.mensageiro.EnviarEmail("", "", "");
        }

        public void EnvioDeEmail(MensageroDTO mensageroDTO)
        {
            this.mensageiro.EnviarEmail(mensageroDTO.Para, mensageroDTO.Assunto, mensageroDTO.Conteudo);
        }

        public void EnvioDeEmailCadastrado(MensageroDTO mensageroDTO)
        {
            var usu = this.usuario.PesquisarUser(mensageroDTO.idUser);
            if (usu.Email == mensageroDTO.Para)
            {
                this.mensageiro.EnviarEmail(mensageroDTO.Para, mensageroDTO.Assunto, mensageroDTO.Conteudo);
            }
        }
    }
}
