using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana("Andrei", 21, true);
            Persoana p3 = new Persoana()
            {
                Nume="Popescu",
                Varsta=22,
                AreOchelari=true
                //aici apelez constructorul fara param +proprietati
            };

            Console.WriteLine($"{p1.Nume}{p1.Varsta}{p1.AreOchelari}");
            Console.WriteLine($"{p2.Nume} {p2.Varsta} {p2.AreOchelari} ");
            Console.WriteLine($"{p3.Nume} {p3.Varsta} {p3.AreOchelari} ");

            Console.WriteLine(p3.Nume.ToUpper());
            Console.WriteLine(p3.Nume.ToLower());
            Console.WriteLine(p3.Nume.Substring(1));
            Console.WriteLine(p3.Nume.Substring(1,3));
            Console.WriteLine(p3.Nume.Split(' ')[0][1]);

            List<Persoana> persoane=new List<Persoana> { p1, p2, p3 };
            
            var persoaneCuOchelari=persoane
                .Where(p=>p.AreOchelari &&p.Varsta>20)
                .Select(p => p.Nume)
                .ToList();

            persoaneCuOchelari.ForEach(nume => Console.WriteLine(nume));

            foreach(string p in persoaneCuOchelari)
                Console.WriteLine(p);


            Student s1 = new Student("Andrei", 21, true, 9.2);
            s1 += "Matematica";
            s1 += "Informatica";

            Student s2 =(Student)s1.Clone();
            s2.Nume = "Andrei Clona";
            s2[0] = "Fizica";
            Console.WriteLine("Student1: " + s1);
            Console.WriteLine("Student2(clona): " + s2);

            int comp=s1.CompareTo(s2);
            if (comp == 0) Console.WriteLine("Studentiii au aceeasi varsta");
            else if (comp > 0) Console.WriteLine("Stud 1 este mai mare");
            else Console.WriteLine("Stud 2 este mai mare");


            List<Student> studenti = new List<Student>();
            studenti.Add(new Student("Ana", 20, false, 9.5));
            studenti.Add(new Student("Ion", 22, true, 8.7));
            studenti.Add(new Student("Maria", 19, false, 9.0));

            studenti.Sort();

            foreach(var s in studenti)
            {  Console.WriteLine(s); }

            //crescator dupa medie
            studenti.Sort((s1, s2) => s1.Medie.CompareTo(s2.Medie));
            //desc
            studenti.Sort( (s1,s2)=>s2.Medie.CompareTo(s1.Medie));

            Student m = new Student("Ana", 20, false, 9.5);
            m[0, 0] = 9.5;
            m[0, 1] = 8.7;
            m[1, 0] = 10;
            Console.WriteLine(m[0, 0]); // 9.5
            Console.WriteLine(m[1, 0]); // 10
        }
    }
}
