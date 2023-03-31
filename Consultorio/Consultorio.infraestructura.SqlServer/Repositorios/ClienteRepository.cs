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

        //public List<Cliente> GetAll()
        //{
        //    return _context.Clientes.ToList();
        //}

        public List<Cliente> GetClientesByAge(int age)
        {
            throw new NotImplementedException();
        }

        //public void Save(Cliente cliente)
        //{
        //    _context.Clientes.Add(cliente);
        //    _context.SaveChanges();

        //}
    }
}
