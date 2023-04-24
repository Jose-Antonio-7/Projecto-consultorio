using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.SqlServer.Contextos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        private readonly Context _context;
        private readonly UserService _usersService;


        public UserController(Context context, UserService usersService)
        {
            _context = context;
            _usersService = usersService;


        }

        [HttpGet]
        //[Authorize] 
        public async Task<List<User>> ConsultarUsers()
        {
            return await _usersService.ConsultarTodos();
        }

        [HttpPost]
        [Authorize] //comentar para que funcione crear en el login
        public async Task<ActionResult> CrearUser(User user)
        {
            await _usersService.Almacenar(user);

            return Ok();
        }

        [HttpGet("{login}")]
        //[Authorize]
        public async Task<ActionResult<User>> ConsultarUserPorLogin(string login)
        {
            //var user = _usersService.ConsultarUser(login);

            return Ok(await _usersService.ConsultarUser(login));
        }
    }
}
