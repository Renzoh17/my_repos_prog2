using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploPolimorfismo
{
    [Serializable]
    class Gato:Animal
    {
        string ruido = "Miau ";
        public Gato(string nombre, DateTime fecha, string ruido)
            : base(nombre, fecha)
        {
            this.ruido += ruido;
        }

        public override string Datos()
        {
            return "Gato: " + base.nombre + " Grito: " + Grito();
        }
        public override string Grito()
        {
            return ruido;
        }
    }
}
