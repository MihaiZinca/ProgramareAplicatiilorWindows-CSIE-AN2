using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub2
{
    public class Firma
    {
        private string numeFirma;
        private List<Angajat> listaAngajati=new List<Angajat>();

        public Firma(string numeFirma)
        {
            this.numeFirma = numeFirma;
        }

        public string NumeFirma { get => numeFirma; set => numeFirma = value; }
        public List<Angajat> ListaAngajati { get => listaAngajati; }

        public override string ToString()
        {
            string rezultat =numeFirma + "\n";
            foreach (Angajat a in listaAngajati)
                rezultat += a.ToString() + "\n";
            return rezultat;
        }

        public static Firma operator+(Firma f,Angajat a)
        {
            f.listaAngajati.Add(a);
            return f;
        }

        public Angajat this[int index]
        {
            get
            {
                if(index>=0 &&index<listaAngajati.Count)
                    return listaAngajati[index];
                else return null;
            }
            set
            {
                if(index>=0 && index<listaAngajati.Count)
                    listaAngajati[index] = value;
            }
        }

    }
}
