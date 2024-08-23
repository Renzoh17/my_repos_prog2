using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal sealed class Cliente : Persona
    {
        int nroCuenta;
        double saldo = 0;
        public Cliente(string nombre, long dni, int nro):base(nombre, dni) 
        {
            nroCuenta = nro;
        }
        public void AgregarCompra(double monto)
        {
            saldo += monto;
        }
        public int NroCuenta
        {
            get { return nroCuenta; }
        }
        public double Saldo
        {
            get { return saldo; }
        }
        public override string getNombre()
        {
            return nombre + " es Cliente";
        }
    }
}
