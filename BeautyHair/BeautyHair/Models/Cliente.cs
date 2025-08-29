using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    [Serializable]
    internal class Cliente : Persona
    {
        private List<Ficha> fichaList = new List<Ficha>(2);
        private static int contClientes = 0;
        public int ContClientes { get { return contClientes; } }
        public Cliente(string nombre, string apellido, string dni):base(nombre, apellido, dni)
        {
            contClientes++;
        }
        
        public void AgregarFicha(string obs, Turno turno)
        {
            fichaList.Add(new Ficha(obs, turno));
        }

        public override string[] Mostrar()
        {
            return new string[3] { "Nombre: " + nombre, "Apellido: " + apellido, "DNI: " + dni};
        }

    }
}
