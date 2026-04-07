using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1
{
    internal abstract class CalculeazaAnNastere
    {
        public abstract int AflaAnNastere();

        public void afiseaza()
        {
            Console.WriteLine("s-a apelat ceva din clasa abstracta");
        }
    }
}
