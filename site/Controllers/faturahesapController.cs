using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;
using site.Models.Sinif;

namespace site.Controllers
{
    public class faturahesapController : Controller
    {
        // GET: faturahesap
        public ActionResult Index()
        {
            return View();
        }
        veriEntities c = new veriEntities();

        public ActionResult Dinamik()
        {
            Class1 cs = new Class1();
            cs.deger1 = c.Faturas.ToList();
            cs.deger2 = c.FaturaSatirlaris.ToList();
            return View(cs);
        }
        public ActionResult FaturaKaydet(string FaturaSeriNo, string FaturasiraNo, DateTime Tarih, string Tanim, string Toplam, FaturaSatirlari[] kalemler)
        {
            Fatura f = new Fatura();
            f.FaturaSeriNo = FaturaSeriNo;
            f.FaturaSiraNo = FaturasiraNo;
            f.Tarih = Tarih;

            f.Cari.Tanim = Tanim;
            f.Toplam = decimal.Parse(Toplam);
            c.Faturas.Add(f);
            foreach (var x in kalemler)
            {
                FaturaSatirlari fs = new FaturaSatirlari();
                fs.Aciklama = x.Aciklama;
                fs.Birim = x.Birim;
                fs.Fatura_ID = x.Faturasatirlari_ID;
                fs.Miktar = x.Miktar;
                fs.KDV = x.KDV;
                fs.Tutar = x.Tutar;
                c.FaturaSatirlaris.Add(fs);
            }
            c.SaveChanges();
            return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
        }
    }
}