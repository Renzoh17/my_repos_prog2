using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    [Serializable]
    internal class Ficha
    {
        private string observaciones;
        private string imagenes;
        Turno turno;
        
        public Ficha(string observaciones, Turno turno)
        {
            this.observaciones = observaciones;
            this.turno = turno;
        }
    }
}
