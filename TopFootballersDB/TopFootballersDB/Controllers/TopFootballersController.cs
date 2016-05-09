﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopFootballersDB.Models;
using System.ComponentModel.DataAnnotations;
namespace TopFootballersDB.Controllers
{
    public class TopFootballersController : Controller
    {
        private TopFootballersDBEntities db = new TopFootballersDBEntities();
        // GET: TopFootballers
        public ActionResult Index(string playerName, string searchString)
        {
            var nameList = new List<string>();
            var nameQuery = from nameData in db.TopFootballersTables orderby nameData.Player_Name select nameData.Player_Name;
            nameList.AddRange(nameQuery.Distinct());
            ViewBag.playerName = new SelectList(nameList);

            var footballPlayers = from m in db.TopFootballersTables select m;


            //Title search
            if (!String.IsNullOrEmpty(searchString))//checks if the search box is not empty
            {
                footballPlayers = footballPlayers.Where(s => s.Player_Name.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(playerName))
            {
                footballPlayers = footballPlayers.Where(x => x.Player_Name == playerName);
            }
            return View(footballPlayers);


        }

        //Details View
        public ActionResult Details(int? id)
        {
            TopFootballersTable football = db.TopFootballersTables.Find(id);
            return View(football);
        }
        //Create View 
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([Bind(Include = "Id, Player_Name, Age, Place_of_Birth, Height, Playing_Position, Current_Team, National_Team, Description, Picture")] TopFootballersTable football)
        {
            if (ModelState.IsValid)
            {
                //adding database record here
                db.TopFootballersTables.Add(football);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(football);
        }

        //Edit View
        public ActionResult Edit(int? id)
        {
            TopFootballersTable football = db.TopFootballersTables.Find(id);
            return View(football);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Player_Name, Age, Place_of_Birth, Height, Playing_Position, Current_Team, National_Team, Description, Picture")] TopFootballersTable football)
        {
            if (ModelState.IsValid)
            {
                //Editing database record here
                db.Entry(football).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(football);
        }

        //Delete View
        public ActionResult Delete(int? id)
        {
            TopFootballersTable movie = db.TopFootballersTables.Find(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TopFootballersTable football = db.TopFootballersTables.Find(id);

            //deleting database record here
            db.TopFootballersTables.Remove(football);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}