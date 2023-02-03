using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using TD.Infrastructure.Abstraction.Entities;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using TD.Contracts.Dtos.Response;

namespace TD.Common
{
    public class GenerateToken
    {
        private IConfiguration config;

        public GenerateToken(IConfiguration config)
        {
            this.config = config;
        }
        public string NewToken(EmployeeStylistResponseDto admin)
        {            
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, admin.Name ),
                //new Claim(ClaimTypes.PostalCode, admin.CveTipoEmpleado)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("JWT:Key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds);

            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return token;
        }
    }
}
