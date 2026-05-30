using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliografice
{
    public abstract class Publicatie
    {
        protected string titlu;
        protected float pret;

        protected Publicatie(string titlu, float pret)
        {
            this.titlu = titlu;
            this.pret = pret;
        }
        public string Titlu { get => titlu; set => titlu = value; }
        public float Pret { get => pret; set => pret = value; }

        public abstract string genereazaReferinte();
    }
}
