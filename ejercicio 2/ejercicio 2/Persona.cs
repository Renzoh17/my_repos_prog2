using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Persona
    {
        string nombre;
        int cuit;
        public long Telefono { get; set; }

        public Persona(string nom, int cuit)
        {
            if (cuit > 9999 || cuit < 9) throw new InvalidoException("Cantidad de digitos incorrecta");
            nombre = nom;
            this.cuit = cuit;
        }

        public string VerDatos()
        {
            return nombre + "-" + cuit;
        }


    }
}
