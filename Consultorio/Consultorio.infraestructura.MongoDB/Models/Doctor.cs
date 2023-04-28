using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Consultorio.infraestructura.MongoDB.Models
{
    internal class Doctor
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nombre")]
        public string NombreDoctor { get; set; } = null!;

        [BsonElement("Apellido")]
        public string ApellidoDoctor { get; set; } = null!;

        [BsonElement("Direccion")]
        public string CedulaDoctor { get; set; } = null!;

        [BsonElement("Telefono")]
        public string TelefonoDoctor { get; set; } = null!;

    }
}
