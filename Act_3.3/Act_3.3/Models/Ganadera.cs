using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal abstract class Ganadera : Actividad
    {
        public int CantidadCabezas;

        public Ganadera(int periodo, string descripcion)
            :base(periodo, descripcion)
        {
        }
    }
}
