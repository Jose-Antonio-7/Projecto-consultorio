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
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly Context _context;

        public ClienteRepository(Context context):base(context)
        {
            _context = context;
        }

      

        //public List<Cliente> GetClientesByAge(int age)
        //{
        //    throw new NotImplementedException();
        //}

        Task<List<Cliente>> IClienteRepository.GetClientesByAge(int age)
        {
            throw new NotImplementedException();
        }
    }
}
