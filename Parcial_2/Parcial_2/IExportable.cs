using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    internal interface IExportable
    {
        void ExportarCSV(StreamWriter sw);
    }
}
