using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia5_Repaso
{
    internal class Presupuesto
    {
        private double precio = 0;
        public double Precio 
        {
            get
            {
                foreach (Producto p in listaProducto) precio += p.Precio();
                return precio;
            }
        }
        private Cliente solicitante;
        private List<Producto> listaProducto = new List<Producto>();

        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto unProducto)
        {
            listaProducto.Add(unProducto);
        }
        public bool QuitarProducto(int codigo)
        {
            Producto p = BuscarProducto(codigo);
            return listaProducto.Remove(p);
        }
        private Producto BuscarProducto(int codigo)
        {
            Producto p = new Banco(0, 0);
            p.Codigo = codigo;
            int pos;
            listaProducto.Sort();
            pos = listaProducto.BinarySearch(p);
            if(pos >= 0) return listaProducto[pos];
            return null;
        }
        public string[] Resumen()
        {
            string[] sr = new string[listaProducto.Count];
            Producto p;
            for(int i = 0; i < listaProducto.Count; i++)
            {
                p = listaProducto[i];
                sr[i] = $"{p}, Precio: {p.Precio().ToString("$0.00")}";
            }
            return sr;
        }
    }
}
