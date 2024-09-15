using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class SinObra : Prestacion
    {
        public string CUIT;
        public double ImporteFijo = 250;

        public SinObra(string nombre, string medico, string cuit):base(nombre, medico)
        {
            CUIT = cuit;
        }
        public override double PrestarServicio()
        {
            return 0;
        }
    }
}
