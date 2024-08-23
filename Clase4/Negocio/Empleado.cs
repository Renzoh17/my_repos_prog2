using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal sealed class Empleado : Persona
    {
        double sueldo, comision;
        public Empleado(string nombre, long dni, double sueldo):base(nombre, dni)
        {
            this.sueldo = sueldo;
        }
        public void Vender(double monto)
        {
            comision += monto * 10 / 100;
        }
        public double Sueldo()
        {
            return sueldo + comision;
        }
        public override string getNombre()
        {
            return nombre + " es Empleado";
        }
    }
}
