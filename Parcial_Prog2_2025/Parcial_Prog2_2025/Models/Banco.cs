using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Prog2_2025
{
    internal class Banco : Producto
    {
        public Banco(double p, double l):base(p, l)
        {
        }
        public override double Peso()
        {
            return (largo * 0.25) * 0.42;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.15;
        }
    }
}
