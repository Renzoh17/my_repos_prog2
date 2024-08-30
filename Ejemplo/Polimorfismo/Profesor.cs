using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Profesor : Persona
    {
        int legajo;
        public Profesor (string nombre, int valor):base(nombre)
        {
            legajo = valor;
        }
        public override string Identificar()
        {
            return base.nombre + " es profesor";
        }
        public int Legajo
        {
            get => legajo;
        }

        public override int CompareTo(object obj)
        {
            if (obj == null || obj is Estudiante) return 1;
            Profesor profesor = obj as Profesor;
            return this.legajo.CompareTo(profesor.legajo);
        }
    }
}
