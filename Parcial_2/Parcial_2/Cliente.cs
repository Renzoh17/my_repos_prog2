using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    [Serializable]
    internal class Cliente : Ticket
    {
        static int nroInicio = 0;
        int dni;

        public Cliente(string dni)
        {
            if (int.TryParse(dni, out this.dni))
            {
                if (this.dni > 45000000 || this.dni < 3000000)
                {
                    throw new DNInvalidoException("DNI mayor a 45.000.000 o menor 3.000.000");
                }
                else
                {
                    nroOrden = ++nroInicio;
                }
            }
            else
            {
                throw new DNInvalidoException();
            }
        }
        public override void ExportarCSV(StreamWriter sw)
        {
            sw.WriteLine($"cliente;{nroOrden};{dni}");
        }
        public override string ToString()
        {
            return $"Cliente, {dni}";
        }
    }
}
