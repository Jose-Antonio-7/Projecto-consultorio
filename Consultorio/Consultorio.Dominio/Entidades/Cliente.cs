using Consultorio.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Entidades
{
    [BsonCollection("Clientes")]
    public class Cliente : Persona
    {
        public int Edad { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }

        public Cliente(string nombre, string apellido, int edad, string direccion, string telefono): base(nombre, apellido)
        {
            Edad = edad.Range(18,120, nameof(edad));
            Direccion = direccion;
            Telefono = telefono.PhoneNumber(10, nameof(telefono));
        }
        
        public override string ToString()
        {
            return $"{Id},{Nombre}, {Apellido}, {Edad}, {Direccion}, {Telefono}";
        }

    }
}
