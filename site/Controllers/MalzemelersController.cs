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
    public class MalzemelersController : YetkiliController
    {
        private veriEntities db = new veriEntities();

        // GET: Malzemelers
        public ActionResult Index()
        {
            var malzemelers = db.Malzemelers.Include(m => m.Birim).Include(m => m.Kullanici);
            return View(malzemelers.ToList());
        }

        // GET: Malzemelers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malzemeler malzemeler = db.Malzemelers.Find(id);
            if (malzemeler == null)
            {
                return HttpNotFound();
            }
            return View(malzemeler);
        }

        // GET: Malzemelers/Create
        public ActionResult Create()
        {
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu");
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi");
            return View();
        }

        // POST: Malzemelers/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Malzeme_ID,MalzemeKodu,MalzemeAdi,OzelKod,KDV,OlusturmaTarihi,DuzenlemeTarihi,Kullanici_ID,Birim_ID")] Malzemeler malzemeler)
        {
            if (ModelState.IsValid)
            {
                db.Malzemelers.Add(malzemeler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", malzemeler.Birim_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", malzemeler.Kullanici_ID);
            return View(malzemeler);
        }

        // GET: Malzemelers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malzemeler malzemeler = db.Malzemelers.Find(id);
            if (malzemeler == null)
            {
                return HttpNotFound();
            }
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", malzemeler.Birim_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", malzemeler.Kullanici_ID);
            return View(malzemeler);
        }

        // POST: Malzemelers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Malzeme_ID,MalzemeKodu,MalzemeAdi,OzelKod,KDV,OlusturmaTarihi,DuzenlemeTarihi,Kullanici_ID,Birim_ID")] Malzemeler malzemeler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(malzemeler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Birim_ID = new SelectList(db.Birims, "Birim_ID", "BirimKodu", malzemeler.Birim_ID);
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", malzemeler.Kullanici_ID);
            return View(malzemeler);
        }

        // GET: Malzemelers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malzemeler malzemeler = db.Malzemelers.Find(id);
            if (malzemeler == null)
            {
                return HttpNotFound();
            }
            return View(malzemeler);
        }

        // POST: Malzemelers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Malzemeler malzemeler = db.Malzemelers.Find(id);
            db.Malzemelers.Remove(malzemeler);
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
