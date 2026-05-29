using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public class Produs
    {
        private int id;
        private string denumireP;
        private double pret;
        private int cantitate;

        public Produs(int id, string denumireP, double pret, int cantitate)
        {
            this.id = id;
            this.denumireP = denumireP;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public int Id { get => id; set => id = value; }
        public string DenumireP { get => denumireP; set => denumireP = value; }
        public double Pret { get => pret; set => pret = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }

         public double Valoare
        {
            get{ return pret * cantitate; }
        }

        public override string ToString()
        {
            return $"{id}|{denumireP}|{pret}|{cantitate}";
        }


    }
}
