using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace s1
{
    internal class Student:Persoana,IFormaFinantare,ICloneable,IComparable
    {

        private const string matricolBaza = "STUD";
        private static int nrStudenti = 0;

        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume,int varsta,bool areOchelari,double medie):base(nume,varsta,areOchelari)
        {
            nrStudenti++;
            matricol = matricolBaza + nrStudenti;
            this.medie = medie;
            materii = new List<string>();

        }

        public double Medie
        {
            get => medie;
            set => medie = value;
        }

        public string AflaFormaFinantare()
        {
            if (medie > 8) return "Buget";
            else return "Taxa";
        }
        
        //abstract class- spune CE+uneori Cum -BAZA CU LOGICA
        //poate cod, variabile, constructor, moseneste doar UNA

        //interfata doar ce trebuie facut -CONTRACT
        //fara implementare,fara variabile,fara constructor,implementare multipa


        public Object Clone()
        {
            Student s = new Student(Nume, Varsta, AreOchelari, medie);
            foreach (string m in materii)
                s.materii.Add(m);

            return s; // cand folosoim trb sa facem unboxing
        }

        //ret -1,0,1
        public int CompareTo(object obj)
        {
            if(obj is Student)
            {
                Student s= (Student)obj; //unboxing pt a avea acces la atribue
                if (Varsta < s.Varsta) return -1;
                else if (Varsta == s.Varsta) return 0;
                else return 1;

            }

            return -2;
        }

        public override string ToString()
        {
            return $"{Nume} ({Varsta}) {matricol} {medie}";
        }

        //s1++
        public static Student operator++(Student s)
        {
            s.Varsta++;
            return s;
        }
        
        //s1--
        public static Student operator--(Student s)
        {
            s.Varsta--;
            return s;
        }

        //cast la float implicit fara(float) in main
        public static implicit operator float(Student s)
        {
            return (float)s.medie;
        }

        //cast la float expliciti cu (float) in main
        //public static explicit operator float(Student s)
        //{ return (float)s.medie;}


        //s1=s1+" "
        //s1+=" "
        public static Student operator+(Student s,string materie)
        {
            s.materii.Add(materie);
            return s;
        }

        //s1=s1-" "
        //s1-=" 
        public static Student operator-(Student s,string materie)
        {
            s.materii.Remove(materie);
            return s;
        }

        //!s1
        public static bool operator!(Student s)
        {
            if (string.IsNullOrEmpty(s.Nume))
                return true;
            else return false;
        }
        
        //s1==s2
        public static bool operator==(Student s1,Student s2)
        {
            return s1.matricol == s2.matricol;
        }

        public static bool operator!=(Student s1,Student s2)
        {
            return s1.matricol != s2.matricol;
        }


        //s1>s2 cand suprascriu > trebuie sa le am pe ambele( > si <)
        public static bool operator>(Student s1,Student s2)
        {
            if (s1.medie > s2.medie) return true;
            else return false;
        }

        public static bool operator<(Student s1,Student s2)
        {
            return s1.medie < s2.medie;
        }

       //indexare - apelez propr care contin get si set -vector
       public string this[int index]
        {
            get { return this.materii[index]; }
            set {  this.materii[index]= value; }
        }


        //indexare -matrice
        private double[,] note;
        public double this[int i,int j]
        {
            get => note[i, j];
            set => note[i,j]= value;
        }



    }
}
