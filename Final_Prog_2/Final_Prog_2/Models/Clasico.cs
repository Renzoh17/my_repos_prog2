using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class Clasico : Producto, ICloneable, IImportable
    {
        public Clasico():base(0,"")
        {
        }
        public Clasico(double precioA, string descripcion):base(precioA, descripcion)
        {
        }
        public override double Precio(double kilo)
        {
            return kilo * (50 + (precioBaseA * 1.4));
        }
        public override string Descripcion()
        {
            return $"{descripcion}{CantidadKilos,10:f2}{Precio(1),10:f2}{Precio(CantidadKilos),10:f2}";
        }

        public object Clone()
        {
            Clasico c = new Clasico(precioBaseA, descripcion);
            return c;
        }

        public void Leer(string linea)
        {
            string[] datos = linea.Split(';');
            descripcion = datos[0];
            precioBaseA = Convert.ToDouble(datos[1]);
        }

        public override string ToString()
        {
            return $"{descripcion}";
        }
    }
}
