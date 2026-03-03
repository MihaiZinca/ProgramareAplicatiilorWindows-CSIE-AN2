using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Student:Persoana, IFormaFinantare, ICloneable, IComparable{

        private const string matricolBaza = "STUD";
        private static int nrStudenti = 0;
        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume, int varsta, bool areOchelari, double medie):base(nume,varsta,areOchelari) {
            nrStudenti++;
            matricol = matricolBaza+nrStudenti;
            this.medie = medie;
            materii=new List<string>();
        }

        public string AflaFormaFinantare() 
        {
           if(medie>8) return "Buget";
            else return "Taxa";
        }

        //Student s2=(Student)s1.Clone() in main   (Student) -unboxing gen -> s2 ia refereinta copiei mele 

        public object Clone() { //object obiectu defeault din c#, este al system.object, acest object e mama la toate clasele

            Student s = new Student(Nume, Varsta, AreOchelari, medie);
            return s; //returneaza un object - face boxing din student in object gen!  cand o folosim trebuie sa facem un unboxing 
        }

        //returneaza -1, 0  1
        //s1.CompareTo(s2) this=s1 si obs=s2
        public int CompareTo(object obj) {
            //verific ca tipul este student
            if(obj is Student) 
                {
                Student s = (Student)obj; //face unboxing pt a avea acces la atribute
                if (Varsta < s.Varsta) return -1;
                else 
                if (Varsta == s.Varsta) return 0;
                    else return 1;
                }
            return -2; //cel mai corect e sa aruncam o exceptie dar tot suntem obligatii sa returnam -2
        }

        public override string ToString() {
            //  return base.ToString(); //returneaza ToString din clasa de baza adica din Persoana chiar daca nu e definit urca mai sus si apealaza ToString din object
            return $"{Nume} ({Varsta}) {matricol} {medie} ";
   
        }

        //s1++;
        public static Student operator ++(Student s) {
            s.Varsta++;
            return s;
        }
        
        //cast la float implicit si explicit   implicit-nu mai trb sa pun gen (float)
        //float m=s1
        public static implicit operator float(Student s) {
            return (float)s.medie;
        }

        //ori facem explicit or implicit 

        //float m=(float)s1
        //public static explicit operator float(Student s) {
        //    return (float)s.medie;
        //}


        //s1=s1+"PAW"
        //s1+="PAW" 
        //adaug un nou element in lista de elemente
        public static Student operator+(Student s, string materie) {
            s.materii.Add(materie);
            return s;
        }

        //s1=s1-"PAW"
        //s1-="PAW"
        public static Student operator -(Student s, string materie) {
            s.materii.Remove(materie);
            return s;
        }

        //!s1
        public static bool operator!(Student s) {
            if (string.IsNullOrEmpty(s.Nume)) { // mergea si verificare == NULL sau cu length
                return true;
            }
            else return false;
        }

        //s1[0] --apelez get
        //s1[0]="POO" --apelez set
        //indexare practic proprietate care cotine get si set
        public string this[int index] {  //nu mai punem static ca este proprietate nu supraincarcare 
            get {  return this.materii[index]; }
            set { this.materii[index] = value; } 
            //se poate si fara this , si e recomandat sa verificam daca indexul se alfa in interval!
        }
    }
}
//interfata are doar semnatura functiei,
//iar clasa abstracta poate avea si semnatura functiei dar si metode implementate deja si se fol override

//metoda din interfata clone -- nu mai definm opera=

//metoda CompareTo si ret un int(-1 ,0(Daca sunt egale), 1(Daca ce am in dreapta > stanga)

//metoda ToString --practic << din c++