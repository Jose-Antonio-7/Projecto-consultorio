using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.MongoDB.Context;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.MongoDB.Repositorios
{
    public class ConsultasRepository : Repository<Consulta>, IConsultasRepository
    {
        private readonly MongoContext _mongoContext;
        private readonly IMongoCollection<Consulta> _collection;
        public ConsultasRepository()
        {
            _mongoContext = new MongoContext();
            _collection = _mongoContext.database.GetCollection<Consulta>(GetCollectionName(typeof(Consulta)));
        }


        public async Task<List<Consulta>> GetCustormerAllDates(string clienteId)
        {
            return await _collection.Find(c => c.ClienteId.Equals(clienteId) && c.FechaConsulta.AddHours(1) > DateTime.Now).ToListAsync();
        }

        public async Task<List<Consulta>> GetCustormerDates(string clienteId, DateTime fecha)
        {
            //var  citas = await _collection.Find(c => c.ClienteId == clienteId && c.FechaConsulta.Date == fecha.Date).ToListAsync();
            return await _collection.Find(c => c.ClienteId.Equals(clienteId) && c.FechaConsulta.Equals(fecha)).ToListAsync();
            //return await _collection.Find(c => c.ClienteId.Equals(clienteId) && c.FechaConsulta == (fecha.Date)).ToListAsync();
            //return  citas;
        }

        public async Task<List<Consulta>> GetDoctorDates(string doctorId, DateTime fecha)
        {
            return await _collection.Find(c => c.DoctorId.Equals(doctorId) && c.FechaConsulta.Equals(fecha)).ToListAsync();
        }
    }
}