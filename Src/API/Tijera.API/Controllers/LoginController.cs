using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Core.Abstraction.Services;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Login Controller
    /// </summary>
    [ApiController]
    [Route(("[controller]"))]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly ILoginService loginService;
        private readonly IConfiguration config;

        public LoginController(ILoginService loginService, IConfiguration config, ILogger<LoginController> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.loginService = loginService;
            this.config = config;
        }

        /// <summary>
        /// Get all consent Data
        /// </summary>
        /// <param name="Credentials">User Credentials</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpPost("GetLogin")]
        //[Authorize]
        public async Task<IActionResult> GetLogin(LoginRequestDto Credentials)
        {
            var isCashier = false;
            var hasOnlyOne = false;
            var consentResponse = await loginService.GetAccess(Credentials);

            if(consentResponse.Count > 0)
            {
                isCashier = consentResponse[0].CveEmpleado == 2 ? true : false;
                hasOnlyOne = consentResponse.Count == 1;
            }

            return consentResponse == null ? BadRequest(new { message = "Invalid Credentials"}) 
                : Ok(new { token = NewToken(consentResponse[0]), user = consentResponse } );  

        }

        private string NewToken(LoginResponseDto admin)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, admin.Name),
                new Claim(ClaimTypes.Role, admin.Name)
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
