using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sub1
{
    [Serializable]
    internal class Student:Persoana
    {
        private const string codMatricol = "STUD";
        private static int nrStudenti=0;

        private string matricol;
        private double medie;
        List<string> materii;

        public Student(string nume, string prenume, int varsta,string matricol,double medie,List<string>materi) : base(nume, prenume, varsta)
        {
            nrStudenti++;
            this.matricol = matricol+nrStudenti;
            this.medie= medie;
            this.materii= new List<string>(materi);
        }

        public string Matricol { get => matricol; }
        public double Medie { get => medie; }
        public List<string> Materii { get => materii; }

        public override string ToString()
        {
            return $"{Nume} {Prenume} {Varsta} {matricol} {medie} {materii}";
        }
        
        public static Student operator+(Student s,string materie)
        {
            s.materii.Add(materie);
            return s;
        }

        public string this[int index]
        {
            get
            {
                if(index>=0 &&index<materii.Count)
                    return materii[index];
                else return null;
            }

            set
            {
                if(index>=0 && index<materii.Count)
                    materii[index] = value;
            }
        }

    }
}
