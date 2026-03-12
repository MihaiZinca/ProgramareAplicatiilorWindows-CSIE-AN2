using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
       class Element
        {
            int valoare_element;
            public event Action<Element> eveniment_modificare_valoare;
            public Element()
            {
                this.valoare_element = 0;
            }

            public int Valoare
            {
                get => this.valoare_element;
                set
                {
                    if (valoare_element != value)
                    {
                        this.valoare_element = value;
                       // if (eveniment_modificare_valoare != null)eveniment_modificare_valoare(this);
                       //echivalente
                       eveniment_modificare_valoare?.Invoke(this);
                    }
                }
            }

            public int Patrat => this.valoare_element * this.valoare_element;


        }
    
}
