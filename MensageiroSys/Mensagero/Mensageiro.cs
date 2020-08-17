﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using SystemAPI.Configuracoes.Interfaces;
using SystemAPI.Modal;

namespace SystemAPI.Mensagero
{
    public class Mensageiro : IMensageiro
    {
        private readonly IConfiguracao configJson;
        private readonly Emails emails;

        public Mensageiro(IConfiguracao configJson)
        {
            this.configJson = configJson;
            var arquivo = this.configJson.LerArquivo("./emailsettings.json");
            this.emails = JsonConvert.DeserializeObject<Emails>(arquivo);
        }
        public void EnviarEmail(string para, string asssunto, string mensagem)
        {
            var mail = new MailMessage( this.emails.Email, para,asssunto,mensagem);
            ConfigurandoEnviandoEmail(mail);
        }

        public void EnviarEmailComAnexo(string para, string asssunto, string mensagem, string nomeArquivo)
        {

            var mail = new MailMessage(this.emails.Email, para, asssunto, mensagem);
            mail.Attachments.Add(new Attachment(nomeArquivo));
            ConfigurandoEnviandoEmail(mail);
        }


        private void ConfigurandoEnviandoEmail(MailMessage mail)
        {
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential(this.emails.Email, this.emails.Pass);

                // envia o e-mail
                smtp.Send(mail);
            }
        }
    }
}
