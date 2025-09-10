using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Prog2_2025
{
    internal class Mesa : Producto
    {
        double ancho;
        public double Ancho
        {
            get
            {
                return ancho;
            }
        }
        
        public Mesa(double p, double l, double a):base(p, l)
        {
            ancho = p;
        }
        public override double Peso()
        {
            return (largo * ancho) * 0.3;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }
    }
}
