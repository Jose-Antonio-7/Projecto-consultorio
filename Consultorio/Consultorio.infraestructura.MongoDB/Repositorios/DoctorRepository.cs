using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.MongoDB.Context;
using DnsClient;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.MongoDB.Repositorios
{
    public class DoctorRepository : Repository<Doctor>, IRepositoryDoctor
    {
        private readonly MongoContext _mongoContext;
        private readonly IMongoCollection<Doctor> _collection;
        public DoctorRepository()
        {
            _mongoContext = new MongoContext();
            _collection = _mongoContext.database.GetCollection<Doctor>(GetCollectionName(typeof(Doctor)));
        }

        public async Task<Doctor> GetDoctorByCedula(string cedula)
        {
            return await _collection.Find(x => x.Cedula.Equals(cedula)).FirstOrDefaultAsync();
        }


    }
}
