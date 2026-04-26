using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub2
{
    internal class ValidareEx:Exception
    {
        public ValidareEx(string message):base(message) { }
    }
}
