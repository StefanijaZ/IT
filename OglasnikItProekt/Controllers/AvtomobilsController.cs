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
    public class AvtomobilsController : Controller
    {
        private DbAvto db = new DbAvto();

        // GET: Avtomobils
        public ActionResult Index()
        {
            return View(db.avtos.ToList());
        }

        // GET: Avtomobils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avtomobil avtomobil = db.avtos.Find(id);
            if (avtomobil == null)
            {
                return HttpNotFound();
            }
            return View(avtomobil);
        }

        // GET: Avtomobils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Avtomobils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AvtomobilID,imgURL,Ime,Lokacija,Cena,Opis")] Avtomobil avtomobil)
        {
            if (ModelState.IsValid)
            {
                db.avtos.Add(avtomobil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(avtomobil);
        }

        // GET: Avtomobils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avtomobil avtomobil = db.avtos.Find(id);
            if (avtomobil == null)
            {
                return HttpNotFound();
            }
            return View(avtomobil);
        }

        // POST: Avtomobils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AvtomobilID,imgURL,Ime,Lokacija,Cena,Opis")] Avtomobil avtomobil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avtomobil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(avtomobil);
        }

        // GET: Avtomobils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avtomobil avtomobil = db.avtos.Find(id);
            if (avtomobil == null)
            {
                return HttpNotFound();
            }
            return View(avtomobil);
        }

        // POST: Avtomobils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Avtomobil avtomobil = db.avtos.Find(id);
            db.avtos.Remove(avtomobil);
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
