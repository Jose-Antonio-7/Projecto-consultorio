﻿using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.infraestructura.SqlServer.Repositorios
{
    public class ConsultasRepository : Repository<Consulta>, IConsultasRepository
    {
        private readonly Context _context;
        public ConsultasRepository(Context context): base(context)
        {
            _context = context;
        }

        public List<Consulta> GetCustormerAllDates(string clienteId)
        {
            var citas = _context.Consultas.Where(c => c.ClienteId == clienteId).ToList();
            return citas;
        }

        public List<Consulta> GetCustormerDates(string clienteId, DateTime fecha)
        {
            var citas = _context.Consultas.Where(c => c.ClienteId == clienteId
            && c.FechaConsulta.Date == fecha.Date).ToList();
            return citas;
        }

        public List<Consulta> GetDoctorDates(string doctorId, DateTime fecha)
        {
            var citas = _context.Consultas.Where(c => c.DoctorId == doctorId 
            && c.FechaConsulta.Date == fecha.Date).ToList();
            return citas;
        }
    }
}
