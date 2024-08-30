using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal abstract class Persona : IComparable
    {
        protected string nombre;
        public Persona(string nom)
        {
            nombre = nom;
        }
        public virtual string Identificar()
        {
            return nombre + " es persona";
            
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Persona persona = obj as Persona;
            return this.nombre.CompareTo(persona.nombre);
        }
    }
}
