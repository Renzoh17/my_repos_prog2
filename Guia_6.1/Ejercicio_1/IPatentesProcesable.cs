using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal interface IPatentesProcesable
    {
        string Clasificar(string cadena, out string patente);
    }
}
