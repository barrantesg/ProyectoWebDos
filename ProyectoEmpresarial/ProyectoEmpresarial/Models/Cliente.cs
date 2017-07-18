using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEmpresarial.Models
{
    public class Cliente
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string cedulaJuridica { get; set; }
        public string pagina { get; set; }
        public string residencia { get; set; }
        public string telefono { get; set; }
        public string sector { get; set; }
    }
}