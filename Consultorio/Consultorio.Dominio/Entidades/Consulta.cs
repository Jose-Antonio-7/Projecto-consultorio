using Consultorio.Dominio.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    [BsonCollection("Consultas")]
    public class Consulta:Entity
    {
        //[BsonRepresentation(BsonType.DateTime)]
        //[BsonElement]
        ////[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //[BsonSerializer(typeof(MyCustomDateTimeSerializer<DateTime>))]
        private DateTime _fechaConsulta;

        public DateTime FechaConsulta { 
            get
            {
                return _fechaConsulta; 
            }
            set
            { 
                _fechaConsulta = value.LaterThatHour(1,"Fecha Consulta");
            }
        }

        private string _direccion;
        public string Direccion { 
            get { return _direccion; } 
            set { _direccion = value.Range(0, 30, nameof(_direccion)); } 
        }

        public string DoctorId { get; private set; }
        public Doctor Doctor { get; private set; }

        public string ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }

        private Consulta()
        {

        }

        public Consulta(Cliente cliente, Doctor doctor,  DateTime fechaconsulta, string direccion = "")
        {
            FechaConsulta = fechaconsulta.LaterThatHour(1, "Fecha Consulta");
            Direccion = direccion.Range(0,30,nameof(direccion));
            DoctorId = doctor.Id;
            ClienteId = cliente.Id;
            Cliente = cliente;
            Doctor = doctor;

        }


    }
}
