using System;
using site.Models;
//NORTHWNDEntities'i kullanabilmek için bunu eklememiz gerekiyor
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Web.Mvc;
using site.Helpers;
namespace site.Controllers
{
    public class MalzemeController : Controller
    {
        // GET: Malzeme
        public ActionResult Index()
        {
            return View();
        }

 



    }

}