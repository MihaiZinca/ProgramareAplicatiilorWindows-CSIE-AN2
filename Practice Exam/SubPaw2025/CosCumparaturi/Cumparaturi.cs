using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    public class Cumparaturi
    {
        private List<Produs> produse;

        public Cumparaturi()
        {
            this.produse = new List<Produs>();
        }

        public List<Produs> Produse { get => produse; set => produse = value; }

        public static Cumparaturi operator+(Cumparaturi c,Produs p)
        {
            c.produse.Add(p);
            return c;
        }

        public double Total()
        {
            double s = 0;
            foreach (Produs p in produse)
                s += p.Valoare;
            return s;
        }
    }
}
