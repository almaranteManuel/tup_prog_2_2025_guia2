using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_2.Models
{
    internal class Persona
    {
        public Persona(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
        public int DNI { get; }
        public string Nombre { get; set; }

        public string Describir()
        {
            return $@"
               ""Nombre"": {Nombre},
               ""DNI"": {DNI}
            ";
        }
    }
}
