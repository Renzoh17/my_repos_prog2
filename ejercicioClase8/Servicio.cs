using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase8
{
    internal class Servicio : ItemFactura
    {
        private int tiempo;

        public Servicio(string descripcion, int duracion):base(descripcion)
        {
            tiempo = duracion;
        }
    }
}
