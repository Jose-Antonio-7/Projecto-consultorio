using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.MongoDB.Context;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.MongoDB.Repositorios
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly MongoContext _mongoContext;

        public ClienteRepository()
        {
            _mongoContext = new MongoContext();
        }

        //public async Task<List<Cliente>> GetAll()
        //{
        //    //throw new NotImplementedException();

        //    //var resultado = await _mongoContext.Cliente.Find(_ => true).ToListAsync();
        //    //var cliente = new Consultorio.Dominio.Entidades.Cliente(resultado.NombreCliente, resultado.ApellidoCliente, resultado.Edad, resultado.DireccionCliente, resultado.TelefonoCliente);
        //    return await _mongoContext.Cliente.Find(_ => true).ToListAsync();
        //}

        //public async Task<List<Cliente>> GetAsync() =>
        //await _mongoContext.Cliente.Find(_ => true).ToListAsync();

        //public async Task<Cliente> GetById(/*ObjectId*/ string id)
        //{
        //    var resultado = await _mongoContext.Cliente.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        //    //var cliente = new Consultorio.Dominio.Entidades.Cliente(resultado.NombreCliente, resultado.ApellidoCliente, resultado.Edad, resultado.DireccionCliente, resultado.TelefonoCliente);
        //    return resultado;
        //}

        //public async Task Save(Cliente cliente)
        //{
        //    await _mongoContext.Cliente.InsertOneAsync(cliente);
        //}
        //public Task<List<Cliente>> GetClientesByAge(int age)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task AcceptChanges()
        //{
        //    throw new NotImplementedException();

        //}

        Task<List<Cliente>> IClienteRepository.GetClientesByAge(int age)
        {
            throw new NotImplementedException();
        }

        //public async Task Save(Dominio.Entidades.Cliente entity)
        //{
        //    var cliente = new Cliente(entity.Nombre, entity.Apellido, entity.Edad, entity.Direccion, entity.Telefono);
        //    await _mongoContext.Cliente.InsertOneAsync(cliente);
        //}
    }
}
