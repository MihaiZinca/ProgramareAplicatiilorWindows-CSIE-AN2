using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    [Serializable]
    public class Medicament
    {
        private readonly int cod;
        private string denumire;
        private double pret;
        private double cantiate;

       public Medicament(int cod, string denumire, double pret, double cantiate)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
            this.cantiate = cantiate;
        }

       public string Denumire { get => denumire; set=>denumire = value; }
       public double Pret { get => pret; set => pret = value; }
       public double Cantiate { get => cantiate; set => cantiate = value; }

        public override string ToString()
        {
            return $"Medicament {this.denumire} cod {this.cod} pret{this.pret} cantitate{this.cantiate}";
        }
    }
}
