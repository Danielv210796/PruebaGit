using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PruebaGit.Web.Controllers
{
    public class RolesController : Controller
    {
        readonly ApplicationDbContext db = new ApplicationDbContext();
        // GET: Roles
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
        //metodo get add
        public ActionResult AddRoles(string id)
        {
            var user = db.Users.Find(id);
            return View(user);
        }
      
        //    [HttpPost]
        //   //FALTA AJUSTAR EL METODO DE POST NO FUNCIONA
        //public ActionResult AddRoles(Roles roles )
        //{

        //    db.Roles.Add(roles);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //FALTA AJUSTAR EL METODO DE POST NO FUNCIONA
    }
}