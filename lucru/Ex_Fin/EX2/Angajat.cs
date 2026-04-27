using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EX2
{
    public class Angajat:ITotalSalariu
    {
        private const string cod = "A";
        private static int nrAngajati = 0;

       
        private string nume;
        private int oreLucrate;
        private string matricol;
        private float salariuOrar;
        private float salariuLunar;

        public Angajat(string nume, int oreLucrate,float salariuOrar)
        {
            nrAngajati++;
            this.matricol = cod + nrAngajati;
            this.nume = nume;
            this.oreLucrate = oreLucrate;
            this.salariuOrar = salariuOrar;
        }

        public string Nume { get => nume; set => nume = value; }
        public int OreLucrate { get => oreLucrate; set => oreLucrate = value; }
        public float SalariuOrar { get => salariuOrar; set => salariuOrar = value; }
        public float SalariuLunar { get => salariuLunar; set => salariuLunar = value; }

        public void CalculeazaTotalSalariu()
        {
            salariuLunar = oreLucrate * salariuOrar;
        }

        public override string ToString()
        {
            return $"{nume}|{oreLucrate}|{matricol}|{salariuOrar}|{salariuOrar}";
        }
    }
}
