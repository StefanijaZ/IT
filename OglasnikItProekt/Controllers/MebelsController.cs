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
    public class MebelsController : Controller
    {
        private DbMeb db = new DbMeb();

        // GET: Mebels
        public ActionResult Index()
        {
            return View(db.mebs.ToList());
        }

        // GET: Mebels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mebel mebel = db.mebs.Find(id);
            if (mebel == null)
            {
                return HttpNotFound();
            }
            return View(mebel);
        }

        // GET: Mebels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mebels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MebelID,imgURL,Ime,Lokacija,Cena,Opis")] Mebel mebel)
        {
            if (ModelState.IsValid)
            {
                db.mebs.Add(mebel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mebel);
        }

        // GET: Mebels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mebel mebel = db.mebs.Find(id);
            if (mebel == null)
            {
                return HttpNotFound();
            }
            return View(mebel);
        }

        // POST: Mebels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MebelID,imgURL,Ime,Lokacija,Cena,Opis")] Mebel mebel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mebel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mebel);
        }

        // GET: Mebels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mebel mebel = db.mebs.Find(id);
            if (mebel == null)
            {
                return HttpNotFound();
            }
            return View(mebel);
        }

        // POST: Mebels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mebel mebel = db.mebs.Find(id);
            db.mebs.Remove(mebel);
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
