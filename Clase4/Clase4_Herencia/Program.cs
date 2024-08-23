using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Herencia
{
    internal class Animal
    {
        protected string nombre;

        public Animal(string nombre) 
        {
            this.nombre = nombre;
        }
        public virtual string Soy()
        {
            return nombre;
        }
    }
    internal sealed class Perro : Animal
    {
        string raza;
        
       public Perro(string n, string r):base(n)
        {
            raza = r;
        }
        public override string Soy()
        {
            return "Me llamo " + base.Soy() + " Raza " + raza;
        }
    }
    internal sealed class Gato : Animal
    {
        public Gato(string n):base(n)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal p1 = new Perro("Tobi", "Caniche");
            Console.WriteLine(p1.Soy());
        }
    }
}
