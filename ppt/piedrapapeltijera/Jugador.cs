using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace piedrapapeltijera
{
    internal class Jugador
    {
        private string nombre;
        private double porPiedra = 0, porPapel = 0, porTijera = 0;
        private int contPiedra = 0, contTijera = 0, contPapel = 0;
        static Random elegir = new Random();
        private int puntos;

        public int Puntos {  get { return puntos; } set {  puntos += value; } }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public Jugador()
        {
            this.nombre = "PC";
        }
        
        public void Jugar(int elemento) //Jugador 
        {
            switch (elemento)
            {
                case 0:
                    contPiedra++;
                    break;
                case 1:
                    contPapel++;
                    break;
                case 2:
                    contTijera++;
                    break;
            }
        }

        public int Jugar() //PC
        {
            int elemento = elegir.Next(3);
            Jugar(elemento);
            return elemento;
        }

        public double[] Resumen()
        {
            porPapel = (contPapel / (contPiedra + contTijera + contPapel)) * 100;
            porPiedra = (contPiedra / (contPiedra + contTijera + contPapel)) * 100;
            porTijera = (contTijera / (contPiedra + contTijera + contPapel)) * 100;
            double[] resumen = new double[3] {porPapel, porPiedra, porTijera};
            return resumen;
        }
    }
}
