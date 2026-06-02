using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub4
{
    public class Statistica
    {
        private List<double> observatii=new List<double>();
        private List<int> frecvente=new List<int>();

        public List<double> Observatii { get => observatii; }
        public List<int> Frecvente { get => frecvente; }


        public delegate void DelegatModificare();
        public event DelegatModificare Modifi;

        public double CalcularMedie()
        {
            double suma = 0;
            double totalF = 0;

            for(int i=0;i<observatii.Count;i++)
            {
                suma += observatii[i] * frecvente[i];
                totalF += frecvente[i];
            }

            if (totalF == 0) return 0;

            return suma / totalF;
        }

        public void Adaugare(double val)
        {
            int index = observatii.IndexOf(val);

            if (index == -1)
            {
                observatii.Add(val);
                frecvente.Add(1);
            }
            else
                frecvente[index]++;

            Modifi?.Invoke();
        }

        public void Modificare(int index,double val)
        {
            if(index>=0 && index<observatii.Count)
            {
                double veche=observatii[index];
                int frecv = frecvente[index];

                observatii.RemoveAt(index);
                frecvente.RemoveAt(index);

                int ind = observatii.IndexOf(val);

                if (ind == -1)
                {
                    observatii.Add(val);
                    frecvente.Add(frecv);
                }
                else
                    frecvente[ind] += frecv;
                Modifi?.Invoke();
            }

        }

        public void stergerSimpla(int index)
        {
            if(index>=0 &&index<observatii.Count)
            {
                frecvente[index]--;

                if (frecvente[index]<=0)
                {  observatii.RemoveAt(index);
                    frecvente.RemoveAt(index);
                }

                Modifi?.Invoke();
            }
        }

        public void StergereCompleta(int index)
        {
            if(index>=0 && index<observatii.Count)
            {
                observatii.RemoveAt(index);
                frecvente.RemoveAt(index);

                Modifi?.Invoke();
            }
        }
    }
}
