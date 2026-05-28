using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervareHotel
{
    public class Hotel:IRezervare,ICloneable
    {
        private string locatie;
        private int nrStele;
        private List<Rezervare> rezervari;

        public Hotel(string locatie, int nrStele, List<Rezervare> rezervari)
        {
            this.locatie = locatie;
            this.nrStele = nrStele;
            this.rezervari = new List<Rezervare>(rezervari);
        }

        public string Locatie { get => locatie; set => locatie = value; }
        public int NrStele { get => nrStele; set => nrStele = value; }
        public List<Rezervare> Rezervari { get => rezervari; set => rezervari = value; }


        private Rezervare this[int index]
        {
            get
            {
                if(index>=0 && index<rezervari.Count)
                    return rezervari[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < rezervari.Count)
                    rezervari[index] = value;
            }
        }

        public object Clone()
        {
           Hotel h=new Hotel(locatie, nrStele,rezervari);
           return h;
        }

        public void AfisareRezervare()
        {
            foreach (Rezervare r in rezervari)
                MessageBox.Show(r.ToString());
            
        }

        public override string ToString()
        {
            return $"{Locatie}|{nrStele}";
        }


        public static Hotel operator+(Hotel h, Rezervare r)
        {
            h.rezervari.Add(r);
            return h;
        }
    }
}
