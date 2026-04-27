using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    [Serializable]
    public class Persoana
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
                if(!(string.IsNullOrEmpty(value)))
                    nume = value;
            }
        }

        public string Prenume { get => prenume; set => prenume = value; }
        public int Varsta { get => varsta; set => varsta = value; }

        public override string ToString()
        {
            return $"{nume}|{prenume}|{varsta}";
        }

    }
}
