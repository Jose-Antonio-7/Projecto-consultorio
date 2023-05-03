using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    [BsonCollection("Users")]
    public class User : Entity
    {
        //public string Id { get; private set; }

        public string Login { get; set; }
        public string Contraseña { get; set; }

        public User(string login, string contraseña)
        {

            Login = login;
            Contraseña = contraseña;
        }
    }
}
