using Auth.Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Services.Interfaces
{
    public interface IAutchUserService
    {
        string CriarToken(UsuarioAuth usuario);
    }
}
