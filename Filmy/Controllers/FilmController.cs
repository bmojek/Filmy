using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Filmy.Models;

namespace Filmy.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmsDbContex _contex;
        public FilmController(FilmsDbContex contex)
        {
            _contex = contex;
        }

        // GET: FilmController
        public ActionResult Index()
        {
            return View(_contex.Films.ToList());
        }
        
        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(_contex.Films.Find(id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {
                _contex.Films.Add(film);
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_contex.Films.Find(id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            try
            {
                _contex.Films.Update(film);
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_contex.Films.Find(id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            try
            {
                _contex.Films.Remove(film);
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
    }
}
