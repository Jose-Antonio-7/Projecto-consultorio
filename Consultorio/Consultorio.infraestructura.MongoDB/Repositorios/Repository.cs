//using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.MongoDB.Models;
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
    public class Repository : IRepository<Dominio.Entidades.Cliente> 
    {

        private readonly MongoContext _mongoContext;

        public Repository()
        {
            _mongoContext = new MongoContext();
        }

        public Task AcceptChanges()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Dominio.Entidades.Cliente>> GetAll()
        {
            return await _mongoContext.Cliente.Find(_ => true).ToListAsync();
        }

        public Task<Dominio.Entidades.Cliente> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Dominio.Entidades.Cliente entity)
        {
            await _mongoContext.Cliente.InsertOneAsync(entity);
        }
    }
}
