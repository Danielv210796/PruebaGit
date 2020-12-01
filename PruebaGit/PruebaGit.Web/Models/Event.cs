using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Display(Name = "Artista")]
        public ApplicationUser Artist { get; set; }
        [Display(Name = "Fecha del evento")]
        public DateTime Datetime { get; set; }
        [Display(Name = "Hora")]
        public string Place { get; set; }
        [Display(Name = "Lugar")]
          //tabla de genero con eventos
          // foreign key(GenreId) references Genre(Id);

        public int GenreId { get; set; } 
        [Display(Name ="GenreId")]
        public Genre Genre { get; set; }
    }
}