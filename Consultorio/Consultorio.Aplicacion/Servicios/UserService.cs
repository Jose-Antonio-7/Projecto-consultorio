using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
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

        public void Almacenar(User user)
        {
            _repo.Save(user);
            _repo.AcceptChanges();

        }

        public List<User> ConsultarTodos()
        {
            return _repo.GetAll(); //corregir despues para hacerlo async
        }

        public User ConsultarUser(string login)
        {
            return _repo.GetClientesByLogin(login);
        }
    }
}
