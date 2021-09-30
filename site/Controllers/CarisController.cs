using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class CarisController : Controller
    {
        private veriEntities db = new veriEntities();

        // GET: Caris
        public ActionResult Index()
        {
            var caris = db.Caris.Include(c => c.Faturas).Include(c => c.FaturaSatirlari).Include(c => c.Kullanici);
            return View(caris.ToList());
        }

        // GET: Caris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cari cari = db.Caris.Find(id);
            if (cari == null)
            {
                return HttpNotFound();
            }
            return View(cari);
        }

        // GET: Caris/Create
        public ActionResult Create()
        {
            ViewBag.Fatura_ID = new SelectList(db.Faturas, "Fatura_ID", "Fatura_ID");
            ViewBag.FaturaSatirlari_ID = new SelectList(db.FaturaSatirlaris, "Faturasatirlari_ID", "Iptal");
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi");
            return View();
        }

        // POST: Caris/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cari_ID,CariKodu,Tanim,Adres,Ulke,Sehir,Ilce,Tel,Fax,Email,Web,PostaKodu,Aktif,Fatura_ID,FaturaSatirlari_ID,Kullanici_ID")] Cari cari)
        {
            if (ModelState.IsValid)
            {
                db.Caris.Add(cari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FaturaSatirlari_ID = new SelectList(db.FaturaSatirlaris, "Faturasatirlari_ID", "Iptal", cari.FaturaSatirlari_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", cari.Kullanici_ID);
            return View(cari);
        }

        // GET: Caris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cari cari = db.Caris.Find(id);
            if (cari == null)
            {
                return HttpNotFound();
            }
            ViewBag.FaturaSatirlari_ID = new SelectList(db.FaturaSatirlaris, "Faturasatirlari_ID", "Iptal", cari.FaturaSatirlari_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", cari.Kullanici_ID);
            return View(cari);
        }

        // POST: Caris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cari_ID,CariKodu,Tanim,Adres,Ulke,Sehir,Ilce,Tel,Fax,Email,Web,PostaKodu,Aktif,Fatura_ID,FaturaSatirlari_ID,Kullanici_ID")] Cari cari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FaturaSatirlari_ID = new SelectList(db.FaturaSatirlaris, "Faturasatirlari_ID", "Iptal", cari.FaturaSatirlari_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", cari.Kullanici_ID);
            return View(cari);
        }

        // GET: Caris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cari cari = db.Caris.Find(id);
            if (cari == null)
            {
                return HttpNotFound();
            }
            return View(cari);
        }

        // POST: Caris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cari cari = db.Caris.Find(id);
            db.Caris.Remove(cari);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
