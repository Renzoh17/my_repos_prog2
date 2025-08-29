using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    [Serializable]
    internal class Profesional : Persona
    {
        private static int contProfesionales = 0;
        public int ContProfesionales { get { return contProfesionales; } }
        public Profesional(string nombre, string apellido, string dni):base(nombre, apellido, dni)
        {
            contProfesionales++;
        }

        public override string[] Mostrar()
        {
            return new string[3] { "Nombre: " + nombre, "Apellido: " + apellido, "DNI: " + dni };
        }
    }
}
