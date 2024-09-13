using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class RegexPatentesProcesable : IPatentesProcesable
    {
        public string Clasificar(string cadena, out string patente)
        {
            cadena = cadena.Trim();
            patente = "";
            //([0-3]{1,}\w)([0-3]{1,}\d)
            Match m = Regex.Match(cadena, @"(\d[0-3])");
            patente = m.Value;
            return "";
        }
    }
}
