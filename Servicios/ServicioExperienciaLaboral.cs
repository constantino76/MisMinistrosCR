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

        public Task<Oferente> Buscar(string id)
        {
            throw new NotImplementedException();
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
