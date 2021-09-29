using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;


namespace site.Controllers
{
    public class DefaultController : Controller
    {
        veri objveri;
        public DefaultController()
        {
            objveri = new veri();
        }
        public ActionResult Index() {
            Fatura objfatura = new Fatura();
            objfatura.ListOfBirim = (from obj in objveri.Birims
                                     select new SelectListItem()
                                     {
                                         Text = obj.BirimAdi,
                                         Value = obj.Birim_ID.ToString()
                                     });
            objfatura.ListOfCari= (from obj in objveri.Caris
                                     select new SelectListItem()
                                     {
                                         Text = obj.Tanim,
                                         Value = obj.Cari_ID.ToString()
                                     });
            return View(objfatura);
        
        }
        [HttpPost]
        public ActionResult Index(Fatura objfatura) 
        {
            using (var context = new veri())
            {
                var fatura = new Fatura();
                //burda yeni bir fatura objesi oluşturup içerisini boş bırakıyoruz

                fatura = objfatura;
                //bize gtelen değerleri yeni objemiz ile eşitliyoruz
                context.Faturas.Add(fatura);
                // entity classımızda var olan faturas yerine bu yeni objeyi ekliyoruz
                context.SaveChanges();
                //en sonunda kaydediyoruz
            }
            return Json(data: objfatura, contentType: "");
        
        }
    }
      
    
}