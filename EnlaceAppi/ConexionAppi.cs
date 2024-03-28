using MisministrosCR_VERSION1.Models;
using Newtonsoft.Json;
using System.Text;

namespace MisministrosCR_VERSION1.EnlaceAppi
{
    public class ConexionAppi {
        // Insertar clientes
        public  async Task<Boolean> Insertar(Oferente oferente) {

            asignarId(oferente);
            asignarId_(oferente);

            //var json = JsonConvert.SerializeObject(oferente);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //var url = "http://localhost:5231/api/Oferentes";
            //using var apirest = new HttpClient();
            //var respuesta = await apirest.PostAsync(url, data);
            //string result = respuesta.Content.ReadAsStringAsync().Result;

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
                    return false;
                }
            }



            return true;
        
        }
        public void asignarId(Oferente oferente) {

            foreach (var n in oferente.titulos) {


                if (n.OferenteId == null) {
                    n.OferenteId = oferente.OferenteId;
                
                }
            
            }
        
        }
        public void asignarId_(Oferente oferente){

            foreach (var n in oferente.list_Experiencia_laboral)
            {


                if (n.OferenteId == null)
                {
                    n.OferenteId = oferente.OferenteId;

                }

            }



        }
   
    }
}
