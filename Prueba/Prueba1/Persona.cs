using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Persona
    {
        //VARIABLES
        //Primera Manera Encapsulamiento
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        //Segunda manera Encapsulamiento
        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }
            private set
            {
                dni = value;
            }
        } 
         
        //METODOS
        public Persona(string nombre, string apellido, int dni){
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


    }
}
