using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Presentacion.Services
{
    internal class ClienteService
    {
        //private readonly IClienteRepository _repo;
        //private readonly Context _context;

        //public ClienteService(Context context, IClienteRepository repo)
        //{
        //    _context = context;
        //    _repo = repo;
        //}

        internal async  Task<List<Cliente>> ConsultarTodos()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.GetFromJsonAsync<List<Cliente>>(
                    "https://localhost:7256/v1/clientes");

                return result;

            }
        }

        internal async Task Almacenar(Cliente cliente)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                await httpClient.PostAsync("https://localhost:7256/v1/clientes", content);

                
            }
        }
    }
}
