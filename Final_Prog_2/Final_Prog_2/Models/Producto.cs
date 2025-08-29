using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;
        public double CantidadKilos {  get; set; }

        public Producto(double precioA, string descripcion)
        {
            precioBaseA = precioA;
            this.descripcion = descripcion;
        }
        public abstract double Precio(double kilo);
        public abstract string Descripcion();
    }
}
