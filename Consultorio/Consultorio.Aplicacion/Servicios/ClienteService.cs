using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.infraestructura.SqlServer.Repositorios;
//using Consultorio.Infraestructura.TextFile.Repositorios;
using Consultorio.infraestructura.SqlServer.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Consultorio.Aplicacion.Servicios
{
    public class ClienteService
    {
        private readonly IClienteRepository _repo;
        private readonly Context _context;
        private readonly ILogger<ClienteService> _logger;


        public ClienteService(Context context, IClienteRepository repo, ILogger<ClienteService> logger)
        {
            _context = context;
            _repo = repo;
            _logger = logger;
            //_repo = new ClienteRepository(_context);
        }

        public async Task Almacenar(Cliente cliente)
        {
            _repo.Save(cliente);
            await _repo.AcceptChanges();

        }

        public async Task<List<Cliente>> ConsultarTodos()
        {
            return await _repo.GetAll();
        }

        public async Task<Cliente> ConsultarCliente(string id)
        {
            return await _repo.GetById(id);
        }

    }
}