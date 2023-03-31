using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Repositorios
{
    public interface IConsultasRepository : IRepository<Consulta>
    {
        List<Consulta> GetCustormerAllDates(string clienteId);
        List<Consulta> GetCustormerDates(string clienteId, DateTime fecha);
        List<Consulta> GetDoctorDates(string doctorId, DateTime fecha);

    }
}
