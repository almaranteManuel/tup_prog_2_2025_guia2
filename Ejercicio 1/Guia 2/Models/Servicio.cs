using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_2.Models
{
    internal class Servicio
    {
        private List<Persona> personas;
        public Servicio()
        {
            personas = new List<Persona>();
        }

        public bool AgregarPersona(Persona nueva)
        {
            Persona existente = VerPersonaPorDNI(nueva.DNI);

            if (existente == null)
            {
                personas.Add(nueva);
                return true;
            }

            return false;
        }

        public int VerCantidadPersonas()
        {
            return personas.Count;
        }

        public Persona VerPersona(int n)
        {
            if (n < 0 || n >= personas.Count)
            {
                return null;
            }

            return personas[n];
        }

        public Persona VerPersonaPorDNI(int dni)
        {
            int buscado = -1;
            int n = 0;
            while (buscado == -1 && n < personas.Count)
            {
                if (personas[n].DNI == dni)
                {
                    buscado = n;
                }
                n++;
            }

            if (buscado > -1)
                return personas[buscado];
            else
                return null;
        }

        public void EliminarPersona(Persona persona)
        {
            Persona existe = VerPersonaPorDNI(persona.DNI);

            if (existe != null)
            {
                personas.Remove(existe);
            }
        }
    }
}
