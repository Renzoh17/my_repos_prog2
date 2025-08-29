using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    enum tipoTicket { Cliente, Pago }
    [Serializable]
    internal class Comercio : IExportable
    {
        List<Ticket> listaAtendidos = new List<Ticket>();
        List<CuentaCorriente> cuentasCorrientes = new List<CuentaCorriente>();
        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        Queue<Pago> nuevoP = new Queue<Pago>();

        public void AgregarTicket(Ticket turno)
        {
            if (turno != null)
            {
                if (turno is Cliente c)
                {
                    nuevosClientes.Enqueue(c);
                }
                else if (turno is Pago p)
                {
                    nuevoP.Enqueue(p);
                }
            }
        }
        public Ticket AtenderTicket(tipoTicket tipo)
        {
            if (tipo == tipoTicket.Cliente && nuevosClientes.Count != 0)
            {
                Cliente c = nuevosClientes.Dequeue();
                listaAtendidos.Add(c);
                return c;
            }
            else if(tipo == tipoTicket.Pago && nuevoP.Count != 0)
            {
                Pago p = nuevoP.Dequeue();
                p.MontoPago(1000);
                listaAtendidos.Add(p);
                return p;
            }
            return null;
        }
        public CuentaCorriente BuscarCuenta(int nro)
        {
            cuentasCorrientes.Sort();
            CuentaCorriente cc = new CuentaCorriente(nro, new Cliente("4000000"));
            int idx = cuentasCorrientes.BinarySearch(cc);
            return idx >= 0 ? cuentasCorrientes[idx] : null;
        }
        public void AgregarCuenta(CuentaCorriente cc)
        {
            int nro = cc.VerNroCuenta();
            CuentaCorriente cta = BuscarCuenta(nro);
            if (cta != null)
            {
                double saldo = cc.VerSaldo();
                cta.RegistrarPago(saldo);
            }
            else
            {
                cuentasCorrientes.Add(cc);
            }   
        }
        public void ExportarCSV(StreamWriter sw)
        {
            foreach(Ticket t in listaAtendidos)
            {
                t.ExportarCSV(sw);
            }
        }
    }
}
