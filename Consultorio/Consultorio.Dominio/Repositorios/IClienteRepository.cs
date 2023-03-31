using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Repositorios
{
    public interface IClienteRepository :IRepository<Cliente>
    {

        List<Cliente> GetClientesByAge(int age);

    }
}
