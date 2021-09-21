using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OglasnikItProekt.Models;

namespace OglasnikItProekt.Controllers
{
    public class MobilensController : Controller
    {
        private DbMob db = new DbMob();

        // GET: Mobilens
        public ActionResult Index()
        {
            return View(db.mobs.ToList());
        }

        // GET: Mobilens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobilen mobilen = db.mobs.Find(id);
            if (mobilen == null)
            {
                return HttpNotFound();
            }
            return View(mobilen);
        }

        // GET: Mobilens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mobilens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MobilenID,imgURL,Ime,Lokacija,Cena,Opis")] Mobilen mobilen)
        {
            if (ModelState.IsValid)
            {
                db.mobs.Add(mobilen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mobilen);
        }

        // GET: Mobilens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobilen mobilen = db.mobs.Find(id);
            if (mobilen == null)
            {
                return HttpNotFound();
            }
            return View(mobilen);
        }

        // POST: Mobilens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MobilenID,imgURL,Ime,Lokacija,Cena,Opis")] Mobilen mobilen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mobilen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mobilen);
        }

        // GET: Mobilens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobilen mobilen = db.mobs.Find(id);
            if (mobilen == null)
            {
                return HttpNotFound();
            }
            return View(mobilen);
        }

        // POST: Mobilens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mobilen mobilen = db.mobs.Find(id);
            db.mobs.Remove(mobilen);
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
