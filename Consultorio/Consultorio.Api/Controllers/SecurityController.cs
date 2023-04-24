using Consultorio.Api.Dtos;
using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.SqlServer.Contextos;
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
        private readonly UserService _userServices;
        private readonly Context _context;

        public SecurityController(Context context, UserService userServices)
        {
            _context = context;
            _userServices = userServices;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserAuth user)
        {
            var Login = user.Login;
            var Contraseña = user.Contraseña;
            User usuarioConsultado = await _userServices.ConsultarUser(Login);


            if (user == null || usuarioConsultado == null)
            {
                return BadRequest("Usuario: invalido");
            }


            //Se necesita crear una exepcion para cuando sea nulo
            if(user.Login == usuarioConsultado.Login && user.Contraseña == usuarioConsultado.Contraseña)
            {
                var secretkey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("passwordSuperSecreto"));

                var credentials = new SigningCredentials(
                    secretkey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:7256",
                    audience: "http://localhost:7256",
                    expires: DateTime.Now.AddSeconds(60),
                    signingCredentials: credentials,
                    claims: new List<Claim>() { new Claim("email", "ivanh@techsoft.com.mx") }
                    );

                var tokenString = new JwtSecurityTokenHandler()
                    .WriteToken(tokenOptions);

                return Ok( tokenString );


            }

            return Unauthorized();

        }

    }
}
