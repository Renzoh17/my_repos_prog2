using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class InvalidoException : ApplicationException
    {
       public InvalidoException()
                :base("Error de datos")
            {
            }
            public InvalidoException(string msg)
                :base(msg)
            {
            }
            public InvalidoException(string msg, Exception e)
                :base(msg, e)
            {
            }
    }
}
