using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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


    }
}
