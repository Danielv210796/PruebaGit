using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Display(Name = "No Paciente")]
        public int NoPaciente { get; set; }

        [Display(Name = "Nombre")]
        public string Nombres { get; set; }

        [Display(Name = "Apellido Materno")]
        public string AM { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string AP { get; set; }

       [Display(Name = "Fecha de Nacimiento")]
       public DateTime DateTime { get; set; }

        [Display(Name = "Genero")]
        public string Genero { get; set; }


        [Display(Name = "Numero de telefono")]
        public int Numero { get; set; }

        [Display(Name = "Enfermedad")]
        public string Enfermedad { get; set; }






        //REFERENCIAS A LA TABLA DE DOCTOR
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }





    }
}