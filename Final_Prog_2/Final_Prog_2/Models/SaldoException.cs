using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prog_2.Models
{
    internal class SaldoException : ApplicationException
    {
        public SaldoException():base("Error de Saldo"){ }
        public SaldoException(string message):base(message){ }
        public SaldoException(string message, Exception inner):base(message, inner) { }
    }
}
