using Consultorio.Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Consultorio.Api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class SecurityController : ControllerBase
    {
        [HttpPost("login")]
        public ActionResult Login([FromBody] UserAuth user)
        {
            if(user == null)
            {
                return BadRequest("Usuario: invalido");
            }

            if(user.Login == "ivanh" && user.Contraseña == "pruebas")
            {
                var secretkey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("passwordSuperSecreto"));

                var credentials = new SigningCredentials(
                    secretkey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:7256",
                    audience: "http://localhost:7256",
                    expires: DateTime.Now.AddSeconds(30),
                    signingCredentials: credentials,
                    claims: new List<Claim>() { new Claim("email", "ivanh@techsoft.com.mx") }
                    );

                var tokenString = new JwtSecurityTokenHandler()
                    .WriteToken(tokenOptions);

                return Ok(new { Token = tokenString });


            }

            return Unauthorized();

        }
       
    }
}
