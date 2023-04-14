using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Repositorios
{
    public interface IUserRepository : IRepository<User>
    {
        User GetClientesByLogin(string login);

    }
}
