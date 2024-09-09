using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Estudiante:Persona
    {
        static Random numero = new Random();
        int dni;
        public Estudiante(string nomm)
   : base(nomm)
        {
            dni = numero.Next(100000);
        }
        public override string Identificar()
        {
            return base.nombre + " es Estudiante";
            //return base.Identificar() + " es Estudiante";
        }
        public int Dni
        {
            get => dni;
        }

    }
}
