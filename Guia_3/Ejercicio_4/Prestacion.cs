using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal abstract class Prestacion : Persona
    {
        public readonly double MontoTotal;
        protected string Medico;
        public Prestacion(string apellidosNombresPersona, string medico):base(apellidosNombresPersona)
        {
            Medico = medico;
        }
        public abstract double PrestarServicio();
    }
}
