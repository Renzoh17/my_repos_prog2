using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    internal class DNInvalidoException : ApplicationException
    {
        public DNInvalidoException():base("Formato DNI incorrecto") { }
        public DNInvalidoException(string message) : base(message) { }
        public DNInvalidoException(string message, Exception inner) : base(message, inner) { }
    }
}
