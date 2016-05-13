using MvcMoviesDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcMoviesDB.Controllers
{
    public class HomeController : Controller
    {
        private MvcMoviesDatabaseEntities db = new MvcMoviesDatabaseEntities();
        // GET: Home
        public ActionResult Index(string s, String g)
        {
            var movies = from m in db.Movies
                         select m;
            var GenreList = new List<String>();
            var GenreQuery = from m in db.Movies orderby m.Genre select m.Genre;

            GenreList.AddRange(GenreQuery.Distinct());
            ViewBag.Genre = new SelectList(GenreList);

            if(!String.IsNullOrEmpty(g))
            {
                movies = movies.Where(x => x.Genre.Contains(g));
            }

            if(!String.IsNullOrEmpty(s))
            {
                movies = movies.Where(x => x.Title.Contains(s));
            }

            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID, Title, ReleaseDate, Genre, Price")] Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Add(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Add([Bind(Include = "ID, Title, ReleaseDate, Genre, Price")] Movie movie)
        {
            //db.Entry(movie).State = EntityState.Modified;
            db.Movies.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}