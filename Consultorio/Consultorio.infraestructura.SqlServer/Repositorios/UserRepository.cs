using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.SqlServer.Repositorios
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context) : base(context)
        {
            _context = context;
        }



        public User GetClientesByLogin(string login)
        {
            var usuario = _context.Users.Where(c => c.Login == login).FirstOrDefault();
            return usuario;
        }
    }
}
