using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sala
{
    public class Validare:Exception
    {
        public Validare(string message):base(message) { }
    }
}
