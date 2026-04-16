using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Magazin
{
    public class Produs:ICloneable,IComparable
    {
        private string denumire;
        private double pret;
        private int cantitate;

        public Produs() { }

        public Produs(string denumire, double pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string Denumire { get => denumire; set=>denumire= value; }
        public double Pret { get => pret; set=>pret= value; }
        public int Cantitate {  get => cantitate; set=>cantitate= value; }

        public object Clone()
        {
           Produs p=new Produs(Denumire, Pret, Cantitate);
           return p;
        }

        public int CompareTo(object obj)
        {

            //Produs p=(Produs)obj;
            //return pret.CompareTo(p.pret)
            if(obj is Produs)
            {
                Produs p=(Produs)obj;
                if (Pret < p.Pret) return -1;
                else if (Pret == p.Pret) return 0;
                else return 1;
            }
            return -1; 
        }

        public static bool operator>(Produs p1,Produs p2)
        {
            return p1.pret > p2.pret;
        }

        public static bool operator<(Produs p1, Produs p2)
        {
            return p1.pret < p2.pret;
        }

        public static Produs operator++(Produs p)
        {
            p.cantitate++;
            return p;
        }

        public override string ToString()
        {
            return $"Denumire produs{denumire} pret:{pret}, cantitate:{cantitate}";
        }


        
    }
}
