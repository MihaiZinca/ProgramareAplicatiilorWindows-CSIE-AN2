using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            Persoana p1=new Persoana();
            Persoana p2=new Persoana("Andrei",21,true);

            Persoana p3 = new Persoana() {
                Nume = "Popescu Ion",
                Varsta = 22,
                AreOchelari = true
                //apelez constructorul fara param + proprietati  // merg folos ambele metode gen p2
            };

            Console.WriteLine($"{p1.Nume} {p1.Varsta} {p1.AreOchelari} ");
            Console.WriteLine($"{p2.Nume} {p2.Varsta} {p2.AreOchelari} ");
            Console.WriteLine($"{p3.Nume} {p3.Varsta} {p3.AreOchelari} ");

            Console.WriteLine(p3.Nume.ToUpper());
            Console.WriteLine(p3.Nume.ToLower());
            Console.WriteLine(p3.Nume.Substring(1)); //de unde sa inceapa
            Console.WriteLine(p3.Nume.Substring(1, 3));
            Console.WriteLine(p3.Nume.Split(' ')[0][1]);//separat sau cv literea 1 din cuvantul 0


            //lucram cu liste - tot o clasa

            List<Persoana> persoane = new List<Persoana> { p1, p2, p3 }; //tip de element

            //linq filtrezele listele cu interogari asemanatoare bazelor de date

            var persoaneCuOchelari = persoane
                .Where(p => p.AreOchelari && p.Varsta>20)
                .Select(p => p.Nume)
                .ToList(); //punere in lista    -->returneaza un list de String

            //var tip de data care poate sa fie orice tip de data <=> auto din c++



            //echivalente
            persoaneCuOchelari.ForEach(nume => Console.WriteLine(nume)); 
             
     
            foreach(string p in persoaneCuOchelari)
                Console.WriteLine(p); 




        }
    }
}
