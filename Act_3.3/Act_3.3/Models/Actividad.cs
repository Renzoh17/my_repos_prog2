using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal abstract class Actividad
    {
        public int Periodo;
        public string Descripcion;
        List<Parcela> lotesAsignados = new List<Parcela>();

        public Actividad(int periodo, string descripcion)
        {
            Periodo = periodo;
            Descripcion = descripcion;
        }

        public double CalcularSuperfieOcupada()
        {
            double superficie = 0;
            foreach(Parcela p in lotesAsignados)
            {
                superficie += p.Superficie;
            }
            return superficie;
        }

        public abstract double CalcularRendimiento();
        public abstract double CalcularProduccion();
    }
}
