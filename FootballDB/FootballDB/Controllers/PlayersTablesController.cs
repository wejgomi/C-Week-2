using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootballDB.Models;

namespace FootballDB.Controllers
{
    public class PlayersTablesController : Controller
    {
        private FootballPlayersEntities db = new FootballPlayersEntities();

        // GET: PlayersTables
        public ActionResult Index()
        {
            return View(db.PlayersTables.ToList());
        }

        // GET: PlayersTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayersTable playersTable = db.PlayersTables.Find(id);
            if (playersTable == null)
            {
                return HttpNotFound();
            }
            return View(playersTable);
        }

        // GET: PlayersTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayersTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age,Place_of_Birth,Height,Playing_Position,Current_Team,National_Team")] PlayersTable playersTable)
        {
            if (ModelState.IsValid)
            {
                db.PlayersTables.Add(playersTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playersTable);
        }

        // GET: PlayersTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayersTable playersTable = db.PlayersTables.Find(id);
            if (playersTable == null)
            {
                return HttpNotFound();
            }
            return View(playersTable);
        }

        // POST: PlayersTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age,Place_of_Birth,Height,Playing_Position,Current_Team,National_Team")] PlayersTable playersTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playersTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playersTable);
        }

        // GET: PlayersTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayersTable playersTable = db.PlayersTables.Find(id);
            if (playersTable == null)
            {
                return HttpNotFound();
            }
            return View(playersTable);
        }

        // POST: PlayersTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayersTable playersTable = db.PlayersTables.Find(id);
            db.PlayersTables.Remove(playersTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
