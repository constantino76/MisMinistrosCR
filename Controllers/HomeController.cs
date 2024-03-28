﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using MisministrosCR_VERSION1.Models;
using MisministrosCR_VERSION1.Datos;
using System.Diagnostics;
using MisministrosCR_VERSION1.EnlaceAppi;

namespace MisministrosCR_VERSION1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache cache;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IMemoryCache _cache)
        {
            _logger = logger;
            cache= _cache;  
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            Oferente of = new Oferente();
            of.titulos.Add(new Titulo() { Anio_titulo = 1900 });
            of.list_Experiencia_laboral.Add(new Experiencia_trabajo() {   Nombre_Empresa="Sardimar",Anio_inicio=2010 });
            ViewBag.Ministerios = getMinisterios();
          
            return View(of);
        }

        [HttpPost]
        public ActionResult Registro(Oferente oferente,String Ministerios)
        {
            oferente.Puesto = Ministerios;
            //Conexion cn = new Conexion(cache);
            //List<Oferente>listado= cn.obetenerOferentes();
            //listado.Add(oferente);
            ConexionAppi cn = new ConexionAppi();
            cn.Insertar(oferente);
            ViewBag.Ministerios = getMinisterios();
            return RedirectToAction("Registro");
        }
        public IActionResult EditarOferente(String id ="") { 
       
        return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private List<SelectListItem> getMinisterios()
        {
            return new List<SelectListItem>
            {

            new SelectListItem{Text="Ministerio de agricultura y ganaderia (MAG)",
            },
            new SelectListItem{
                Text="Ministerio de Ambiente, Energía y Telecomunicaciones (MINAET)",
           
            },
            new SelectListItem{
            Text="Ministerio de justicia",
            },
            new SelectListItem{
              Text="Ministerio de Planificación y Política Económica (MIDEPLAN)"

              },
            new SelectListItem{ Text="Ministerio de Ciencia y Tecnología (MICIT)",
            },
            new SelectListItem{

            Text="Ministerio de Planificación y Política Económica (MIDEPLAN)",
             
            }


            };

           

        }
        public List<SelectListItem> get_Estado()
        {

            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "En proceso",
                    Value = "1"
                },

                new SelectListItem
                {
                    Text = "En",
                    Value = "1"
                },




            };
        }
    }
}