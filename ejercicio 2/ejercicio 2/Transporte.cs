using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
      abstract class  Transporte    
    {
          protected double precio;
          protected bool vuelta;
          public string Destino { get; set; }
        public abstract double Precio(bool vuelta);
        
        public Transporte(double precio, string destino)
        {
            this.precio = precio;
            Destino = destino;
        }
        public abstract override string ToString();
    }
}
