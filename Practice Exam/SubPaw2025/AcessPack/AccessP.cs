using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessPack
{
    [Serializable]
    public class AccessP
    {
        private int id;
        private string nume;
        private double pret;

        public AccessP(int id, string nume, double pret)
        {
            this.id = id;
            this.nume = nume;
            this.pret = pret;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public double Pret { get => pret; set => pret = value; }

        public override string ToString()
        {
            return $"{id}|{nume}|{pret}";
        }
    }
}
