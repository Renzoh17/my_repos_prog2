using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    [Serializable]
    internal class Gabinete : IComparable<Gabinete>
    {
        private List<Turno> turnosGab = new List<Turno>(10);
        private int nroGabinete;
        public int NroGabinete { get { return nroGabinete;} }

        public Gabinete(int nroGab) 
        {
            nroGabinete = nroGab;
        }

        void AgregarTurno(Turno turno)
        {
            turnosGab.Add(turno);
        }

        public int CompareTo(Gabinete g)
        {
            return g == null ? -1 : nroGabinete.CompareTo(g.nroGabinete);
        }
    }
}
