using Microsoft.AspNetCore.Mvc;
using MisministrosCR_VERSION1.Models;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MisministrosCR_VERSION1.Servicios
{
    public class OferenteHijo : IOferente
    {
      

        public async Task<ActionResult<Oferente>> Buscar(string id)
        {

            Oferente oferente = new Oferente();
            String url = "http://localhost:5103/api/Oferentes/" + id;
            using var apirest = new HttpClient();
            HttpResponseMessage respuesta = await apirest.GetAsync(url);



            if (respuesta.IsSuccessStatusCode)
            {
                var Respuesta = respuesta.Content.ReadAsStringAsync().Result;
                oferente = JsonConvert.DeserializeObject<Oferente>(Respuesta);
                return oferente;
            }

            return null;
        }

        public async Task<bool> Insertar(Oferente oferente)
        {
            asignarId(oferente);
            asignarId_(oferente);



            // URL de la API
            string url = "http://localhost:5103/api/Oferentes";

            // Convertir el Oferente a JSON
            string json = JsonConvert.SerializeObject(oferente);

            // Crear una solicitud HTTP
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content);

                // Verificar el estado de la respuesta
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Manejar el error
                    Console.WriteLine("Error al enviar el Oferente: " + response.StatusCode);
                   
                }
            }
            return false;
        }
            public async Task<Oferente> VerOferentes()
            {
                String url = "http://localhost:5103/api/Oferentes/";
                using var apirest = new HttpClient();
                HttpResponseMessage respuesta = await apirest.GetAsync(url);



                if (respuesta.IsSuccessStatusCode)
                {
                    var Respuesta = respuesta.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<Oferente>(Respuesta);
                    return lista;
                }

                return null;
            }




        public async Task<bool> Actualizar(Oferente oferente)
        {
            asignarId(oferente);
            asignarId_(oferente);

            string url = "http://localhost:5103/api/Oferentes/" + oferente.OferenteId;

            // Convertir el Oferente a JSON
            string json = JsonConvert.SerializeObject(oferente);

            // Crear una solicitud HTTP
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(url, content);

                // Verificar el estado de la respuesta
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Manejar el error
                    Console.WriteLine("Error al enviar el Oferente: " + response.StatusCode);
                    return false;
                }

            }
                return false;
            }

        public void asignarId(Oferente oferente)
        {

            foreach (var n in oferente.titulos)
            {


                if (n.OferenteId == null)
                {
                    n.OferenteId = oferente.OferenteId;

                }

            }
        }

        public void asignarId_(Oferente oferente)
        {
            foreach (var n in oferente.list_Experiencia_laboral)
            {


                if (n.OferenteId == null)
                {
                    n.OferenteId = oferente.OferenteId;

                }

            }
        }


    } }