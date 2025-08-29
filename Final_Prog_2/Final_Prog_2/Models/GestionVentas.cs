using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class GestionVentas
    {
        Empresa dueño;
        double montoFacturado;
        readonly DateTime inicioOperaciones;
        static int nroPedido = 0;
        public List<Producto> lista = new List<Producto>();
        public List<ClienteCuenta> listaClientes = new List<ClienteCuenta>();

        public GestionVentas(long cuit, string razonSocial)
        {
            dueño = new Empresa(cuit, razonSocial);
            inicioOperaciones = DateTime.Now;
        }
        public void AgregarCliente(ClienteCuenta unCliente)
        {
            listaClientes.Add(unCliente);
        }
        ClienteCuenta BuscarCliente(long cuit)
        {
            ClienteCuenta cc = new ClienteCuenta("", cuit, 0);
            int idx = listaClientes.BinarySearch(cc);
            if (idx >= 0) cc = listaClientes[idx];
            else cc = null;
            return cc;
        }
        public Pedido GenerarPedido(List<Producto> lista)
        {
            Pedido p = new Pedido(++nroPedido, lista);
            return p;
        }
        public bool SumarPedido(ClienteCuenta cliente, Pedido nuevoPedido)
        {
            bool b = false;
            ClienteCuenta cc = BuscarCliente(cliente.Cuit);
            if(cc != null)
            {
                montoFacturado = cc.AgregarPedido(nuevoPedido);
                b = true;
                nuevoPedido.VerResumen();
                string d = $@"{$"Cliente: {cc.Nombre}"}
{$"Cuit: {cc.Cuit}"}

";
                nuevoPedido.Detalle += d;
            }
            return b;
        }
        public bool AgregarPago(long cuit, double monto)
        {
            bool b = false;
            ClienteCuenta cc = BuscarCliente(cuit);
            if(cc != null) b = cc.AgregarPago(monto);
            return b;
        }
        public void AgregarCompra(long cuit, double monto)
        {
            ClienteCuenta cc = BuscarCliente(cuit);
            if (cc != null) cc.AgregarCompra(monto);
        }
        public double VerSaldo(long cuit)
        {
            double saldo = 0;
            ClienteCuenta cc = BuscarCliente(cuit);
            if (cc != null) saldo = cc.SaldoCuenta;
            return saldo;
        }
    }
}
