using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoEmpresarial.Models
{
    public class Reunion
    {
        public int id { get; set; }
        public string nombreReunion { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime dia { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public DateTime? hora { get; set; }

        public int empleadoAsignado { get; set; }
        public bool virtua { get; set; }
        public int cliente { get; set; }
    }
}