using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidoBasquet2024
{
    internal class Partido
    {
        private Equipo local, visitante;
        private Cancha cancha1;

        public void AgregarEquipo(Equipo e1, Equipo e2)
        {
            local = e1;
            visitante = e2;
        }
        public Partido(Cancha cancha1)
        {
            this.cancha1 = cancha1;
        }
    }
    internal class Equipo
    {
        private ArrayList listaJugadores = new ArrayList();
        private Random rnd;
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
            foreach (object j in listaJugadores)
            {
                if (j is Jugador)
                {
                    if (((Jugador)j).Camiseta == numero)
                    {
                        listaJugadores.Remove(j);
                        return true;
                    }
                }
            }
            return false;

        }
        public void AgregarPuntos(int nro, int canasta)
        {
            //foreach (object j in listaJugadores)
            //{
            //    if (j is Jugador)
            //    {
            //        if (((Jugador)j).Camiseta == nro)
            //        {
            //            ((Jugador)j).CargarPuntos(canasta);
            //        }
            //    }
            //}
            if(nro >= 1 && nro <= 15) Buscar(nro).CargarPuntos(canasta);
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
    }
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
