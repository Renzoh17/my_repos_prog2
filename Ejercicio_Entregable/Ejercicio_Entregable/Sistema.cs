using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    internal class Sistema
    {
        private ArrayList clientes = new ArrayList();
        private ArrayList tarjetas = new ArrayList();
        private decimal costo;

        public Sistema(decimal costo)
        {
            this.costo = costo;
        }

        void RegistrarCliente(string nombre, int dni, string direccion)
        {
            clientes.Add(new Cliente(nombre, dni, direccion));
        }

        void AsignarNuevaTarjeta(int dni)
        {
            Tarjeta tarj = new Tarjeta();
            tarjetas.Add(tarj);
            Buscar(dni).AgregarTarjeta(tarj);
        }

        void RegistrarViaje(int nro)
        {
            BuscarTarj(nro).DescontarSaldo(costo);
        }

        void VerUltimosViajes(int nro)
        {
            for(int i = 0; i < 10; i++) BuscarTarj(nro).GetUltimos10Viajes(i);
        }

        Cliente Buscar(int dni)
        {
            foreach (Object client in clientes)
            {
                if (client is Cliente)
                {
                    if (((Cliente)client).Dni == dni)
                    {
                        return (Cliente)client;
                    }
                }
            }
            return null;
        }

        Tarjeta BuscarTarj(int nro)
        {
            foreach(Object tarj in tarjetas)
            {
                if (tarj is Tarjeta)
                {
                    if (((Tarjeta)tarj).NroTarjeta == nro)
                    {
                        return (Tarjeta)tarj;
                    }
                }
            }
            return null;
        }
    }
}
