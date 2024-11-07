using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    [Serializable]
    public class Comercio: IExportable
    {
        List<CuentaCorriente> cuentasCorrientes = new List<CuentaCorriente>();
        Queue<Pago> nuevoP = new Queue<Pago>();
        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        List<Ticket> listaAtendidos = new List<Ticket>();
        public CuentaCorriente BuscarCuenta(int nro)
        {
            cuentasCorrientes.Sort();
            CuentaCorriente cc = new CuentaCorriente(nro, new Cliente("5000000"));
            int idx = cuentasCorrientes.BinarySearch(cc);
            return idx >= 0 ? cuentasCorrientes[idx] : null;
        }
        public void AgregarCuenta(CuentaCorriente cuenta)
        {
            CuentaCorriente cc = BuscarCuenta(cuenta.VerNroCuenta());
            if (cc != null)
            {
                cc.RegistrarPago(cuenta.VerSaldo());
            }
            else
            {
                cuentasCorrientes.Add(cuenta);
            }
        }
        public void AgregarTicket(Ticket turno)
        {
            if (turno is Cliente c)
            {
                nuevosClientes.Enqueue(c);
            }
            else if(turno is Pago p)
            {
                nuevoP.Enqueue(p);
            }
        }
        public Ticket AtenderTicket(int tipoTicket)
        {
            Ticket t = null;
            if (tipoTicket == 0)
            {
                if (nuevosClientes.Count != 0)
                {
                    t = nuevosClientes.Dequeue();
                }                  
            }
            else if (tipoTicket == 1)
            {
                if (nuevoP.Count != 0)
                {
                    t = nuevoP.Dequeue();
                }
            }
            return t;
        }
        public void ExportarCSV(StreamWriter sw)
        {
            foreach (Ticket t in listaAtendidos)
            {
                t.ExportarCSV(sw);
            }
        }
    }
}
