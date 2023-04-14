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
    internal class UserService
    {
        private readonly AuthContext authContext;
        public UserService(AuthContext authContext)
        {
            this.authContext = authContext;
        }
        internal async Task Almacenar(User user)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authContext.Token);
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                await httpClient.PostAsync("https://localhost:7256/v1/users", content);


            }
        }

    }
}
