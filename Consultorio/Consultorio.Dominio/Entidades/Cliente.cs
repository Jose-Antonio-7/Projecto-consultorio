using Consultorio.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Entidades
{
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

        //private string ValidarTelefono(string telefono)
        //{
        //    //ToDo: Validar que solo tenga letras
        //    if(!IsDigitsOnly(telefono) || telefono.Length!=10)
        //        throw new ArgumentException($"El valor del tipo {nameof(telefono)} no es valido", nameof(telefono));

        //    return telefono;
        //}
        //bool IsDigitsOnly(string str)
        //{
        //    foreach (char c in str)
        //    {
        //        if (c < '0' || c > '9')
        //            return false;
        //    }

        //    return true;
        //}
        //private string ValidarDireccion(string direccion)
        //{
        //    //ToDo: Validar que solo tenga letras
        //    if (string.IsNullOrWhiteSpace(direccion) || direccion.Length <= 50 || direccion.Length >= 4)
        //        throw new ArgumentException($"El valor del tipo {nameof(direccion)} no es valido", nameof(direccion));

        //    return direccion;
        //}

    }
}
