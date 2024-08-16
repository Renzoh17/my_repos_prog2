using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoBasquet2024
{
    class Jugador
    {
        private int camiseta;
		private int[] puntos;
        private string nombre;
		public string Nombre
        {
            private set{nombre = value;}
			get {return "Jugador: " + nombre;}
        }
		public int Camiseta
        {
            //private set{camiseta = value;}
			get {return camiseta;}
        }
        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
			camiseta = numero;
            puntos = new int[3];
        }
        public void CargarPuntos (int canasta)
        {
            switch (canasta)
            {
                case 1:
                    puntos[0]++;break;
                case 2:
                    puntos[1]++;break;
                case 3:
                    puntos[2]++;break;
            }
        }

        public int VerPuntos()
        {
            return puntos[0] +puntos[1] * 2 + puntos[2] * 3;
        }
        public double PorcentajeSimples()
        {
			double total=0.0;
			foreach (int p in puntos)
			{
				total +=p;
			}
            return (puntos[0]* 100.0) / total;
        }
		 public double PorcentajeDobles()
        {
			double total=0.0;
			foreach (int p in puntos)
			{
				total +=p;
			}
            return (puntos[1]* 100.0) / total;
        }
		 public double PorcentajeTriples()
        {
			double total=0.0;
			foreach (int p in puntos)
			{
				total +=p;
			}
            return (puntos[2]* 100.0) / total;
        }
    }
}