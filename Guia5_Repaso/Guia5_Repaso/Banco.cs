using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Repaso
{
    internal class Banco : Producto
    {
        public Banco(double precio, double largo):base(precio, largo)
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
        public override string ToString()
        {
            return $"Codigo: {Codigo}, Banco de {largo}";
        }
    }
}
