using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar7
{
    internal class Produs
    {
        private string denumire;
        private double pret;
        private int cantitate;

        public Produs(string denumire, double pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire { get => denumire; set => denumire = value; }

        public double Pret { get => pret; set => pret = value; }

        public int Cantitate { get => cantitate; set => cantitate = value; }
    }
}
