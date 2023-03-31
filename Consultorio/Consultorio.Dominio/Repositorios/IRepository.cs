using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Repositorios
{
    public interface IRepository<TEntity>
    {

        void Save(TEntity entity);

        List<TEntity> GetAll();

        void AcceptChanges();

        TEntity GetById(string id);

    }
}
