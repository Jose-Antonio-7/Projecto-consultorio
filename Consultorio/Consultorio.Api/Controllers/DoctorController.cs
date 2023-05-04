using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Api.Controllers
{
    [Route("v1/doctores")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _doctorService;
        public DoctorController(DoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<List<Doctor>>> ConsultarClientes()
        {
            return Ok(await _doctorService.ConsultarTodos());
        }
        [HttpPost]
        //[Authorize]
        public async Task<ActionResult> CrearCliente(Doctor doctor)
        {
            await _doctorService.Almacenar(doctor);
            return Ok();
        }
    }
}
