using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Repositorios
{
    public interface IRepositoryDoctor : IRepository<Doctor>
    {
        List<Doctor> GetDoctorByCedula(string cedula);

    }
}
