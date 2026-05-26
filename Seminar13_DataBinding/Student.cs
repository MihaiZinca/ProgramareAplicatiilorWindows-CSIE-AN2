using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar13_DataBinding
{
    public class Student
    {

        private string nume;
        private string facultate;
        private float medie;
        private bool esteBuget;

        public Student(string nume, string facultate, float medie, bool esteBuget)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.medie = medie;
            this.esteBuget = esteBuget;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Facultate { get => facultate; set => facultate = value; }
        public float Medie { get => medie; set => medie = value; }
        public bool EsteBuget { get => esteBuget; set => esteBuget = value; }

        public override string ToString()
        {
            return nume + "-" + medie;
        }
    }

    
}
