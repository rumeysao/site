using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;
using site.Models.Sinif;

namespace site.Controllers
{
    public class CarihesapController : Controller
    {
        // GET: Carihesap
        public ActionResult Index()
        {
            return View();
        }
        veriEntities c = new veriEntities();

        public ActionResult Dinamik()
        {
            Class1 cs = new Class1();
            cs.deger3 = c.Caris.ToList();
           
            return View(cs);
        }
        public ActionResult CariKaydet(string CariKodu, string Tanim, string Adres, string Ulke, string Sehir,string Ilce,Int32 Tel,Int32 Fax, string Email, string Web,Int32 PostaKodu,bool Aktif )
        {
            Cari a = new Cari();
            a.Adres= Adres;
            a.Aktif = Aktif;
            a.CariKodu = CariKodu;
            a.Email = Email;
            a.Fax = Fax;
            a.Ilce = Ilce;
            a.PostaKodu = PostaKodu;
            a.Sehir = Sehir;
            a.Tanim = Tanim;
            a.Tel = Tel;
            a.Ulke = Ulke;
            a.Web = Web;


            c.Caris.Add(a);
       
            c.SaveChanges();
            return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
        }
    }
}