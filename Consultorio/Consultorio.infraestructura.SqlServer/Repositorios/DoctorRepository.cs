using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.SqlServer.Repositorios
{
    public class DoctorRepository : Repository<Doctor>, IRepositoryDoctor
    {
        private readonly Context _context;

        public DoctorRepository(Context context):base(context)
        {
            _context = context;
        }

        //public List<Doctor> GetAll()
        //{
        //    return _context.Doctores.ToList();
        //}

        public async Task<Doctor> GetDoctorByCedula(string cedula)
        {
            throw new NotImplementedException();
        }

        //public void Save(Doctor doctor)
        //{
        //    _context.Doctores.Add(doctor);
        //    _context.SaveChanges();

        //}
    }
}
