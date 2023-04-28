using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.MongoDB.Context
{
    public class MongoDBDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        //public string CollectionName { get; set; } = null!;

        //public string DoctoresCollectionName { get; set; } = null!;

        //public string UsersCollectionName { get; set; } = null!;

        //public string ConsultasCollectionName { get; set; } = null!;

    }
}
