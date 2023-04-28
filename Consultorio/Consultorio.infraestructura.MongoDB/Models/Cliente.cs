using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Consultorio.Dominio.Helpers;


namespace Consultorio.infraestructura.MongoDB.Models
{
    public class Cliente
    {
        

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nombre")]
        public string NombreCliente { get; set; } = null!;
        
        [BsonElement("Apellido")]
        public string ApellidoCliente { get; set; } = null!;

        public int Edad { get; set; }

        [BsonElement("Direccion")]
        public string DireccionCliente { get; set; } = null!;

        [BsonElement("Telefono")]
        public string TelefonoCliente { get; set; } = null!;

        public Cliente(string nombre, string apellido, int edad, string direccion, string telefono)
        {
            NombreCliente = nombre;
            ApellidoCliente = apellido;
            //Edad = edad.Range(18, 120, nameof(edad));
            Edad = edad;
            DireccionCliente = direccion;
            //TelefonoCliente = telefono.PhoneNumber(10, nameof(telefono));
            TelefonoCliente = telefono;
        }
    }
}
