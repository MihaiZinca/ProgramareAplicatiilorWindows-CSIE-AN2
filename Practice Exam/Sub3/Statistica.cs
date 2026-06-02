using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub3
{
    public class Statistica
    {
        private List<double> observatii=new List<double>();
        private List<double> ponderii=new List<double>();

        public List<double> Observatii { get => observatii; }
        public List<double> Ponderii { get => ponderii; }

        public delegate void DelegatModificare();

        public event DelegatModificare Modifi;


        public void CalcularePonderi()
        {
            ponderii.Clear();
            if (observatii.Count == 0) return;

            double sumaTotala = observatii.Sum();

            for(int i = 0; i < observatii.Count;i++)
            {
               
                ponderii.Add(observatii[i] / sumaTotala);
            }
        }

        public void AdaugareObs(double val)
        {
            observatii.Add(val);
            CalcularePonderi();
            Modifi?.Invoke();
        }

        public void Modificare(int index,double val)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii[index] = val;
                CalcularePonderi();
                Modifi?.Invoke();
            }
        }

        public void Stergere(int index)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii.RemoveAt(index);
                CalcularePonderi();
                Modifi?.Invoke();
            }
        }
    }
}
