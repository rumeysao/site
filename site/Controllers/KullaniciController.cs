using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Helpers;
using site.Models;

namespace site.Controllers
{

    public class KullaniciController : Controller
    {
        data db = new data();
        // GET: Kullanici
        public ActionResult Index()
        {
            string kullaniciadi = Session["username"].ToString();
            var kullanici = db.Kullanicis.Where(i => i.KullaniciAdi == kullaniciadi).SingleOrDefault();
            return View(kullanici);
        }
        public ActionResult Details(int id)
        {
            var kisi = db.Kullanicis.Where(i => i.U_ID == id).SingleOrDefault();
            return View(kisi);
        }
        public ActionResult Profil()
        {
            string kullaniciadi = Session["username"].ToString();
            var kisi = db.Kullanicis.Where(i => i.KullaniciAdi == kullaniciadi).SingleOrDefault();
            return View(kisi);
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Edit(int id)
        {
            string kullanicadi = Session["username"].ToString();
            var user = db.Kullanicis.Where(i => i.KullaniciAdi == kullanicadi).SingleOrDefault();
            if (OrtakSinif.EditIzinYetkiVarmi(id, user))
            {
                var kisi = db.Kullanicis.Where(i => i.U_ID == id).SingleOrDefault();
                return View();
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(int id, Kullanici model)
        {
            try
            {
                var kisi = db.Kullanicis.Where(i => i.U_ID == id).SingleOrDefault();
                kisi.Isim = model.Isim;
                kisi.SoyIsim = model.SoyIsim;
                kisi.Sifre = model.Sifre;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
   }
}