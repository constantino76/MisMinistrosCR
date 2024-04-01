using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisministrosCR_VERSION1.Models;
using MisministrosCR_VERSION1.Servicios;

namespace MisministrosCR_VERSION1.Controllers
{
    public class ExperienciaLaboralController : Controller
    {
        private readonly IOferente ioferente;



        public ExperienciaLaboralController(IOferente _ioferente) { 
        
        
        ioferente=_ioferente;   
        
        }
        // GET: ExperienciaLaboralController
        public async Task<IActionResult> Index(string id="")
        {
            //Oferente  oferente = new Oferente();
            //OferenteHijo cn = new OferenteHijo();

            if (!String.IsNullOrEmpty(id)) { 
            
            
               Oferente  oferente=  await ioferente.Buscar(id);
                if (oferente != null)
                {
                    ViewBag.Nombre = oferente.Nombre;

                    return RedirectToAction("RegistroExperienciaLaboral");
                }
            }
            return  View();
          
        }

        // GET: ExperienciaLaboralController/Details/5
        public ActionResult RegistroExperienciaLaboral()
        {
            return View();
        }

        [HttpPost]

        public ActionResult RegistroExperienciaLaboral(Experiencia_trabajo _Trabajo) {
             return RedirectToAction("index");





            }


            // GET: ExperienciaLaboralController/Create
            public ActionResult RegistroTitulos()
            {
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

