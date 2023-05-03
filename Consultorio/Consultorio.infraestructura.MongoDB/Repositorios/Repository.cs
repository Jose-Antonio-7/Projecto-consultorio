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
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly MongoContext _mongoContext;
        private readonly IMongoCollection<T> _collection;

        public Repository()
        {
            _mongoContext = new MongoContext();
            _collection = _mongoContext.database.GetCollection<T>(GetCollectionName(typeof(T)));

        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }

        public Task AcceptChanges()
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<T> GetById( string id)
        {
            var resultado = await _collection.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            return resultado;
        }

        public async Task Save(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }
    }
}
