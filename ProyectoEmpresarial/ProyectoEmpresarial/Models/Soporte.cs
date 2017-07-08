using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEmpresarial.Models
{
    public class Soporte
    {
        public int id { get; set; }
        public string problema { get; set; }
        public string descripcion { get; set; }
        public string personaReporta { get; set; }
        public int cliente { get; set; }
        public string estadoActual { get; set; }

    }
}