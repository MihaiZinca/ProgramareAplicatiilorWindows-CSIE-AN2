using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar12_BD
{
    internal class Student
    {
        public int Id { get; set; }
        public string Nume {  get; set;}
        public decimal Medie { get; set;}

        public Student(int id,string nume,decimal medie)
        {
            Id = id;
            Nume = nume;
            Medie = medie;
        }
    }
}
