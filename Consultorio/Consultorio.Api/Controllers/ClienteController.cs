using Consultorio.Api.Dtos;
using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.SqlServer.Contextos;
using Consultorio.infraestructura.MongoDB.Context;

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
        //private readonly ConsultasServices _consultasServices;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(Context context, ClienteService clienteService/*, ConsultasServices consultasServices */) //descomentar despues
        {
            _context = context;
            _clienteService = clienteService;
            //_consultasServices = consultasServices; descomentar despues
        }

        [HttpGet]
        [Authorize] //descomentar despues
        public async Task<ActionResult<List<Cliente>>> ConsultarClientes()
        {
            try
            {
                return Ok(await _clienteService.ConsultarTodos());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return StatusCode(500, "Internal Server Error");
            }

        }

        [HttpPost]
        //[Authorize] descomentar despues
        public async Task<ActionResult> CrearCliente(Cliente cliente)
        {
            await _clienteService.Almacenar(cliente);
            return Ok();
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ActionResult<Cliente>> ConsultarClientePorId(string id)
        {
            return Ok(await _clienteService.ConsultarCliente(id));
        }

        //descomentar despues
        //[HttpGet("{id}/citas")]
        //[Authorize]
        //public async Task<ActionResult<List<Consulta>>> ConsultarCitasCliente(string id)
        //{
        //    //var servicio = new ConsultasServices(_context);

        //    //var result = _consultasServices.CitasCliente(id);

        //    return Ok(await _consultasServices.CitasCliente(id));
        //}

        //descomentar despues
        //[HttpPost("{id}/citas")]
        //[Authorize]
        //public async Task<ActionResult<List<Consulta>>> AgendarCita([FromRoute] string id, [FromBody] CrearConsultaDto consulta)
        //{
        //    //var servicio = new ConsultasServices(_context);

        //    //_consultasServices.CrearConsulta(id, consulta.DoctorId, consulta.Fecha, consulta.Direccion);

        //    //Checar con ivan si es correcto que no haya nada en return debido a que es void implicito
        //    await _consultasServices.CrearConsulta(id, consulta.DoctorId, consulta.Fecha, consulta.Direccion);
        //    return Ok();
        //}

    }
}