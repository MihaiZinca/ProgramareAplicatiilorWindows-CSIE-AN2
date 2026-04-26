using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub2
{
    public class Angajat : ITotalSalariu
    {
        private const string cod = "A";
        private static int nrAngajati = 0;

        private string nume;
        private string matricol;
        private int oreLucrate;
        private float salariuOrar;

        public float salariuLunar;
        public Angajat(string nume, int oreLucrate, float salariuOrar)
        {
            nrAngajati++;
            matricol = cod + nrAngajati;
            this.nume = nume;
            this.oreLucrate = oreLucrate;
            this.salariuOrar = salariuOrar;
        }

        public string Nume { get => nume; set => nume = value; }
        public int OreLucrate { get => oreLucrate; set => oreLucrate = value; }
        public float SalariuOrar { get => salariuOrar; set => salariuOrar = value; }
        public string Matricol { get => matricol; set => matricol = value; }


        public void calculeazaTotalSalariu()
        {
            salariuLunar = oreLucrate * salariuOrar;
        }

        public override string ToString()
        {
            return $"{nume}|{oreLucrate}|{salariuOrar}|{salariuLunar}";
        }

    }
}
