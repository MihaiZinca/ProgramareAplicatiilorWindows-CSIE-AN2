using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traseu
{
    [Serializable]
    public class Traseu
    {
        private List<Locatie> locatii=new List<Locatie>();

        public delegate void DelegatModificareTraseu();

        [field: NonSerialized]
        public event DelegatModificareTraseu ModificareTraseu;

        public List<Locatie> Locatii { get => locatii;}
        public double LungimeTraseu
        {
            get
            {
                double lungime=0;
                for(int i=1;i<locatii.Count;i++)
                {
                    int dx = locatii[i].X - locatii[i - 1].X;
                    int dy = locatii[i].Y - locatii[i - 1].Y;
                    lungime += Math.Sqrt(dx * dx + dy * dy);
                }
                return lungime;
            }
        }

        public void AdaugaLocatie(Locatie l)
        {
            locatii.Add(l);
            ModificareTraseu?.Invoke();
        }

        
    }
}
