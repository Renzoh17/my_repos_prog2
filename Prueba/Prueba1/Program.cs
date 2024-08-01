using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Renzo","Hirschfeld", 43756001);
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nDNI: {2}",p1.nombre,p1.apellido,p1.Dni);

        }
    }
}
