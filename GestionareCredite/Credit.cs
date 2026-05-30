using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareCredite
{
    public class Credit
    {
        private string client;
        private double valoare;
        private double dobanda;
        private DateTime dataAcordare;
        private int perioada;

        public Credit(string client, double valoare, double dobanda,DateTime dataAcordare, int perioada)
        {
            this.client = client;
            this.valoare = valoare;
            this.dobanda = dobanda;
            this.dataAcordare = dataAcordare;
            this.perioada = perioada;
        }

        public string Client { get => client; set => client = value; }
        public double Valoare { get => valoare; set => valoare = value; }
        public DateTime DataAcordare { get => dataAcordare; set => dataAcordare = value; }
        public int Perioada { get => perioada; set => perioada = value; }
        public double Dobanda { get => dobanda; set => dobanda = value; }

        public override string ToString()
        {
            return $"{client}|{valoare}|{dobanda}|{dataAcordare}|{perioada}";
        }
    }
}
