using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeraAplicacionWeb.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
    }
}