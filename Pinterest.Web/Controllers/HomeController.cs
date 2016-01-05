using Microsoft.AspNet.Identity;
using Pinterest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pinterest.Web.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public JsonResult GetPins()
        {
            var model = db.Pins.Select(p => new { p.Id, p.Description, p.LinkToImage, p.LinkToPost, Name = p.ApplicationUser.UserName });
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SavePin(Pin pin)
        {
            var currentUserId = User.Identity.GetUserId();
            var currentUser = db.Users.Find(currentUserId);
            pin.ApplicationUser = currentUser;

            db.Pins.Add(pin);
            db.SaveChanges();

            var model = new { pin.Id, pin.Description, pin.LinkToImage, pin.LinkToPost, Name = pin.ApplicationUser.UserName };
            return Json(model);
        }

    }
}