using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Farmacie
{
    [Serializable]
    internal class FisaPacient : IContabil, ICloneable
    {
        private string nume;
        private string simptome;
        private int durata_tratament;
        private List<Medicament> medicamente;

        public FisaPacient() { }

        public FisaPacient(string nume, string simptome, int durata_tratament, List<Medicament> medicamente)
        {
            this.nume = nume;
            this.simptome = simptome;
            this.durata_tratament = durata_tratament;
            this.medicamente = new List<Medicament>(medicamente);
        }

        public string Nume { get => nume; set => nume = value; }
        public string Simptome { get => simptome; set => simptome = value; }
        public int Durata_tratament { get => durata_tratament; set => durata_tratament = value; }

        public Medicament this[int index]
        { get => medicamente[index];
            set => medicamente[index] = value;
        }

        public float CalculPretTratament()
        {
            float total = 0;
            foreach (Medicament m in medicamente)
                total += (float)(m.Pret * m.Cantitate);
            return total;
        }

        public object Clone()
        {
            FisaPacient clona = new FisaPacient(Nume, Simptome, Durata_tratament, medicamente);
            foreach (Medicament m in medicamente)
                clona.medicamente.Add(m);
            return clona;
        }
        
        public static explicit operator double(FisaPacient f)
        {
            return (double)f.CalculPretTratament();
        }

        public override string ToString()
        {
            return $"{this.nume}  {this.simptome} {this.durata_tratament} {this.CalculPretTratament()}";
        }

    }
}


