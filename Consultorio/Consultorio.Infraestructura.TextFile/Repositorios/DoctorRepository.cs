using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Infraestructura.TextFile.Repositorios
{
    public class DoctorRepository 
    {
        public void AcceptChanges()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctorByCedula(string cedula)
        {
            throw new NotImplementedException();
        }

        public void Save(Doctor doctor)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\Antonio\\Desktop\\Programas mios\\C#\\DoctoresCore.txt", true);

            writer.Write(doctor);
            writer.Close();
            writer.Dispose();
        }
    }
}
