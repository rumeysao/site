using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using site.Models;
using site.Models.Sinif;

namespace site.Controllers
{
    public class faturahesapController : YetkiliController
    {
        veriEntities objveri = new veriEntities();
        //veriEntities objveri;
        //public faturahesapController()
        //{
        //    objveri = new veriEntities();
        //}
        //public ActionResult Index()
        //{
        //    Fatura objfatura = new Fatura();

        //    return View(objfatura);

        //}
        //[HttpPost]
        //public ActionResult Index(Fatura objfatura)
        //{
        //    using (var context = new veriEntities())
        //    {
        //        var fatura = new Fatura();
        //        //burda yeni bir fatura objesi oluşturup içerisini boş bırakıyoruz

        //        fatura = objfatura;
        //        //bize gtelen değerleri yeni objemiz ile eşitliyoruz
        //        context.Faturas.Add(fatura);
        //        // entity classımızda var olan faturas yerine bu yeni objeyi ekliyoruz
        //        context.SaveChanges();
        //        //en sonunda kaydediyoruz


        //    }

        //    return Json(data: objfatura, contentType: "");

        //}
       
        public ActionResult Dinamik()
        {
            Class1 cs = new Class1();
            cs.deger1 = objveri.Faturas.ToList();
            cs.deger2 = objveri.FaturaSatirlaris.ToList();
            return View(cs);
        }
        public ActionResult FaturaKaydet(string FaturaSeriNo, string FaturasiraNo, DateTime Tarih, string Toplam, FaturaSatirlari[] kalemler, Cari[] cariler)
        {
            Fatura f = new Fatura();
            f.FaturaSeriNo = FaturaSeriNo;
            f.FaturaSiraNo = FaturasiraNo;
            f.Tarih = Tarih;

            f.Toplam = decimal.Parse(Toplam);
            objveri.Faturas.Add(f);
            foreach (var x in kalemler)
            {
                FaturaSatirlari fs = new FaturaSatirlari();
                fs.Aciklama = x.Aciklama;
                fs.Birim = x.Birim;
                // fs.Fatura_ID = x.Faturasatirlari_ID;
                fs.Miktar = x.Miktar;
                fs.KDV = x.KDV;
                fs.Tutar = x.Tutar;
                objveri.FaturaSatirlaris.Add(fs);
            }
            foreach (var x in cariler)
            {
                Cari c = new Cari();
                c.Tanim = x.Tanim;
                objveri.Caris.Add(c);
            }
            objveri.SaveChanges();
            return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
        }
    }
}