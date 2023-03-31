using Consultorio.Api.Dtos;
using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.SqlServer.Contextos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Api.Controllers
{
    [ApiController]
    [Route("v1/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly Context _context;
        private readonly ClienteService _clienteService;
        private readonly ConsultasServices _consultasServices;

        public ClienteController(Context context, ClienteService clienteService, ConsultasServices consultasServices)
        {
            _context = context;
            _clienteService = clienteService;
            _consultasServices = consultasServices;
        }

        [HttpGet]
        [Authorize]
        public List<Cliente> ConsultarClientes()
        {
            //var servicio = new ClienteService(_context);

            return _clienteService.ConsultarTodos();
        }

        [HttpPost]
        [Authorize]
        public ActionResult CrearCliente(Cliente cliente)
        {
            //var servicio = new ClienteService(_context);

            _clienteService.Almacenar(cliente);

            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<Cliente> ConsultarClientePorId(string id)
        {
            //var servicio = new ClienteService(_context);

            var cliente = _clienteService.ConsultarCliente(id);

            return Ok(cliente);
        }

        [HttpGet("{id}/citas")]
        [Authorize]
        public ActionResult<List<Consulta>> ConsultarCitasCliente(string id)
        {
            //var servicio = new ConsultasServices(_context);

            var result = _consultasServices.CitasCliente(id);

            return Ok(result);
        }

        [HttpPost("{id}/citas")]
        [Authorize]
        public ActionResult<List<Consulta>> AgendarCita([FromRoute]string id, [FromBody] CrearConsultaDto consulta)
        {
            //var servicio = new ConsultasServices(_context);

            _consultasServices.CrearConsulta(id, consulta.DoctorId, consulta.Fecha, consulta.Direccion);

            return Ok();
        }

    }
}
