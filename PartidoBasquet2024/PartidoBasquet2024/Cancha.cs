using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoBasquet2024
{
    internal class Cancha
    {
        private string nombre, ubicacion;
        private int capacidad;
        public Cancha(string nombre, string ubicacion, int capacidad)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.capacidad = capacidad;
        }
    }
}
