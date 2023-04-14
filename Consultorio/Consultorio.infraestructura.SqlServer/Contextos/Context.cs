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

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Cliente>()
                .ToTable("Clientes")
                .HasKey(e=>e.Id);

            model.Entity<Cliente>()
                .Property(e => e.Nombre)
                .HasColumnName("NombreCliente")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin nombre")
                .IsRequired();

        }

        //public DbSet<Doctor> Doctoresprueba { get; set; }

    }
}
