using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using Microsoft.EntityFrameworkCore;
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

        public async Task AcceptChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(string id)
        {
            return await _context.Set<T>().Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task Save(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
    }
}
