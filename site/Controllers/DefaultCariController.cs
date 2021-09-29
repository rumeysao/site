using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;
namespace site.Controllers
{
    public class DefaultCariController : Controller
    {
        veri objveri;
        public DefaultCariController()
        {
            objveri = new veri();
        }
        // GET: DefaultCari
        public ActionResult Index()
        {
            Cari objcari = new Cari();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Cari objcari)
        {

            return Json(data: "", contentType: "");

        }
    }
}