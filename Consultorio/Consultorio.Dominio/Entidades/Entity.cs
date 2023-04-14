using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    public class Entity
    {
        public string Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
