using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditareImagini
{
    [Serializable]
    public class Poligon
    {

        private List<Punct>puncte=new List<Punct>();

        private string culoare;
        private int grosimeLinie;
        private int codFigura;
        private string eticheta;

        public Poligon(string culoare, int grosimeLinie, int codFigura, string eticheta)
        {
            this.culoare = culoare;
            this.grosimeLinie = grosimeLinie;
            this.codFigura = codFigura;
            this.eticheta = eticheta;
        }

        public Poligon(int codFigura)
        {
            this.codFigura = codFigura;
        }

        public string Culoare { get => culoare; set => culoare = value; }
        public int GrosimeLinie { get => grosimeLinie; set => grosimeLinie = value; }
        public int CodFigura { get => codFigura;}
        public string Eticheta { get => eticheta; set => eticheta = value; }
        public List<Punct> Puncte { get => puncte; set => puncte = value; }

        public Punct this[int index]
        {
            get
            {
                if(index>=0 && index<puncte.Count)
                    return puncte[index];
                return null;
            }

            set
            {
                if (index >= 0 && index < puncte.Count)
                    puncte[index] = value;
            }
        }

        public void AdaugaPunct(Punct p)
        {
            puncte.Add(p);
        }

        public double CalculPerimetru()
        {
            double p = 0;
            for(int i=0;i<puncte.Count;i++)
            {
                Punct a = puncte[i];
                Punct b = puncte[(i+1)%puncte.Count];

                p += Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            }
            return p;
        }
    }
}
