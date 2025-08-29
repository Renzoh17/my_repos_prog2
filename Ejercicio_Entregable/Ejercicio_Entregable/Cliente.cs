using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    internal class Cliente
    {
        private int dni;
        public int Dni {  get { return dni; } }
        private string nombre;
        public string direccion;
        private Tarjeta tarjeta;

        public Cliente(string nombre, int dni, string direccion)
        {
            this.nombre = nombre;
            this.dni = dni; 
            this.direccion = direccion;
        }
        
        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            this.tarjeta = tarjeta;
        }
        
    }
}
