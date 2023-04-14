using Consultorio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.SqlServer.Contextos
{
    public class Context: DbContext
    {

        public Context(DbContextOptions options): base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    //options.UseSqlite("Data Source = C:\\Users\\Antonio\\Desktop\\Programas mios\\C#\\consultorio.bd");

        //    options.UseSqlServer(@"Server = DESKTOP-RQBKGG3; Database = Consultorio; Trusted_connection = yes");

        //    //options.UseSqlServer(@"Server = DESKTOP-RQBKGG3; Database = Consultorio; Trusted_connection = yes");

        //}

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Doctor> Doctores { get; set; }

        public DbSet<Consulta> Consultas { get; set; }

        public DbSet<User> Users { get; set; }


        //public DbSet<Doctor> Doctoresprueba { get; set; }

    }
}
