using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//clasa abstracta functii care au corp, interfectele doar semnaturii ale functiei

namespace ConsoleApp1 {
    internal abstract class CalculeazaAnNastere {
        public abstract int AflaAnNastere();

        public void Afiseaza() {
            Console.WriteLine("S-a apleat ceva din clasa abstracta");
        }

    }
}
