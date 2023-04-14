using Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Presentacion.Modelos
{
    public class AuthContext
    {
        public User Usuario { get; set; }

        public String Token { get; set; }
    }
}
