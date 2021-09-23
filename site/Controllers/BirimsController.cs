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
    public class BirimsController : Controller
    {
        private veri db = new veri();

        // GET: Birims
        public ActionResult Index()
        {
            var birims = db.Birims.Include(b => b.Kullanici);
            return View(birims.ToList());
        }

        // GET: Birims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Birim birim = db.Birims.Find(id);
            if (birim == null)
            {
                return HttpNotFound();
            }
            return View(birim);
        }

        // GET: Birims/Create
        public ActionResult Create()
        {
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi");
            return View();
        }

        // POST: Birims/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Birim_ID,BirimKodu,Kullanici_ID,BirimAdi")] Birim birim)
        {
            if (ModelState.IsValid)
            {
                db.Birims.Add(birim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", birim.Kullanici_ID);
            return View(birim);
        }

        // GET: Birims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Birim birim = db.Birims.Find(id);
            if (birim == null)
            {
                return HttpNotFound();
            }
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", birim.Kullanici_ID);
            return View(birim);
        }

        // POST: Birims/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Birim_ID,BirimKodu,Kullanici_ID,BirimAdi")] Birim birim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(birim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Kullanici_ID = new SelectList(db.Kullanicis, "Kullanici_ID", "KullaniciAdi", birim.Kullanici_ID);
            return View(birim);
        }

        // GET: Birims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Birim birim = db.Birims.Find(id);
            if (birim == null)
            {
                return HttpNotFound();
            }
            return View(birim);
        }

        // POST: Birims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Birim birim = db.Birims.Find(id);
            db.Birims.Remove(birim);
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
