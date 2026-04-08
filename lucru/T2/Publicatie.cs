using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    [Serializable]
     public abstract class Publicatie
    {
        protected string titlu;
        protected double pret;

        public Publicatie(string titlu, double pret)
        {
            this.titlu = titlu;
            this.pret = pret;
        }

        public string Titlu { get=>titlu; set=>titlu = value; }
        public double Pret { get => pret; set => pret = value; }

        public abstract string genereazaReferinta();
       
    }
}
