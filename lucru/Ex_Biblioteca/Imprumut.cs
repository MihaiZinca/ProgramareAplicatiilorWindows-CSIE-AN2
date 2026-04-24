using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Biblioteca
{
    [Serializable]
    public class Imprumut:ICost,ICloneable,IComparable
    {
        private int id_imprumut;
        private List<Carte> listaCarti;
        private Cititor cititor;
        private int zileImprumut;

        public Imprumut(int id_imprumut,Cititor cititor, int zileImprumut)
        {
            this.id_imprumut = id_imprumut;
            this.listaCarti = new List<Carte>();
            this.cititor = cititor;
            this.zileImprumut = zileImprumut;
        }

        public int Id_imprumut { get => id_imprumut; set => id_imprumut = value; }
        public Cititor Cititor { get => cititor; set => cititor = value; }
        public int ZileImprumut { get => zileImprumut; set => zileImprumut = value; }

        public object Clone()
        {
            Imprumut clona = new Imprumut(Id_imprumut, Cititor, ZileImprumut);
            foreach(Carte c in listaCarti)
                clona.listaCarti.Add(c);
            return clona;
        }
        public double CalculeazaCost()
        {
            double total = 0;
            foreach (Carte c in listaCarti)
                total += c.Pret;
            return total*zileImprumut;
        }
        public bool EsteValid()
        {
            return listaCarti.Count > 0;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -2;
            if (!(obj is Imprumut))
                throw new ArgumentException("Obj nu este imprumut");
            Imprumut i= (Imprumut)obj;
            return this.CalculeazaCost().CompareTo(i.CalculeazaCost());
                
        }

        public static Imprumut operator+(Imprumut i,Carte c)
        {
            i.listaCarti.Add(c);
            return i;
        }

        public static Imprumut operator -(Imprumut i, Carte c)
        {
            i.listaCarti.Remove(c);
            return i;
        }

        public static bool operator>(Imprumut i1, Imprumut i2)
        {
            return i1.CalculeazaCost() > i2.CalculeazaCost();
        }

        public static bool operator <(Imprumut i1, Imprumut i2)
        {
            return i1.CalculeazaCost() < i2.CalculeazaCost();
        }

        public Carte this[int index]
        {
            get
            {
                if (index >= 0 && index < listaCarti.Count)
                    return listaCarti[index];
                else return null;
            }
            set
            {
                if(index >= 0 && index<listaCarti.Count)
                    listaCarti[index] = value;
            }
        }

        public override string ToString()
        {
            return $"{cititor.Nume} {CalculeazaCost()}";
        }
    }
}
