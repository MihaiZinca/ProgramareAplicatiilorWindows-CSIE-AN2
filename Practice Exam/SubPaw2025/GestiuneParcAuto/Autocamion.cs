using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneParcAuto
{
    public class Autocamion:Autoturism,ICloneable,IComparable
    {
        private List<float> greutateMarfa;
        private int nrCurse;


        public Autocamion(int id, string proprietar, float pret, int nrLocuri, List<float> greutateMarfaCurse, int nrCurse) : base(id, proprietar, pret, nrLocuri)
        {
            this.greutateMarfa = greutateMarfaCurse;
            this.nrCurse = nrCurse;
        }

        public List<float> GreutateMarfa { get => greutateMarfa; set => greutateMarfa = value; }
        public int NrCurse { get => nrCurse; set => nrCurse = value; }

        public object Clone()
        {
            Autocamion clona = new Autocamion(Id, Proprietar, Pret,NrLocuri, greutateMarfa, NrCurse);
            foreach(float itm in greutateMarfa)
                greutateMarfa.Add(itm);
            return clona;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -2;
            if (!(obj is Autocamion))
                throw new ArgumentException("Ob nu este autocamion");
            Autocamion a=(Autocamion)obj;
            return NrCurse.CompareTo(a.NrCurse);
        }

        public static Autocamion operator +(Autocamion a, float greutate)
        {
            a.greutateMarfa.Add(greutate);
            return a;
        }

        public static explicit operator float(Autocamion a)
        {
            float medie = 0;
            for (int i = 0; i < a.greutateMarfa.Count; i++)
                medie += a.greutateMarfa[i];
            return medie / a.greutateMarfa.Count;
        }


    }
}
