using Developer.Store.Application.Interface;
using Developer.Store.Commands.User;
using Developer.Store.Domain.Reequest.Auth;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Developer.Store.Application.Application
{
    public class AuthApplication : IAuthApplication
    {
        private readonly SymmetricSecurityKey _key;
        private readonly IMediator _mediator;

        public AuthApplication(SymmetricSecurityKey key, IMediator mediator)
        {
            _key = key;
            _mediator = mediator;
        }
        public async Task<string> CreateToken(LoginRequest login)
        {
            var user = await _mediator.Send(new UserRequestLoginCommand(login));

            if (user == null) { throw new Exception("Nenhum Usuario encontrado"); }

            var tokenHandler = new JwtSecurityTokenHandler();
            ClaimsIdentity claimsIdentity = new ClaimsIdentity();


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(48),
                SigningCredentials = new SigningCredentials(_key,
                            SecurityAlgorithms.HmacSha256Signature
                        )
            };

            claimsIdentity.AddClaim(new Claim("Id", user.Id.ToString()));
            claimsIdentity.AddClaim(new Claim("Email", user.Email));
            claimsIdentity.AddClaim(new Claim("name", $"{user.Name.Firstname} {user.Name.Lastname}"));

            tokenDescriptor.Subject = claimsIdentity;

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return "Bearer " + tokenHandler.WriteToken(token).ToString();
        }
    }
}
