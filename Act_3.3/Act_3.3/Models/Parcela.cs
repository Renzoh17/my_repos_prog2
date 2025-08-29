using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal class Parcela
    {
        public string Identificador;
        public double Superficie;

        public Parcela(string id, double sup)
        {
            Identificador = id;
            Superficie = sup;
        }
    }
}
