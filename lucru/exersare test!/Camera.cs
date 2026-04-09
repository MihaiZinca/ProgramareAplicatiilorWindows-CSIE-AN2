using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersare_test_
{
    [Serializable]   
    
   public class Camera:IComparable<Camera>
    {
        private readonly int cod;
        private string tip;
        private double pretPeNoapte;
        private bool disponibila;

        public Camera(int cod, string tip,double pretPeNoapte, bool disponibila)
        {
            this.cod= cod;
            this.tip=tip;
            this.pretPeNoapte=pretPeNoapte;
            this.disponibila=disponibila; 
        }

        public string Tip { get => tip; set => tip = value; }
        public double PretPeNoapte { get => pretPeNoapte; set => pretPeNoapte = value; }
        public bool Disponibila { get => disponibila; set => disponibila = value; }
        public override string ToString()
        {
            return $" Cod:{cod}, Tip:{Tip}, PretPeNoapte{PretPeNoapte}, Disponibila{Disponibila} ";
        }



        public int CompareTo(Camera other)
        {
            if (other == null) return 1;
            return this.pretPeNoapte.CompareTo(other.pretPeNoapte);
        }

    }
}
