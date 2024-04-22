using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Task2
{
    internal class MyException : Exception
    {
        public MyException(string str) : base(str) { }
    }
}
