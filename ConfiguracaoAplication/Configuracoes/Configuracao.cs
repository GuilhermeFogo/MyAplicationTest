using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SystemAPI.Configuracoes.Interfaces;

namespace SystemAPI.Configuracoes
{
    public class Configuracao : IConfiguracao
    {
        public string LerArquivo(string nomeJSON)
        {
            using (StreamReader r = new StreamReader(nomeJSON))
            {
                var json = r.ReadToEnd();
                return json;
            }
        }
    }
}
