using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using Consultorio.infraestructura.SqlServer.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //Configurar conexion a base de datos, para el intyector de dependencias, definismoa como crear lo que se necesita en parametros constructores
            
            var conectionString = builder.Configuration.GetConnectionString("SQLServer");
            builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(conectionString));

            builder.Services.AddScoped<ClienteService>();
            builder.Services.AddScoped<ConsultasServices>();

            //Agregado por mi para inyecccion de dependencias
            builder.Services.AddScoped<DoctorService>();


            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

            //Agregado por mi para inyecccion de dependencias
            builder.Services.AddScoped<IConsultasRepository, ConsultasRepository>();
            //builder.Services.AddScoped < IConsultasRepository, ConsultasRepository, IClienteRepository ClienteRepository, IRepositoryDoctor DoctorRepository > ();
            builder.Services.AddScoped<IRepositoryDoctor, DoctorRepository>();



            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}