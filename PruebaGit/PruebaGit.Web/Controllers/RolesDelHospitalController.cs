using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaGit.Web.Controllers
{
    public class RolesDelHospitalController : Controller
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();
        // GET: RolesDelHospital
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
    }
}