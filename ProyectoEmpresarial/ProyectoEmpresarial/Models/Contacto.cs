using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEmpresarial.Models
{
    public class Contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoUno { get; set; }
        public string apellidoDos { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string puesto { get; set; }
        public int clientePertenece { get; set; }
    }
}