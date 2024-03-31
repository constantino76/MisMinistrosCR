using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MisministrosCR_VERSION1.Controllers
{
    public class ExperienciaLaboralController : Controller
    {
        // GET: ExperienciaLaboralController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExperienciaLaboralController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExperienciaLaboralController/Create
        public ActionResult Create()
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
