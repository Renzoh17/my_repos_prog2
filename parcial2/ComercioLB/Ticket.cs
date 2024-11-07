using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    [Serializable]
    public abstract class Ticket : IExportable
    {
        protected int nroOrden;
        DateTime fechaHora = DateTime.Now;

        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerFecha()
        {
            return fechaHora;
        }

        public abstract void ExportarCSV(StreamWriter sw);
    }
}
