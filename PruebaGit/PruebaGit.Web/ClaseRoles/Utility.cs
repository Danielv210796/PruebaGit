
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PruebaGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.ClaseRoles
{
    public class Utility
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();
        public static void CheckRoles(string rol)
        {
            var role = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!role.RoleExists(rol))
            {
                role.Create(new IdentityRole(rol));
            }
        }
    }
}