﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoBasquet2024
{
    internal class Equipo
    {
        private ArrayList listaJugadores = new ArrayList();
        private Random rnd;
        private Jugador j;
        public int Cantidad
        {
            get { return listaJugadores.Count; }
        }
        private int puntos = 0;
        public int Puntos
        {
            private set { puntos += value; }
            get { return puntos; }
        }
        public Equipo()
        {
            listaJugadores.Capacity = 15;
        }

        public void AgregarJugador(Jugador jugad)
        { 
            listaJugadores.Add(jugad);
        }
        public bool QuitarJugador(int numero)
        {
            j = Buscar(numero);
            if (j != null)
            {
                listaJugadores.Remove(j);
                return true;
            }
            return false;
        }
        public void AgregarPuntos(int nro, int canasta)
        {
            if (j != null)
            {
                j.CargarPuntos(canasta);
                puntos = j.VerPuntos();
            }

        }
        Jugador Buscar(int nro)
        {
            foreach (object j in listaJugadores)
            {
                if (j is Jugador)
                {
                    if (((Jugador)j).Camiseta == nro)
                    {
                        return (Jugador)j;
                    }
                }
            }
            return null;
        }
        public Jugador VerJugadores(int pos)
        {
            return (Jugador)listaJugadores[pos];
        }
    }
}