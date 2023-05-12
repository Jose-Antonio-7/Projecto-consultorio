using Consultorio.Dominio.Entidades;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Consultorio.Api.Dtos
{
    public class CrearConsultaDto
    {
        public string DoctorId { get; set; }

        //[BsonElement]
        ////[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //[BsonSerializer(typeof(MyCustomDateTimeSerializer<DateTime>))]
        //[BsonRepresentation(BsonType.DateTime)]
        public DateTime Fecha { get; set; }

        public string Direccion { get; set; }


    }
}
