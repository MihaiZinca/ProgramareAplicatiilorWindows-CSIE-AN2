using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sala
{
    [Serializable]
    public class Client
    {
        private int id;
        private string nume;
        private int varsta;

        public Client(int id, string nume, int varsta)
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
            return $"{id}|{nume}|{varsta}";
        }
    }
}
