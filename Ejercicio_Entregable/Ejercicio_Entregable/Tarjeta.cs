using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    internal class Tarjeta
    {
        private int[] ultimos10Viajes = new int[10];
        private static int tarjetasCreadas = 0;
        private int nroTarjeta;
        public int NroTarjeta { get { return nroTarjeta; } }
        private bool bloqueada = false;
        private decimal saldo;
        private static Random rand = new Random();

        public Tarjeta()
        {
            nroTarjeta = ++tarjetasCreadas;
            saldo = rand.Next(1000, 5000);
        }

        public void Bloquear()
        {
            bloqueada = true;
        }

        public bool DescontarSaldo(decimal costo)
        {
            if (costo <= saldo)
            {
                saldo -= costo;
                return true;
            }
            return false;
        }

        public int GetUltimos10Viajes(int i)
        {
            return ultimos10Viajes[i];
        }

    }
}
