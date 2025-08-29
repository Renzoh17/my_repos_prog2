using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase8
{
    internal abstract class ItemFactura
    {
        public int Codigo { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; }

        public ItemFactura(string descripcion)
        {
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"{Codigo} {Descripcion}";
        }
    }
}
