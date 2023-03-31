using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Infraestructura.TextFile.Repositorios
{
    public class ClienteRepository
    {
        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\Antonio\\Desktop\\Programas mios\\C#\\ClientesCore.txt", true);

            writer.Write(cliente);
            writer.Close();
            writer.Dispose();
        }
    }
}
