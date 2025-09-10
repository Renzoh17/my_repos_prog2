using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Prog2_2025
{
    internal class Presupuesto
    {
        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (Producto p in listaProductos)
                    total = p.Precio();
                return total;
            }
        }
        Cliente solicitante;
        List<Producto> listaProductos;
        
        public Presupuesto(string nom, string dir)
        {
            solicitante = new Cliente(nom, dir);
            listaProductos = new List<Producto>();
        }
        public bool AgregarProducto(Producto unP)
        {
            bool r = false;
            Producto p = BuscarProducto(unP.Codigo);
            if (p == null)
            {
                listaProductos.Add(unP);
                r = true;
            }
            return r;
        }

        private Producto BuscarProducto(int codigo)
        {
            Producto p = new Banco(0, 0);
            p.Codigo = codigo;
            if (listaProductos.Count != 0)
            {
                listaProductos.Sort();
                int idx = listaProductos.BinarySearch(p);
                if (idx >= 0 && idx <= listaProductos.Count) p = listaProductos[idx];
                else p = null;
            } else p = null;
            return p;
        }

        public string[] Resumen()
        {
            string[] s = new string[3];
            int i = 0;
            foreach (Producto p in listaProductos)
            {
                s[i++] = p.ToString();
            }
                
            return new string[]
            {
                solicitante.ToString(),
                PrecioTotal.ToString(),
                s[0],
                s[1],
                s[2]
            };
        }
    }
}
