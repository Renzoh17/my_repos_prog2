using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class ClienteCuenta : IComparable<ClienteCuenta>, IExportable
    {
        public string Nombre { get; set; }
        public long Cuit {  get; set; }
        public double SaldoCuenta {  get; set; }
        public double Tope {  get; set; }
        public List<Pedido> listaPedidos = new List<Pedido>();

        public ClienteCuenta(string nombre, long cuit, double topeCuenta) 
        {
            Nombre = nombre;
            Cuit = cuit;
            Tope = topeCuenta;
            SaldoCuenta = 0;
        }
        public double AgregarPedido(Pedido nuevoPedido)
        {
            listaPedidos.Add(nuevoPedido);
            return nuevoPedido.Valor;
        }
        public bool AgregarPago(double monto)
        {
            bool b = false;
            double montoaux = SaldoCuenta - monto;
            if (montoaux >= 0)
            {
                SaldoCuenta -= monto;
                b = true;
            }
            return b;
        }
        public void AgregarCompra(double monto)
        {
            double montoaux = SaldoCuenta + monto;
            if (montoaux <= Tope)
            {
                SaldoCuenta += monto;
            }
            else
            {
                throw new SaldoException("Se supero el tope permitido.");
            }
        }
        public int CompareTo(ClienteCuenta cc)
        {
            return cc != null ? Cuit.CompareTo(cc.Cuit) : -1;
        }

        public string Escribir()
        {
            return $"{Nombre};{Cuit};{SaldoCuenta}";
        }
    }
}
