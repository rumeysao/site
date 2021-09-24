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
        // GET: Default
        public ActionResult Index()
        {
            Fatura objfatura = new Fatura();
            objfatura.ListOfFatura = (from obj in objveri.Birims
                                      select new SelectListItem()
                                      {
                                          Text=obj.BirimAdi,
                                          Value=obj.Birim_ID.ToString()
                                      }).ToList();
            objfatura.ListOfCari = (from obj in objveri.Caris
                                    select new SelectListItem()
                                    {
                                        Text = obj.Tanim,
                                        Value = obj.Cari_ID.ToString()
                                    }).ToList();
            return View(objfatura);
        }
    }
}