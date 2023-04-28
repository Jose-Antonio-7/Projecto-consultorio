using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.infraestructura.MongoDB.Context;
//using Consultorio.Dominio.Entidades;
using Consultorio.infraestructura.MongoDB.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Consultorio.infraestructura.MongoDB.Services
{
    public class ClientesService
    {
        private readonly IMongoCollection<Cliente> _clientesCollection;

        public ClientesService(
        IOptions<MongoDBDatabaseSettings> mongoDBDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                mongoDBDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                mongoDBDatabaseSettings.Value.DatabaseName);

            //_clientesCollection = mongoDatabase.GetCollection<Cliente>(
            //    mongoDBDatabaseSettings.Value.ClientesCollectionName);
        }

        public async Task<List<Cliente>> GetAsync() =>
            await _clientesCollection.Find(_ => true).ToListAsync();

        public async Task<Cliente?> GetAsync(string id) =>
            await _clientesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Cliente newCliente) =>
            await _clientesCollection.InsertOneAsync(newCliente);

        public async Task UpdateAsync(string id, Cliente updatedBook) =>
            await _clientesCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _clientesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
