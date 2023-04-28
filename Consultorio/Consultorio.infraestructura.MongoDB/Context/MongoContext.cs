﻿using MongoDB.Driver;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Consultorio.infraestructura.MongoDB.Models;
//using Consultorio.Dominio.Entidades;

namespace Consultorio.infraestructura.MongoDB.Context
{
    public class MongoContext
    {

        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;
        public IConfigurationRoot Configuration { get; }

        public MongoContext()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            mongoClient = new MongoClient(Configuration["MongoDBDatabase:ConnectionString"]);
            database = mongoClient.GetDatabase(Configuration["MongoDBDatabase:DatabaseName"]);
        }

        public IMongoCollection<Dominio.Entidades.Cliente> Cliente
        {
            get
            {
                return database.GetCollection<Dominio.Entidades.Cliente>("Clientes");
            }
        }
    }
}