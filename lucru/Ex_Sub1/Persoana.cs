using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub1
{
    [Serializable]
    internal class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;

        public Persoana(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
        }

        public string Nume
        {
            get
            {
                if (!(string.IsNullOrEmpty(nume)))
                    return nume;
                else return null;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                    this.nume = value;
            }
        }

        public string Prenume
        {
            get
            {
                if (!(string.IsNullOrEmpty(prenume)))
                    return prenume;
                else return null;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                    this.prenume = value;
            }
        }

        public int Varsta
        {
            get
            {
                if (varsta > 0) return varsta;
                else return 0;
            }
            set
            {
                if(value > 0)
                    this.varsta = value;
            }
        }

        public override string ToString()
        {
            return $"{nume}|{prenume}|{varsta}";
        }
    }
}
