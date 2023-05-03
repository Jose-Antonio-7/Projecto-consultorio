using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
//using Consultorio.infraestructura.MongoDB.Context;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Aplicacion.Servicios
{
    public class UserService
    {
        private readonly IUserRepository _repo;
        private readonly Context _context;


        public UserService(Context context, IUserRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        public async Task Almacenar(User user)
        {
            _repo.Save(user);
            await _repo.AcceptChanges();

        }

        public async Task<List<User>> ConsultarTodos()
        {
            return await _repo.GetAll(); //corregir despues para hacerlo async
        }

        public async Task<User> ConsultarUser(string login)
        {
            return await _repo.GetClientesByLogin(login);
        }
    }
}
