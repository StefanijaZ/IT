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
    public class BelaTehnikasController : Controller
    {
        private DbBT db = new DbBT();

        // GET: BelaTehnikas
        public ActionResult Index()
        {
            return View(db.bts.ToList());
        }

        // GET: BelaTehnikas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BelaTehnika belaTehnika = db.bts.Find(id);
            if (belaTehnika == null)
            {
                return HttpNotFound();
            }
            return View(belaTehnika);
        }

        // GET: BelaTehnikas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BelaTehnikas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BelaTehnikaID,imgURL,Ime,Lokacija,Cena,Opis")] BelaTehnika belaTehnika)
        {
            if (ModelState.IsValid)
            {
                db.bts.Add(belaTehnika);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(belaTehnika);
        }

        // GET: BelaTehnikas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BelaTehnika belaTehnika = db.bts.Find(id);
            if (belaTehnika == null)
            {
                return HttpNotFound();
            }
            return View(belaTehnika);
        }

        // POST: BelaTehnikas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BelaTehnikaID,imgURL,Ime,Lokacija,Cena,Opis")] BelaTehnika belaTehnika)
        {
            if (ModelState.IsValid)
            {
                db.Entry(belaTehnika).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(belaTehnika);
        }

        // GET: BelaTehnikas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BelaTehnika belaTehnika = db.bts.Find(id);
            if (belaTehnika == null)
            {
                return HttpNotFound();
            }
            return View(belaTehnika);
        }

        // POST: BelaTehnikas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BelaTehnika belaTehnika = db.bts.Find(id);
            db.bts.Remove(belaTehnika);
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
