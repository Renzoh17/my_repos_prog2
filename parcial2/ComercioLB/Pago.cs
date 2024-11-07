using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    [Serializable]
    public class Pago : Ticket
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
            sw.WriteLine($"pago;{nroOrden};{ficha.VerNroCuenta()}");
        }

        public override string ToString()
        {
            return $"Pago, {ficha.VerTitular()}";
        }
    }
}
