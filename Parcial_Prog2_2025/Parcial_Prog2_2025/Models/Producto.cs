using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Prog2_2025
{
    internal abstract class Producto : IComparable
    {
        protected double precioBase;
        protected double largo;
        public int Codigo;

        public Producto(double p, double l)
        {
            precioBase = p;
            largo = l;
        }
        public abstract double Peso();
        public abstract double Precio();

        public override string ToString()
        {
            string s = "Invalid Product";
            if (this is Mesa m)
            {
                s = $"PB: {precioBase}, L: {largo}, A: {m.Ancho}";
            }
            else if(this is Banco)
            {
                s = $"PB: {precioBase}, L: {largo}";
            }
            return s;
        }
        public int CompareTo(Object o)
        {
            return Codigo.CompareTo(((Producto)o).Codigo);
        }
    }
}
