using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTranzactie
{
    public class ExtrasCont:ITranzactie,ICloneable
    {
        private string numeClient;
        private string adresa;
        private List<Tranzactie> tranzactii;

        public ExtrasCont(string numeClient, string adresa,List<Tranzactie> tranzactii)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzactii = new List<Tranzactie>(tranzactii);
           
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Tranzactie> Tranzactii { get => tranzactii; set => tranzactii = value; }

        private Tranzactie this[int index]
        {
            get
            {
                if(index>=0 && index<tranzactii.Count)
                    return tranzactii[index];
                return null;
            }

            set
            {
                if(index>=0 && index<tranzactii.Count)
                    tranzactii[index]= value;
            }
        }

        public object Clone()
        {
            ExtrasCont ec=new ExtrasCont(numeClient, adresa,tranzactii);
            //foreach (Tranzactie t in tranzactii)
            //    ec.tranzactii.Add(t);
            return ec;
        }

        public void aifsareTranzactie()
        {
            foreach (Tranzactie t in tranzactii)
                Console.WriteLine(t);
        }

        public static explicit operator double(ExtrasCont e)
        {
            if (e.tranzactii.Count == 0) return 0;

            double suma = 0;
            foreach(Tranzactie t in e.tranzactii)
                suma += t.Suma;
            return suma / e.tranzactii.Count;
        }

        public override string ToString()
        {
            return $"{numeClient}|{adresa}";
        }
    }
}
