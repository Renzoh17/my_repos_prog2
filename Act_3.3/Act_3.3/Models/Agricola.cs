using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal class Agricola : Actividad
    {
        public int CantidadToneladasCosechadas;
        public double PrecioTonelada;

        public Agricola(int periodo, string descripcion)
            :base(periodo, descripcion)
        {

        }

        public override double CalcularRendimiento()
        {
            return 0.0;
        }
        public override double CalcularProduccion()
        {
            return 0.0;
        }
    }
}
