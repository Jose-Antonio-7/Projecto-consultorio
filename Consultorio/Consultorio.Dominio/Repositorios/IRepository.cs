using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Dominio.Repositorios
{
    public interface IRepository<TEntity>
    {

        Task Save(TEntity entity);

        Task<List<TEntity>> GetAll();

        Task AcceptChanges();

        Task<TEntity> GetById(string id);

    }
}
