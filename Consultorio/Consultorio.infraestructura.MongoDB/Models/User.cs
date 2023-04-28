using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Consultorio.infraestructura.MongoDB.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Login")]
        public string LoginUser { get; set; } = null!;

        [BsonElement("Contraseña")]
        public string ContraseñaUser { get; set; } = null!;

        

    }
}
