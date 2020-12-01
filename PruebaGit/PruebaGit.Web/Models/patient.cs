using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class patient
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string fecha { get; set; }
        public string genero { get; set; }
        public string telefono { get; set; }
    }
}

