using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPolimorfismo
{
    [Serializable]
    internal class Auto : IGuardable
    {
        string marca;
        int modelo;

        public Auto(string m, int anio)
        {
            marca = m;
            modelo = anio;
        }
        public string LineaCSV()
        {
            return "Auto;" + marca + ";" + modelo;
        }
    }
}
