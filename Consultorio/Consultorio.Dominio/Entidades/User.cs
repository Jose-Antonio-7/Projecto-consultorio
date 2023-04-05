using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    public class User
    {
        public string Login { get; set; }
        public string Contraseña { get; set; }

        public User(string login, string contraseña)
        {
            Login = login;
            Contraseña = contraseña;
        }
    }
}
