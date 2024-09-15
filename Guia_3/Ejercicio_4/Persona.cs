using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal abstract class Persona
    {
        public string ApellidosNombres;

        public Persona(string apellidosNombres)
        {
            ApellidosNombres = apellidosNombres;
        }
    }
}
