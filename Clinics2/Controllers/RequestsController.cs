using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinics2.Controllers
{
    public class RequestsController : Controller
    {
        public ActionResult GetGalleryImages()
        {
            string filePath = Server.MapPath(Url.Content("~/Photos/Gallery/"));

            var files = Directory.GetFiles(filePath);

            return Json(files.Select(file => new { src = string.Format("photos/gallery/{0}", Path.GetFileName(file)), desc = "image" }));
        }

    }
}
