using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class Pedido : IExportable
    {
        public double Valor {  get; set; }
        public int Nro { get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalle {  get; set; }

        public Pedido(int nro, List<Producto> lista)
        {
            Nro = nro;
            FechaHora = DateTime.Now;
            
            foreach (Producto p in lista)
            {
                Valor = p.Precio(p.CantidadKilos); 
            }
        }
        public string VerResumen()
        {
            Detalle = $@"{$"Pedido Nro: {Nro.ToString("0000")}"}
{$"Fecha: {FechaHora.ToString("d")} Hora: {FechaHora.ToString("T")}"}
";
            return Detalle;
        }

        public string Escribir()
        {
            return $"{Nro};{FechaHora};{Detalle};{Valor}";
        }
    }
}
