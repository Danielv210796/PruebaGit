using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaGit.Web.Controllers
{
    public class homeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            var administradors = db.Administradors.ToList();
            return View(administradors);
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
           
            return View();
        }
    }
}