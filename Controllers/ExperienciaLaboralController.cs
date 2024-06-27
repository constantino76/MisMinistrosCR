using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisministrosCR_VERSION1.Models;
using MisministrosCR_VERSION1.Servicios;
using Newtonsoft.Json;
using System.Text;

namespace MisministrosCR_VERSION1.Controllers
{
    public class ExperienciaLaboralController : Controller
    {
        private readonly IOferente ioferente;

        private readonly IServicioExperiencialaboral  expelaboral;

        public ExperienciaLaboralController(IServicioExperiencialaboral _explaboral) {


            expelaboral =_explaboral;


        }
        // GET: ExperienciaLaboralController
        public async Task<IActionResult> BuscarOferente(string id="")
        {
            //Oferente  oferente = new Oferente();
            //OferenteHijo cn = new OferenteHijo();

            if (!String.IsNullOrEmpty(id)) { 
            
            
               var  oferente=  await ioferente.Buscar(id);
                if (oferente != null)
                {
                   ViewBag.Id = oferente.OferenteId;
                    ViewBag.Nombre = oferente.Nombre;
                    // retornamos  en caso de encontrar un oferente con el id ingreado   a otra vista para registrar sus datos
                    return RedirectToAction("RegistroExperienciaLaboral" ,new { id, oferente.Nombre});
                }
            }
            return  View();
          
        }
        public ActionResult BuscarOferenteEdit(String id = "") {
            if (!String.IsNullOrEmpty(id)) {

                return RedirectToAction("EditarExperienciaLaboral", new { OfrenteId = id});

            }
            return View();
        }
        public ActionResult EditarExperienciaLaboral(String OferenteId) {

           
            return View();
        
        
        }




        // GET: ExperienciaLaboralController/Details/5
        public ActionResult RegistroExperienciaLaboral(String id ,string Nombre)
        {
            ViewBag.Id = id;
            ViewBag.Nombre=Nombre;  
            return View();
        }

        [HttpPost]

        public ActionResult RegistroExperienciaLaboral(String Nombreempresa, String Anioinicio,String Aniofinal) {

           Experiencia_trabajo _trabajo = new Experiencia_trabajo();
    
           _trabajo.Nombre_Empresa=Nombreempresa;
           _trabajo.Anio_inicio =Convert.ToInt32( Anioinicio);
            _trabajo.Anio_fin =  Convert.ToInt32(Aniofinal);

           
            return View();
         





            }


            // GET: ExperienciaLaboralController/Create
            public ActionResult Editar(String id="")
            {

            if (!String.IsNullOrEmpty(id)) { 
            
            
            }
                return View();
            }
        [HttpPost]
        public ActionResult Editar(Experiencia_trabajo exp) {

            return View();
        
        }
            // POST: ExperienciaLaboralController/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(IFormCollection collection)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: ExperienciaLaboralController/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: ExperienciaLaboralController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, IFormCollection collection)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: ExperienciaLaboralController/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: ExperienciaLaboralController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        }
    } 

