using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaGit.Web.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Trabajador")]

        public string Nombre { get; set; }
        public ICollection<Administrador> Administradors { get; set; }

    }
}