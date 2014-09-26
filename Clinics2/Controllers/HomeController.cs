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

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Uslugi()
        {
            return View();
        }
        
        public ActionResult Price()
        {
            ViewBag.Par = Service.Services.Where(service => service.PriceType == PriceType.Paradontology);
            ViewBag.Ter = Service.Services.Where(service => service.PriceType == PriceType.Terapy);
            ViewBag.Ort = Service.Services.Where(service => service.PriceType == PriceType.Ortopia);

            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}
