using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            Persona persona = new Cliente("Pedrito", 40180130, 123);
            lista.Add(persona);
            persona = new Empleado("Juan", 43756001, 20000);
            lista.Add(persona);
            foreach (Persona p in lista)
            {
                Console.WriteLine(p.getNombre());
            }
        }
    }
}
