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
    public class ZivealistesController : Controller
    {
        private DbZiv db = new DbZiv();

        // GET: Zivealistes
        public ActionResult Index()
        {
            return View(db.zivs.ToList());
        }

        // GET: Zivealistes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zivealiste zivealiste = db.zivs.Find(id);
            if (zivealiste == null)
            {
                return HttpNotFound();
            }
            return View(zivealiste);
        }

        // GET: Zivealistes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zivealistes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZivealisteID,imgURL,Ime,Lokacija,Cena,Opis")] Zivealiste zivealiste)
        {
            if (ModelState.IsValid)
            {
                db.zivs.Add(zivealiste);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zivealiste);
        }

        // GET: Zivealistes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zivealiste zivealiste = db.zivs.Find(id);
            if (zivealiste == null)
            {
                return HttpNotFound();
            }
            return View(zivealiste);
        }

        // POST: Zivealistes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZivealisteID,imgURL,Ime,Lokacija,Cena,Opis")] Zivealiste zivealiste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zivealiste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zivealiste);
        }

        // GET: Zivealistes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zivealiste zivealiste = db.zivs.Find(id);
            if (zivealiste == null)
            {
                return HttpNotFound();
            }
            return View(zivealiste);
        }

        // POST: Zivealistes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zivealiste zivealiste = db.zivs.Find(id);
            db.zivs.Remove(zivealiste);
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
