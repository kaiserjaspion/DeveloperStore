using Developer.Store.Domain.Reequest.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Application.Interface
{
    public interface IAuthApplication
    {
        Task<string> CreateToken(LoginRequest login);
    }
}
