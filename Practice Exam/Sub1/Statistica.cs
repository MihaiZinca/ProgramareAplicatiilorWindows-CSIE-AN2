using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub1
{
    public class Statistica
    {
        private List<double> observatii=new List<double>();
        private List<double> indiciBaza=new List<double>();

        public List<double> Observatii { get => observatii; }
        public List<double> IndiciBaza { get => indiciBaza; }

        public delegate void DateModificate();
        public event DateModificate DateModif;


        public void CalculeazaIndici()
        {
            indiciBaza.Clear(); 

            if (observatii.Count == 0)
                return;
            double x0 = observatii[0];
            for(int i=0;i<observatii.Count;i++)
            {
                if(i==0)
                    indiciBaza.Add(1);
                else 
                    indiciBaza.Add(observatii[i]/x0);

            }
        }

        public void AdaugaObs(double val)
        {
            observatii.Add(val);
            CalculeazaIndici();
            DateModif?.Invoke();
        }

        public void Modifica(int index,double val)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii[index] = val;
                CalculeazaIndici();
                DateModif?.Invoke();
            }
        }

        public void Sterge(int index)
        {
            if (index >= 0 && index < observatii.Count)
            {
                observatii.RemoveAt(index);
                CalculeazaIndici();
                DateModif?.Invoke();
            }
        }

    }
}
