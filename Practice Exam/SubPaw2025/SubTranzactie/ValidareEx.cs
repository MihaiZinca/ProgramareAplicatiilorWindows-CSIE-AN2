using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTranzactie
{
    public class ValidareEx:Exception
    {
        public ValidareEx(string message):base(message) { }
    }
}
