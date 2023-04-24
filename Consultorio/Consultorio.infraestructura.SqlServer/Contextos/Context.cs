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
                .HasKey(e => e.Id);

            model.Entity<Cliente>()
                .Property(e => e.Nombre)
                .HasColumnName("NombreCliente")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin nombre")
                .IsRequired();

            model.Entity<Cliente>()
                .Property(e => e.Apellido)
                .HasColumnName("ApellidoCliente")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin apellido")
                .IsRequired();

            model.Entity<Cliente>()
                .Property(e => e.Direccion)
                .HasColumnName("DireccionCliente")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin direccion");

            model.Entity<Cliente>()
                .Property(e => e.Telefono)
                .HasColumnName("TelefonoCliente")
                .HasColumnType("nvarchar")
                .HasMaxLength(12)
                .HasDefaultValue("Sin numero");



            model.Entity<Doctor>()
                .ToTable("Doctores")
                .HasKey(e => e.Id);

            model.Entity<Doctor>()
                .Property(e => e.Cedula)
                .HasColumnName("CedulaDoctor")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin cedula")
                .IsRequired();

            model.Entity<Doctor>()
                .Property(e => e.Nombre)
                .HasColumnName("NombreDoctor")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin nombre")
                .IsRequired();

            model.Entity<Doctor>()
                .Property(e => e.Apellido)
                .HasColumnName("ApellidoDoctor")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin apellido")
                .IsRequired();

            model.Entity<Doctor>()
                .Property(e => e.Telefono)
                .HasColumnName("TelefonoDoctor")
                .HasColumnType("nvarchar")
                .HasMaxLength(12)
                .HasDefaultValue("Sin numero");


            model.Entity<Consulta>()
                .ToTable("Consultas")
                .HasKey(e => e.Id);

            model.Entity<Consulta>()
                .Property(e => e.Direccion)
                .HasColumnName("DireccionConsulta")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin direccion")
                .IsRequired();


            model.Entity<User>()
                .ToTable("Users")
                .HasKey(e => e.Id);

            model.Entity<User>()
                .Property(e => e.Login)
                .HasColumnName("LoginUser")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin login")
                .IsRequired();

            model.Entity<User>()
                .Property(e => e.Contraseña)
                .HasColumnName("ContraseñaUser")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasDefaultValue("Sin Contraseña")
                .IsRequired();



        }

        //public DbSet<Doctor> Doctoresprueba { get; set; }

    }
}
