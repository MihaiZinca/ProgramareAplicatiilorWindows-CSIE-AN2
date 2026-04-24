using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ex_Sala
{
    [Serializable]
    public class Abonament:ICost,ICloneable,IComparable
    {
        private int cod;
        private string tip;
        private double pret;
        private List<Client> clienti;

        public Abonament(int cod, string tip, double pret, List<Client> clienti)
        {
            this.cod = cod;
            this.tip = tip;
            this.pret = pret;
            this.clienti = new List<Client>(clienti);
        }

        public int Cod { get => cod; set => cod = value; }
        public string Tip { get => tip; set => tip = value; }
        public double Pret { get => pret; set => pret = value; }

        public double CalculeazaCost()
        {
            double total = 0;
            foreach (Client c in clienti)
                total += pret;
            return total;
        }

        public bool EsteValid()
        {
            return clienti.Count > 0;
        }

        public object Clone()
        {
            Abonament clona = new Abonament(Cod, Tip, Pret,clienti);
            foreach(Client c in clienti)
                clona.clienti.Add(c);
            return clona;
            
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -2;
            if (!(obj is Abonament))
                throw new ArgumentException("Ob nu este abonament");
            Abonament a= (Abonament)obj;
            return CalculeazaCost().CompareTo(a.CalculeazaCost());
        }

        public Client this[int index]
        {
            get
            {
                if (index >= 0 && index < clienti.Count)
                    return clienti[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index < clienti.Count)
                    clienti[index] = value;
            }
        }

        public static Abonament operator+(Abonament a,Client c)
        {
            a.clienti.Add(c);
            return a;
        }
        public static Abonament operator -(Abonament a, Client c)
        {
            a.clienti.Remove(c);
            return a;
        }

        public static bool operator>(Abonament a1,Abonament a2)
        {
            return a1.CalculeazaCost()>a2.CalculeazaCost();
        }
        public static bool operator <(Abonament a1, Abonament a2)
        { 
            return a1.CalculeazaCost() < a2.CalculeazaCost();
        }


        public override string ToString()
        {
            return $"{cod}|{tip}|{CalculeazaCost()}";
        }



    }
}
