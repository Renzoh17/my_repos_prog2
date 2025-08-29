using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    [Serializable]
    internal class Pago : Ticket
    {
        static int nroInicio = 0;
        CuentaCorriente ficha;

        public Pago(CuentaCorriente cuenta)
        {
            ficha = cuenta;
            nroOrden = ++nroInicio;
        }

        public void MontoPago(double valor)
        {
            ficha.RegistrarPago(valor);
        }

        public override void ExportarCSV(StreamWriter sw)
        {
            sw.WriteLine($"pago;{nroOrden};{ficha.VerTitular()};{ficha.VerNroCuenta()}");
        }
        public override string ToString()
        {
            return $"Pago, Titular: {ficha.VerTitular()}";
        }
    }
}
