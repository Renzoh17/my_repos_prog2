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
            cadena = cadena.Trim().ToUpper();
            patente = "";
            Match ml = null, md = null;
            ml = Regex.Match(cadena, @"([A-Z]{1,})");
            md = Regex.Match(cadena, @"\d{1,}");
            patente += ml.Length;
            patente += " " + md.Length + ", ";
            
            return "Desconocido";
        }
    }
}
