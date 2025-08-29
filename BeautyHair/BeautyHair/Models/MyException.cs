using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHair
{
    internal class MyException : Exception
    {
        public MyException():base("Error desconocido") { }
        public MyException(string msg):base(msg) { }
        public MyException(string msg, Exception e):base(msg, e) { }
    }
}
