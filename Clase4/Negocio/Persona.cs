using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal abstract class Persona
    {
        protected string nombre;
        protected long dni;

        public Persona(string nombre, long dni)
        { 
            this.nombre = nombre;
            this.dni = dni;
        }
        public abstract string getNombre();
        public long Dni { get {  return dni; } }



    }
}
