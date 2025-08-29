using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    [Serializable]
    internal abstract class Ticket : IExportable
    {
        protected int nroOrden;
        DateTime fechaHora;

        public abstract void ExportarCSV(StreamWriter sw);

        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerFecha()
        {
            return fechaHora;
        }
    }
}
