using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLB
{
    public class DNInvalidoException : ApplicationException
    {
        public DNInvalidoException():base("DNI con Formato Incorrecto") { }
        public DNInvalidoException(string message) : base(message) { }
        public DNInvalidoException(string message, Exception inner):base(message, inner) { }
    }
}
