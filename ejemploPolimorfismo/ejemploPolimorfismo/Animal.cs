using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploPolimorfismo
{
    [Serializable]
    abstract class Animal : IComparable<Animal>, IGuardable
    {
        protected string nombre;
        private DateTime fechaNac;
        static int orden = 0;
        public string edadDelAnimal;
        public Animal(string nom, DateTime nacimiento)
        {
            this.nombre = nom;
            this.fechaNac = nacimiento;
        }
        public abstract string Datos(); 
        public abstract string Grito();
        public string Edad(DateTime hoy)
        {
            TimeSpan edad = hoy.Subtract(fechaNac);
            edadDelAnimal = ((int)((edad.TotalDays - 1) / 365.25)).ToString("00");
            return edadDelAnimal;
        }
        public static void OrdenarPor(int or)
        {
            orden = or;
        }
        public int CompareTo(Animal obj)
        {
            if (obj == null) return 1;
            switch (orden)
            {
                case 0:
                    return nombre.CompareTo(obj.nombre);
                case 1:
                    return edadDelAnimal.CompareTo(obj.edadDelAnimal);
                default:
                    return 1;
            }
        }
        public string LineaCSV()
        {
            string es = this is Gato ? "Gato" : "Perro";
            return es + ";" + nombre + ";" + fechaNac + ";" + Grito();
        }
    }
}
