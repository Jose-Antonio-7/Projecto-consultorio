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
        public List<User> ConsultarUsers()
        {
            return _usersService.ConsultarTodos();
        }

        [HttpPost]
        [Authorize] //comentar para que funcione crear en el login
        public ActionResult CrearUser(User user)
        {
            _usersService.Almacenar(user);

            return Ok();
        }

        [HttpGet("{login}")]
        //[Authorize]
        public ActionResult<User> ConsultarUserPorLogin(string login)
        {
            var user = _usersService.ConsultarUser(login);

            return Ok(user);
        }
    }
}
