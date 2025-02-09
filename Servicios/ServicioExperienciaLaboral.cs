using MisministrosCR_VERSION1.Models;
using Newtonsoft.Json;
using System.Drawing;
using System.Text;

namespace MisministrosCR_VERSION1.Servicios
{
    public class ServicioExperienciaLaboral :IServicioExperiencialaboral
    {
        

        public  async Task<Oferente> Buscar(string id)
        {
            Oferente oferente = new Oferente();
            String url = "http://localhost:5103/api/Experiencia_trabajo/" + id;
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

        public async Task<bool> Insertar(Experiencia_trabajo exptrabajo)
        {
            // URL de la API
            string url = "http://localhost:5103/api/Experiencia_trabajo";

            // Convertir el Oferente a JSON
            string json = JsonConvert.SerializeObject(exptrabajo);

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

        public Task<Oferente> Actualizar_ExpLaboral() {


            return null;
        }

    }
}
