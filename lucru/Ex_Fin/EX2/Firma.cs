using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Firma
    {
        private string numeFirma;
        private List<Angajat> angajati;

        public Firma(string numeFirma)
        {
            this.numeFirma = numeFirma;
            this.angajati = new List<Angajat>();
        }

        public string NumeFirma { get => numeFirma; set => numeFirma = value; }
        public List<Angajat> Angajati { get => angajati; set => angajati = value; }

        public override string ToString()
        {
            string rez = numeFirma + "\n";
            foreach (Angajat a in angajati)
                rez += a.ToString() + "\n";
            return rez;
        }

        public static Firma operator+(Firma f,Angajat a)
        {
            f.angajati.Add(a);
            return f;
        }

        public Angajat this[int index]
        {
            get
            {
                if(index>=0 && index<angajati.Count)
                    return angajati[index];
                else return null;
            }
            set
            {
                if(index>=0 && index<angajati.Count)
                    angajati[index] = value;
            }
        }


    }
}
