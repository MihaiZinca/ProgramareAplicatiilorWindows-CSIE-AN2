using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Magazin
{
    public class Client:ICloneable,IComparable
    {
        private string nume;
        private int varsta;

        public Client() { }

        public Client(string nume, int varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }

        public object Clone()
        {
            Client c = new Client(Nume, Varsta);
            return c;
        }

        public int CompareTo(object obj)
        {
            Client c=(Client)obj;
            return c.varsta.CompareTo(varsta);

        }


        public override string ToString()
        {
            return $"Clientul {nume} de varsta {varsta}";
        }
    }
}
