﻿using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Repositorios;
//using Consultorio.Infraestructura.TextFile.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Aplicacion.Servicios
{
    public class DoctorService
    {
        private readonly IRepositoryDoctor _repo;
        private readonly Context _context;


        public DoctorService(Context context)
        {
            _context = context;

            _repo = new DoctorRepository(_context);
        }

        public void Almacenar(Doctor doctor)
        {
            _repo.Save(doctor);
            _repo.AcceptChanges();


        }

        public List<Doctor> ConsultarTodos()
        {
            return _repo.GetAll();
        }

        //public void CrearDoctor()
    }
}
