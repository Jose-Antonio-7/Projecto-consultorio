using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Entidades
{
    public class Doctor : Persona 
    {
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }

        public Doctor(string nombre, string apellido, string cedula, string telefono):base(nombre, apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
        }
       
        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {Cedula}, {Telefono}";
        }
    }
}
