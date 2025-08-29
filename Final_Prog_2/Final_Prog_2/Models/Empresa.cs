using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    [Serializable]
    internal class Empresa
    {
        long cuit;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Empresa(long cuit, string razonSocial)
        {
            this.cuit = cuit;
            RazonSocial = razonSocial;
        }
        public override string ToString()
        {
            return $"Cuit: {cuit}, Razon Social: {RazonSocial}";
        }
    }
}
