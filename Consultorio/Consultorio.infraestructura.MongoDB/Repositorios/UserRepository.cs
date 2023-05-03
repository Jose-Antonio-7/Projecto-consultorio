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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly MongoContext _mongoContext;
        private readonly IMongoCollection<User> _collection;


        public UserRepository()
        {
            _mongoContext = new MongoContext();
            _collection = _mongoContext.database.GetCollection<User>(GetCollectionName(typeof(User)));

        }

        public async Task<User> GetClientesByLogin(string login)
        {
            return await _collection.Find(x => x.Login.Equals(login)).FirstOrDefaultAsync();

            //return await _mongoContext.User.Find(x => x.Login.Equals(login)).FirstOrDefaultAsync();
            //throw new NotImplementedException();

        }
    }
}
