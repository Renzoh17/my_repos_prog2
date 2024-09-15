using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Medidor
    {
        public int NroMedidor;
        public int LecturaAnterior;
        public int LecturaActual;

        public int ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }
        public void Medicion()
        {

        }
    }
}
