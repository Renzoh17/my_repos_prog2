using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo
{
    class Numeros
    {
        public readonly int CANTIDAD;
        private int[] valores;
       
        public Numeros()
            :this(5)
        {}
        public Numeros(int cantidad)
        {
            CANTIDAD = cantidad;
            valores = new int[CANTIDAD];
            for (int x = 0; x <CANTIDAD; x++)
                valores[x] = (x+1) * 2;
        }
        public int[] Valores()
        {
            return valores;
            //CANTIDAD = 4;
        }
    }
}
