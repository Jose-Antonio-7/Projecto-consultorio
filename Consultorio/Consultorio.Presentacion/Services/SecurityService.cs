using Consultorio.Dominio.Entidades;
using Consultorio.Dominio.Repositorios;
using Consultorio.Presentacion.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Presentacion.Services
{
    internal class SecurityService
    {

        internal async Task<AuthContext> Login(User user)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");//Serializacion: convertir un objeto a un formato de archivo, jason por ejemplo

                var result = await httpClient.PostAsync("https://localhost:7256/api/v1/login", content);


                //prueba mia de token
                if (result.IsSuccessStatusCode)
                {
                    var tokenString = await result.Content.ReadAsStringAsync();

                    AuthContext authContext = new AuthContext()
                    {
                        Usuario = user,
                        Token = tokenString

                    };

                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenString);

                    return authContext;
                }

                return null;

            }
        }
    }
}
