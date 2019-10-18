using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MoviesOnline.Data.Entities;
using MoviesOnline.Data.Repositories;
using MoviesOnline.Helper;

namespace MoviesOnline.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieRepository repository = new MovieRepository();
            var list = repository.getMovies();
            var model = MapHelper.Map<IEnumerable<Models.MovieList>>(list);

            return View(model);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Movie movie = new Movie();
                movie.Title = collection.Get("Title");
                movie.Director = collection.Get("Director");
                movie.Duration =float.Parse( collection.Get("Duración"));
                movie.year =int.Parse(collection.Get("Year"));

                MovieRepository repository = new MovieRepository();
                if (repository.save(movie) > 0)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("algo mal");
                }
                               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
