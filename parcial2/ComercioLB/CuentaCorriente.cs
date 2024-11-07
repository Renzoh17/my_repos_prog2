using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    [Serializable]
    public class CuentaCorriente : IComparable<CuentaCorriente>
    {
        int nroCuenta;
        Cliente titular;
        double saldo;

        public CuentaCorriente(int nro, Cliente titular)
        {
            nroCuenta = nro;
            this.titular = titular;
            saldo = 0;
        }
        public Cliente VerTitular()
        {
            return titular;
        }
        public int VerNroCuenta()
        {
            return nroCuenta;
        }
        public void RegistrarPago(double monto)
        {
            saldo += monto;
        }
        public void RegistrarVenta(double monto)
        {
            saldo -= monto;
        }
        public double VerSaldo()
        {
            return saldo;
        }

        public int CompareTo(CuentaCorriente cc)
        {
            return cc == null ? -1 : nroCuenta.CompareTo(cc.nroCuenta);
        }
    }
}
