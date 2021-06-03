using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemAPI.DTO
{
    public class UsuarioInput
    {
        public string id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool Ativado { get; set; }
        public int Roles { get; set; }
        public string RoleString { get; set; }


        public UsuarioInput(string id, string nome, string senha, string email, bool ativo, int roles, string roleString)
        {
            this.id = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.Ativado = ativo;
            this.Roles = roles;
            this.RoleString = roleString;
        }
        public UsuarioInput()
        {

        }
    }
}
