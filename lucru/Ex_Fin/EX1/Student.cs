using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    [Serializable]
    public class Student:Persoana
    {
        private const string codMatricol = "m";
        private static int nrStudenti = 0;

        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume, string prenume, int varsta,string matricol,double medie,List<string>mat) : base(nume, prenume, varsta)
        {
            nrStudenti++;
            this.matricol=matricol+nrStudenti;
            this.medie=medie;
            this.materii = new List<string>(mat);
        }

        public string Matricol { get => matricol; set => matricol = value; }
        public double Medie { get => medie; set => medie = value; }
        public List<string> Materii { get => materii; set => materii = value; }

        public override string ToString()
        {
            return $"{Nume}|{Prenume}|{Varsta}|{matricol}|{medie}|{string.Join(",", materii)}";
        }

        public static Student operator+(Student s,string m)
        {
            s.materii.Add(m);
            return s;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < materii.Count)
                    return materii[index];
                else return null;
            }
            set
            {
                if(index >= 0 && index<materii.Count)
                    materii[index] = value;
            }
        }

    }
}
