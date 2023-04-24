using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using Consultorio.infraestructura.SqlServer.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Aplicacion.Servicios
{
    public class ConsultasServices
    {

        private readonly Context _context;
        private readonly IConsultasRepository _consultaRepo;
        private readonly IClienteRepository _clienteRepo;
        private readonly IRepositoryDoctor _doctorRepo;

        //Constructor antes de agregar inyeccion de dependencias
        //public ConsultasServices(Context context)
        //{
        //    _context = context;
        //    _consultaRepo = new ConsultasRepository(_context);
        //    _clienteRepo = new ClienteRepository(_context);
        //    _doctorRepo = new DoctorRepository(_context);
        //}

        public ConsultasServices(Context context, IClienteRepository repoCliente, IConsultasRepository repoConsulta, IRepositoryDoctor repoDoctor)
        {
            _context = context;
            _consultaRepo = repoConsulta;
            _clienteRepo = repoCliente;
            _doctorRepo = repoDoctor;

        }

        public async Task<List<Consulta>> CitasCliente(string clienteId)
        {
            return await _consultaRepo.GetCustormerAllDates(clienteId);
        }

        public async Task CrearConsulta(string clienteId, string doctorId, DateTime fecha, string direccion)
        {
            //Todo: Validaciones
            //Responsabilidad de Entidad: Conservar estado valido de la entidad, Estado = contenido de entidad
            //Responsabilidad de repositorio: Acceder a los datos de la base de datos, validar no es su responsabilidad
            //Responsabilidad de servicio de aplicacion: Se encragan de orquetar los valores de negocioi(pasos de negocio)

            //Todo: Validaciones
            //Si existe una en mismo horario para doctor y cliente
            //Si el doctor y cliente es valido

            var cliente = _clienteRepo.GetById(clienteId);
            if (cliente is null)
                throw new InvalidOperationException("El cliente no existe");

            var doctor = _doctorRepo.GetById(doctorId);
            if (doctor is null)
                throw new InvalidOperationException("El doctor no existe");

            if(!Disponibilidad(clienteId, doctorId, fecha))
                throw new InvalidOperationException("Ya existe una cita previa");

            var consulta = new Consulta(await cliente, await doctor, fecha, direccion);

            _consultaRepo.Save(consulta);

            await _consultaRepo.AcceptChanges();

        }

        private bool Disponibilidad(string clienteId, string doctorId, DateTime fecha)
        {
            List<Consulta> citaCliente = _consultaRepo.GetCustormerDates(clienteId, fecha).Result; //Checar si es lo correcto con ivan
            List<Consulta> citaDoctor = _consultaRepo.GetDoctorDates(doctorId, fecha).Result; //Checar si es lo correcto con ivan

            if (citaCliente.Count() > 0 || citaDoctor.Count() > 0)
                return false;
            return true;
        }
    }
}
