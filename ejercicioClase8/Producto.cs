using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase8
{
    internal class Producto : ItemFactura
    {
        public int Stock { get; set; }
        private string proveedor;

        public Producto(string descripcion):base(descripcion)
        {
            
        }
    }
}
