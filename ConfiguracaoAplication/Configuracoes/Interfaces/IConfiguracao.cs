using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.Configuracoes.Interfaces
{
    public interface IConfiguracao
    {
        string LerArquivo(string nomeJSON);
    }
}
