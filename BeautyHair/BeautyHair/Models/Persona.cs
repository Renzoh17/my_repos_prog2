using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyHair
{
    [Serializable]
    internal abstract class Persona : IImprimible, IComparable<Persona>
    {
        protected string nombre;
        public string Nombre { get { return nombre; } }
        protected string apellido;
        public string Apellido { get { return apellido; } }
        public string Direccion { get; set; }
        public int telefono { get; set; }
        protected int dni;
        public int Dni{ get{ return dni; } }

        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            string pattern = @"\d{8}";
            Match m = Regex.Match(dni, pattern);
            if (m.Success)
            {
                this.dni = Convert.ToInt32(m.Groups[0].Value);
            }
            else
            {
                throw new MyException("Dni con tamaño o formato incorrecto");
            }
        }

        public abstract string[] Mostrar();
        
        public virtual void Modificar(string nom, string apel)
        {
            nombre = nom;
            apellido = apel;
        }
        public int CompareTo(Persona p)
        {
            return p == null ? -1 : dni.CompareTo(p.dni);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}";
        }

        public string DatosCSV()
        {
            string datos = this is Cliente ? "c;" : "p;";
            return datos + $"{dni};{nombre};{Direccion};{telefono}";
        }

    }
}
