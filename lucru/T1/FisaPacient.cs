using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    [Serializable]
    public class FisaPacient:IContabil,ICloneable
    {
        private string nume;
        private string simptome;
        private int durata_tratament;
        private List<Medicament> medicamente;

        public FisaPacient(string nume, string simptome, int durata_tratament,List<Medicament> medicamente)
        {
            this.nume = nume;
            this.simptome = simptome;
            this.durata_tratament = durata_tratament;
            this.medicamente = new List<Medicament>();
            foreach(Medicament m in medicamente) 
                this.medicamente.Add(m);
        }

        public string Nume { get => nume; set => nume = value; }
        public string Simptome {  get => simptome; set => simptome = value; }
        public int Durata_tratament {  get => durata_tratament;set => durata_tratament = value;}

        //indexer
        public Medicament this[int index]
        {
            get
            {
                if(index>=0 && index<medicamente.Count)
                        return medicamente[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < medicamente.Count)
                    medicamente[index] = value;
            }
        }

        public float CalculPretTratament()
        {
            float total = 0;
            foreach (Medicament m in medicamente)
                total += (float)(m.Pret * m.Cantiate);
            return total;
        }

        public static explicit operator double(FisaPacient f)
        {
            return f.CalculPretTratament();
        }

        public object Clone()
        {
            FisaPacient clona = new FisaPacient(Nume, Simptome, Durata_tratament,medicamente);
            foreach(Medicament m in medicamente)
                clona.medicamente.Add(m); 
            return clona;
        }

        public override string ToString()
        {
            return $"{this.nume}  {this.simptome} {this.durata_tratament} {this.CalculPretTratament()}";
        }
    }
}
