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
        private Cancha cancha;

        public void AgregarEquipo(Equipo [] equipos)
        {
            local = equipos[0];
            visitante = equipos[1];
        }
        public Partido(Cancha cancha)
        {
            this.cancha = cancha;
        }
    }
}
