using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub1
{
    internal class ValidareException:Exception
    {
        public ValidareException(string message):base(message) { }
    }
}
