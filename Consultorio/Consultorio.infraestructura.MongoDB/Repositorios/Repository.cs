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
    public class Repository : IRepository<Cliente> 
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

        public async Task<List<Cliente>> GetAll()
        {
            return await _mongoContext.Cliente.Find(_ => true).ToListAsync();
        }

        public Task<Cliente> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Cliente entity)
        {
            await _mongoContext.Cliente.InsertOneAsync(entity);
        }
    }
}
