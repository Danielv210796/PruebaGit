using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Utility
    {

        //creacion de utility

        readonly static ApplicationDbContext db = new ApplicationDbContext();
      

        public static void CheckRoles(string rol)
        {
            var role = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!role.RoleExists(rol))
            {
                role.Create(new IdentityRole(rol));
            }
        }
            internal static void CheckSuperUser()
            {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = userManager.FindByName("superuser@gmail.com");
            
            //condicion si no existe se va crear
            if(user==null)
            {
                CreateSuperUser("superuser@gmail.com", "Admin_123", null, "Admin");
            }

        }
        //metodo para el Super Usuario = Administrador
        private static void CreateSuperUser(string email, string password, object phone, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //creacion de objeto
            var user = new ApplicationUser()
            {
            UserName=email

            };


        }
    }
}