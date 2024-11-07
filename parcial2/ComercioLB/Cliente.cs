using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    [Serializable]
    public class Cliente : Ticket
    {
        static int nroInicio = 0;
        int dni;

        public Cliente(string dni)
        {
            if (int.TryParse(dni, out this.dni))
            {
                if (this.dni > 45000000 || this.dni < 3000000)
                {
                    throw new DNInvalidoException("DNI fuera de Rango");
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
