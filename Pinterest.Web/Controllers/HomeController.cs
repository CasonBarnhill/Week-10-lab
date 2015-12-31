using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pinterest.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public JsonResult ()
        //{
        //    var something = new property {data of some sort };

        //    return Json(something2, JsonRequestBehavior.AllowGet);
        //}




       // public JsonResult Pin()
       //{
       //      var pinterest = new Url {  };
 
       //      return Json(pinterest, JsonRequestBehavior.AllowGet);
       //}
}
}