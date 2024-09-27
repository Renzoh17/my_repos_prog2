using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class Bus: Transporte 
    {
        int estrellas;
        int id;
        public Bus(double precio, string destino, int id, int estrellas):base(precio,destino)
        {
            this.id = id;
            this.estrellas = estrellas;
        }
        public override double Precio(bool vuelta)
        {
            double precioaux = precio * 0.9;
            base.vuelta = vuelta;
            if (vuelta)
            {
                precioaux = (precio * 2) * 0.9;   
            }
            return precioaux;
        }
        public override string ToString()
        {
            return $"Bus: Destino: {Destino}";
        }
    }
}
