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
    public class FaturasController : Controller
    {
        private veriEntities db = new veriEntities();

        // GET: Faturas
        public ActionResult Index()
        {
            var faturas = db.Faturas.Include(f => f.Birim).Include(f => f.Cari).Include(f => f.Kullanici);
            return View(faturas.ToList());
        }

        // GET: Faturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fatura fatura = db.Faturas.Find(id);
            if (fatura == null)
            {
                return HttpNotFound();
            }
            return View(fatura);
        }

        // GET: Faturas/Create
        public ActionResult Create()
        {
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu");
            ViewBag.Cari_ID = new SelectList(db.Caris, "Cari_ID", "CariKodu");
           
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi");
            return View();
        }

        // POST: Faturas/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Fatura_ID,FaturaSeriNo,FaturaSiraNo,Saat,Tarih,Tutar,Cari_ID,Kullanici_ID,Birim_ID")] Fatura fatura)
        {
            if (ModelState.IsValid)
            {
                db.Faturas.Add(fatura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", fatura.Birim_ID);
            ViewBag.Cari_ID = new SelectList(db.Caris, "Cari_ID", "CariKodu", fatura.Cari_ID);
           
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", fatura.Kullanici_ID);
            return View(fatura);
        }

        // GET: Faturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fatura fatura = db.Faturas.Find(id);
            if (fatura == null)
            {
                return HttpNotFound();
            }
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", fatura.Birim_ID);
            ViewBag.Cari_ID = new SelectList(db.Caris, "Cari_ID", "CariKodu", fatura.Cari_ID);
            
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", fatura.Kullanici_ID);
            return View(fatura);
        }

        // POST: Faturas/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Fatura_ID,FaturaSeriNo,FaturaSiraNo,Saat,Tarih,Tutar,Cari_ID,Kullanici_ID,Birim_ID")] Fatura fatura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fatura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", fatura.Birim_ID);
            ViewBag.Cari_ID = new SelectList(db.Caris, "Cari_ID", "CariKodu", fatura.Cari_ID);
          
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", fatura.Kullanici_ID);
            return View(fatura);
        }

        // GET: Faturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fatura fatura = db.Faturas.Find(id);
            if (fatura == null)
            {
                return HttpNotFound();
            }
            return View(fatura);
        }

        // POST: Faturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fatura fatura = db.Faturas.Find(id);
            db.Faturas.Remove(fatura);
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
