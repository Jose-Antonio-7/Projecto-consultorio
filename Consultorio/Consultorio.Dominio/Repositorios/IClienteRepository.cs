using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Repositorios
{
    public interface IClienteRepository :IRepository<Cliente>
    {

        Task<List<Cliente>> GetClientesByAge(int age);

    }
}
