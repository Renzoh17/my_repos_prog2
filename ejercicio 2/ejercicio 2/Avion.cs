using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class Avion:Transporte
    {
        string matricula;
        public Avion(double precio, string destino, string matricula):base(precio, destino)
        {
            base.precio = precio * 1.23;
            this.matricula = matricula;
        }
        public override double Precio(bool vuelta)
        {
            double precioaux = precio * 0.95;
            base.vuelta = vuelta;
            if (vuelta)
            {
                precioaux = (precio * 2) * 0.95;   
            }
            return precioaux;
        }
        public override string ToString()
        {
            return $"Avion: Destino: {Destino}";
        }
    }
}
