using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersare_test_
{
    [Serializable]
    public class Rezervare:ITarif,ICloneable,IComparable<Rezervare>
    {
        private string numeClient;
        private int nrNopti;
        private List<Camera> camere;

        public Rezervare(string numeClient, int nrNopti, List<Camera> camere)
        {
            this.numeClient = numeClient;
            this.nrNopti = nrNopti;
            this.camere = new List<Camera>(camere);
          

        }

        public string NumeClient { get => numeClient; set=>numeClient = value; }    
        public int NrNopti { get => nrNopti;set=>nrNopti=value; }

        public double CalculCostTotal()
        {
            double total = 0;
            foreach (Camera c in camere)
                total += (c.PretPeNoapte * nrNopti);
            return total;
        }

        public override string ToString()
        {
            return $"{numeClient} - {nrNopti} nopti - {CalculCostTotal()} lei";
        }

        public object Clone()
        {
            Rezervare clona=new Rezervare(numeClient,nrNopti, camere);
            foreach (Camera c in camere)
                clona.camere.Add(c);
            return clona;
        }

        public int CompareTo(Rezervare other)
        {
            if(other == null) return 1;
            return this.CalculCostTotal().CompareTo(other.CalculCostTotal());
        }


        public Camera this[int index]
        {
            get { return this.camere[index]; }
            set { this.camere[index] = value; }
        
        }
        
        public static Rezervare operator+(Rezervare r,Camera c)
        {
            r.camere.Add(c);
            return r;
        }
        
        public static bool operator>(Rezervare r1,Rezervare r2)
        {
            return r1.CalculCostTotal()>r2.CalculCostTotal();
        }

        public static bool operator<(Rezervare r1,Rezervare r2)
        {
            return r1.CalculCostTotal()<r2.CalculCostTotal();
        }

        public static explicit operator double(Rezervare r)
        {
            return r.CalculCostTotal();
        }
    }
}
