using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3._3.Models
{
    internal class Campo
    {
        public string Identificador { get; set; }
        public double SuperficieTotal {  get; set; }
        List<Parcela> parcelas = new List<Parcela>();
        public Campo(string identificador, double superficie)
        {
            Identificador = identificador;
            SuperficieTotal = superficie;
        }

        public bool CrearParcela(string identificador, double superficie)
        {
            bool r = false;
            if (superficie > SuperficieOcupada() && BuscarParcela(identificador) < 0)
            {
                Parcela p = new Parcela(identificador, superficie);
                r = true;
            }
            return r;
        }

        private double SuperficieOcupada()
        {
            double superficieOcupada = 0;
            foreach (Parcela p in parcelas)
            {
                superficieOcupada += p.Superficie;
            }
            return superficieOcupada;
        }

        public int BuscarParcela(string identificador)
        {
            parcelas.Sort();
            return parcelas.BinarySearch(new Parcela(identificador, 0));
        }

        public override string ToString()
        {
            return $"{Identificador}({SuperficieTotal:f2})";
        }
    }
}
