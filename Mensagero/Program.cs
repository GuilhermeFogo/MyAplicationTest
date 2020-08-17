using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.Json;

namespace Mensagero
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("./emailsettings.json"))
            {

                var json = r.ReadToEnd();
                Console.WriteLine(json);
                var items = JsonConvert.DeserializeObject<Teste>(json);
                Console.WriteLine(items.Nome);
                Console.ReadKey();

            }
        }

        //public static void enviar()
        //{
        //    var mail = new MailMessage("gui.fogo.metodista@gmail.com", "jorge.fogo1@gmail.com", "Teste Bot EMail", "TesteEmail Para o Jorge");
        //    using (var smtp = new SmtpClient("smtp.gmail.com"))
        //    {
        //        smtp.EnableSsl = true; // GMail requer SSL
        //        smtp.Port = 587;       // porta para SSL
        //        smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
        //        smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

        //        // seu usuário e senha para autenticação
        //        smtp.Credentials = new NetworkCredential("gui.fogo.metodista@gmail.com", "107852361");

        //        // envia o e-mail
        //        smtp.Send(mail);
        //    }
        //}

    }

    public class Teste
    {
        public string Nome { get; set; }
        public string Pass { get; set; }
    }
}
