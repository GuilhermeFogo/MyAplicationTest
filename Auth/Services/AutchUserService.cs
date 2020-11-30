using Auth.Modal;
using Auth.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SystemAPI.Configuracoes.Interfaces;

namespace Auth.Services
{
    public class AutchUserService : IAutchUserService
    {
        private IConfiguracao configuracao;
        private MyAuth auth;
        public AutchUserService(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            var arquivo = this.configuracao.LerArquivo("../Auth/settings.json");
            this.auth = JsonConvert.DeserializeObject<MyAuth>(arquivo);

        }
        public string CriarToken(UsuarioAuth usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(auth.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Nome.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
