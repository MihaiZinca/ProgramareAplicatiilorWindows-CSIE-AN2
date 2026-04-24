using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Biblioteca
{
    [Serializable]
    public class Cititor
    {
        private int id;
        private string nume;
        private int varsta;

        public Cititor(int id, string nume, int varsta)
        {
            this.id = id;
            this.nume = nume;
            this.varsta = varsta;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
     
        public int Varsta { get => varsta; set => varsta = value; }

        public override string ToString()
        {
            return $"{id}, {nume}, {varsta}";
        }
    }
}
