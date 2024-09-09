using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Repaso
{
    internal abstract class Producto : IComparable
    {
        protected double precioBase, largo;
        private int codigo;
        public int Codigo { get {  return codigo; } set { codigo = value; } }

        public Producto(double precio, double largo)
        {
            precioBase = precio;
            this.largo = largo;
        }
        public abstract double Peso();
        public abstract double Precio();
        public abstract override string ToString();

        public int CompareTo(Object p)
        {
            if (p == null) return 1;
            return codigo.CompareTo(((Producto)p).Codigo);
        }
    }
}
