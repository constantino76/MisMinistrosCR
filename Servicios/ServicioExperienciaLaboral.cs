using MisministrosCR_VERSION1.Models;
using Newtonsoft.Json;
using System.Drawing;
using System.Text;

namespace MisministrosCR_VERSION1.Servicios
{
    public class ServicioExperienciaLaboral : IServicioExperiencialaboral
    {
        public Task<Oferente> Actualizar()
        {
            throw new NotImplementedException();
        }

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
            String url = "http://localhost:5103/api/Experiencia_Trabajo";

            string json =JsonConvert.SerializeObject(exptrabajo);

            using ( var httpclient = new HttpClient()) {

               var content =  new  StringContent(json, Encoding.UTF8, "application/json");

                var respuesta = httpclient.PostAsync(url,content);


                if (respuesta.IsCompleted) {


                    return   true;
                
                }

            }
            return false;
                
        }
    }
}
