using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Prog2_2025
{
    internal class Cliente
    {
        string nombre;
        string direccion;

        public Cliente(string nom, string dir)
        {
            nombre = nom;
            direccion = dir;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}, Direccion: {direccion}";
        }
    }
}
