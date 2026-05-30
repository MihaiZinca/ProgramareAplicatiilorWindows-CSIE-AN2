using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatiImobiliare
{
    public class Camera
    {
        private double latime;
        private double lungime;
        private Orientare orientare;

        public Camera()
        {
        }

        public Camera(double latime, double lungime, Orientare orientare)
        {
            this.latime = latime;
            this.lungime = lungime;
            this.orientare = orientare;
        }

        public double Latime
        {
            get => latime;
            set
            {
                if (value < 0)
                    throw new Exception("Latimea trebuie sa fie pozitiva");
                latime= value;
            }
        }
        public double Lungime { 
            get => lungime;
            set
            {
                if (value <= 0)
                    throw new Exception("Lungimea trebuie sa fie pozitiva");
                lungime = value;
            }
        }
        public Orientare Orientare { 
            get => orientare;
            set
            {
                if (!Enum.IsDefined(typeof(Orientare), value))
                    throw new Exception("Orientare invalida");
                orientare = value;
            }
        }

        public double Suprafata => latime * lungime;
    }
}
