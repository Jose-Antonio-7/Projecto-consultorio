using Consultorio.Aplicacion.Servicios;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using Consultorio.infraestructura.SqlServer.Repositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Consultorio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //Seguridad
            builder.Services.AddAuthentication(opt =>
                {
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;


                }
            ).AddJwtBearer(opt =>
            opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = "http://localhost:7256",
                    ValidAudience = "http://localhost:7256",
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("passwordSuperSecreto"))
                }
            );


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
            //builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "WebAPI",
                    Description = "Product WebAPI"
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Bearer Authentication with JWT Token",
                    Type = SecuritySchemeType.Http
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                 {
                     {
                     new OpenApiSecurityScheme
                     {
                     Reference = new OpenApiReference
                     {
                     Id = "Bearer",
                     Type = ReferenceType.SecurityScheme
                     }
                     },
                     new List<string>()
                     }
                     });
                });



            var app = builder.Build();



            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())

            {

                app.UseSwagger();

                //app.UseSwaggerUI();

                app.UseSwaggerUI(options => {

                    options.SwaggerEndpoint("/swagger/V1/swagger.json", "Product WebAPI");

                });

            }







            //var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}