using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar9__grafice {
    internal class Vanzare {

        private string luna;
        private int valoare;

        public Vanzare(string luna, int valoare) {
            this.luna = luna;
            this.valoare = valoare;
        }

        public string Luna { get => luna; }
        public int Valoare { get => valoare; }
    }
}
