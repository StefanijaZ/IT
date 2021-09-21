using OglasnikItProekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OglasnikItProekt.Controllers
{
   
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult kategorii()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Avtomobil()
        {
            Avtomobil dm = new Avtomobil();
            return View(dm);
        }
        public ActionResult Mobilen()
        {
           Mobilen dm = new Mobilen();
           return View(dm);
        }
        public ActionResult Laptop()
        {
            Laptop dm = new Laptop();
            return View(dm);
        }
        public ActionResult BelaTehnika()
        {
            BelaTehnika dm = new BelaTehnika();
            return View(dm);
        }
        public ActionResult Zivealiste()
        {
            Zivealiste dm = new Zivealiste();
            return View(dm);
        }
        public ActionResult Mebel()
        {
            Mebel dm = new Mebel();
            return View(dm);
        }
    }
}