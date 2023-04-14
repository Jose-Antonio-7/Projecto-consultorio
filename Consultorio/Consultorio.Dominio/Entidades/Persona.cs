using Consultorio.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Entidades
{
    public abstract class Persona : Entity
    {
        //public string Id { get; private set; }
        public string Nombre { get; protected set; }
        public string Apellido { get; protected set; }

        public Persona(string nombre, string apellido)
        {
            //Id = Guid.NewGuid().ToString();
            Nombre = nombre.Range(2, 30, nameof(nombre));
            Apellido = apellido.Range(2, 30, nameof(apellido));

            //Nombre = Guards.StringRange(nombre, 2, 3, nameof(nombre));
            //Apellido = Guards.StringRange(apellido, 2, 3, nameof(apellido));
        }

        private string ValidarNombre(string nombre)
        {
            //ToDo: Validar que solo tenga letras
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Length >= 30 || nombre.Length <= 2)
                throw new ArgumentException($"El valor del tipo {nameof(nombre)} no es valido", nameof(nombre));

            return nombre;
        }
    }
}
