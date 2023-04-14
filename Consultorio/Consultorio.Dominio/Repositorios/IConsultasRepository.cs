using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Repositorios
{
    public interface IConsultasRepository : IRepository<Consulta>
    {
        Task<List<Consulta>> GetCustormerAllDates(string clienteId);
        Task<List<Consulta>> GetCustormerDates(string clienteId, DateTime fecha);
        Task<List<Consulta>> GetDoctorDates(string doctorId, DateTime fecha);

    }
}
