using Clinics2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinics2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Uslugi()
        {
            return View();
        }
        
        public ActionResult Price()
        {
            ViewBag.Par = Service.Par;
            ViewBag.Ter = Service.Ter;
            ViewBag.Ort = Service.Ort;

            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}
