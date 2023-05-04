using Consultorio.Dominio.Entidades;
using Consultorio.Presentacion.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Presentacion.Services
{
    internal class DoctorService
    {
        private readonly AuthContext _authContext;
        public DoctorService(AuthContext authContext)
        {
            _authContext = authContext;
        }
        internal async Task<List<Doctor>> ConsultarTodos()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authContext.Token);
                var result = await httpClient.GetFromJsonAsync<List<Doctor>>(
                    "https://localhost:7256/v1/doctores");

                return result;

            }
        }
        internal async Task Almacenar(Doctor doctor)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authContext.Token);
                var json = JsonConvert.SerializeObject(doctor);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                await httpClient.PostAsync("https://localhost:7256/v1/doctores", content);
            }
        }
    }
}
