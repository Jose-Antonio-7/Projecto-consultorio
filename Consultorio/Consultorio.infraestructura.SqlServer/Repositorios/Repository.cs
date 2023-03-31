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
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly Context _context;

        protected Repository(Context context)
        {
            _context = context;
        }

        public void AcceptChanges()
        {
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(string id)
        {
            return _context.Set<T>().Where(e => e.Id == id).FirstOrDefault();
        }

        public void Save(T entity)
        {
            _context.Set<T>().Add(entity);
        }
    }
}
