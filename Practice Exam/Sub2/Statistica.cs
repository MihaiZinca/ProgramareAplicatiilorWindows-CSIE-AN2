using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub2
{
    public class Statistica
    {
        private List<double>observatii=new List<double>();
        private List<double>indici=new List<double>();

        public List<double> Observatii { get => observatii;  }
        public List<double> Indici { get => indici;  }


        public delegate void DelegatModifi();
        public event DelegatModifi ModificareE;
        public void CalculeazaInidici()
        {
            indici.Clear();

            if (observatii.Count == 0)
                return;
           
            double x0 = observatii[0];
            for (int i = 0; i < observatii.Count; i++)
            {
                if (i == 0)
                    indici.Add(x0);
                else

                    indici.Add(observatii[i] / observatii[i - 1]);
            }
        }

        public void AdaugaObs(double val)
        {
            observatii.Add(val);
            CalculeazaInidici();
            ModificareE?.Invoke();
        }

        public void Modificare(int index,double val)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii[index] = val;
                CalculeazaInidici();
                ModificareE?.Invoke();
            }
        }

        public void Stergere(int index)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii.RemoveAt(index);
                CalculeazaInidici();
                ModificareE?.Invoke();
            }
        }
    }
}
