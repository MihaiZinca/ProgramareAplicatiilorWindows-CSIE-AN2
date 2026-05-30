using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatiImobiliare
{
    public class Apartament
    {
        private List<Camera> camere;

        public Apartament()
        {
            camere= new List<Camera>();
        }

        public Apartament(List<Camera> camere)
        {
            this.camere = new List<Camera>(camere);
        }

        public List<Camera> Camere { get => camere; set => camere = value; }

        public double CalculSuprafata()
        {
            return camere.Sum(c => c.Suprafata);
        }
    }
}
