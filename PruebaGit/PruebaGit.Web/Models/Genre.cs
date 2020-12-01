using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Genre
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(150)]


        public string Name { get; set; }

        //Esta linea de codigo significa
        //que nos va mostrar una coleccion o todos los 
        //eventos que existen en la tabla de eventos
        public ICollection<Event> Events { get; set; }
   

    }
}