using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_elem
{
    class Element
    {
        public event Action<Element> Ev_Mod_Valoare;
        int val;
        public Element() { val = 0; }
        public int Valoare
        {
            get => val;
            set
            {
                if(val != value)
                {
                    val = value;
                    //if (Ev_Mod_Valoare != null) Ev_Mod_Valoare(this);
                    Ev_Mod_Valoare?.Invoke(this);
                }
            }
        }

        public int Patrat => val * val;
    }
}
