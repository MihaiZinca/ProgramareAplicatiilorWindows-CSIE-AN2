using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Farmacie
{
    [Serializable]
    internal class Medicament
    {

        private readonly int cod;
        private string denumire;
        private double pret;
        private double cantitate;

        public Medicament(int cod, string denumire, double pret, double cantitate)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public double Pret { get => pret; set => pret = value; }
        public double Cantitate { get => cantitate; set => cantitate = value; }

        public override string ToString()
        {
            return $"{cod} | {denumire} | {pret} |{cantitate}";
        }
    }
}
