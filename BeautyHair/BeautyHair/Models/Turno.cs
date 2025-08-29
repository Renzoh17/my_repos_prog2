using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    [Serializable]
    internal class Turno
    {
        private DateTime fecha;
        private TimeSpan duracion;
        private string estado;
        private Cliente cliente;
        private Profesional profesional;
        private Tratamiento tratamiento;
        private Gabinete gabinete;
        public DateTime FechaHoraInicio 
        { 
            get
            {
                return fecha;
            }
        }
        public TimeSpan Duracion
        {
            get
            {
                return duracion;
            }
        }

        public Turno(DateTime fecha, Tratamiento tratamiento, Cliente cliente, Profesional profesional, Gabinete gabinete)
        {
            DateTime dt;
            int horas;
            switch (tratamiento)
            {
                case Tratamiento.Masaje:
                    horas = 2;
                    break;
                case Tratamiento.Depilacion:
                    horas = 1;
                    break;
                case Tratamiento.Peluqueria:
                    horas = 3;
                    break;
                case Tratamiento.Maquillaje:
                    horas = 2;
                    break;
                default:
                    horas = 2;
                    break;
            }
            dt = new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour + horas, fecha.Minute, fecha.Second);
            duracion = fecha - dt;
            this.fecha = fecha;
            this.tratamiento = tratamiento;
            this.cliente = cliente;
            this.profesional = profesional;
            this.gabinete = gabinete;
        }
        public void ReasignarTurno()
        {

        }
    }
}
