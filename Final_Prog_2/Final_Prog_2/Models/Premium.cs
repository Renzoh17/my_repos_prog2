using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class Premium : Producto, ICloneable, IImportable
    {
        double precioBaseB;

        public Premium():base(0,"")
        {
        }
        public Premium(string descripcion, double precioA, double precioB):base(precioA, descripcion)
        {
            precioBaseB = precioB;
        }
        public override double Precio(double kilo)
        {
            return kilo * (70 + (precioBaseA * 0.85 + precioBaseB * 0.15) * 0.18);
        }
        public override string Descripcion()
        {
            return $"{descripcion}{CantidadKilos,10:f2}{Precio(1),10:f2}{Precio(CantidadKilos),10:f2}";
        }

        public object Clone()
        {
            Premium pp = new Premium(descripcion, precioBaseA, precioBaseB);
            return pp;
        }

        public void Leer(string linea)
        {
            string[] datos = linea.Split(';');
            descripcion = datos[0];
            precioBaseA = Convert.ToDouble(datos[1]);
            precioBaseB = Convert.ToDouble(datos[2]);
        }
        public override string ToString()
        {
            return $"{descripcion}";
        }
    }
}
