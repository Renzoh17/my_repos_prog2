using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class ObraSocial : Prestacion
    {
        public double Arancel = 200;
        public readonly int ConsultasMensuales;

        public ObraSocial(string nombre, string medico):base(nombre, medico)
        {

        }
        public override double PrestarServicio()
        {
            return 0;
        }
    }
}
