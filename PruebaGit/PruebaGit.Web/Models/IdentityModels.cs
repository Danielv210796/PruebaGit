﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PruebaGit.Web.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        ////------------------TABLA DE ADMINISTRADOR QUE VA REGISTRAR LOS EMPLEADOS--------------//

        public DbSet<Administrador> Administradors { get; set; }
        public DbSet<Trabajador> Trabajadors { get; set; }


        ////////--------------------------TABLA DE LOS PACIENTES QUE REGISTRARA EL MEDICO---------------------------//
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        ////////--------------------------TABLA DE HOSPITAL QUE REGISTRA HOSPITALES---------------------------//
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Registrar_Hospital> Registrar_Hospitals { get; set; }




    }
}