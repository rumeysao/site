using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        data db = new data();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici model)
        {
            try
            {
                var varmi = db.Kullanicis.Where(i => i.KullaniciAdi == model.KullaniciAdi).SingleOrDefault();
                if (varmi == null)
                {
                    return View();
                }           
                if (varmi.Sifre == model.Sifre)
                {
                    Session["username"] = varmi.KullaniciAdi;
                    return RedirectToAction("Index", "Kullanici");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Kullanici model)
        {
            try
            {
                var varmi = db.Kullanicis.Where(i => i.KullaniciAdi == model.KullaniciAdi).SingleOrDefault();
                if(varmi != null)
                {
                    return View();
                }
                if (string.IsNullOrEmpty(model.Sifre))
                {
                    return View();
                }
                model.YetkiID = 1;
                db.Kullanicis.Add(model);
                db.SaveChanges();
                Session["username"] = model.KullaniciAdi;
                return RedirectToAction("Index", "Kullanici");

            }
            catch
            {
                return View();
            }
        }
    }
}