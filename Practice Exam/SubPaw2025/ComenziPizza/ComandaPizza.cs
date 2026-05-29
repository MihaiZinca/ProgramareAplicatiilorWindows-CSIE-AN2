using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComenziPizza
{
    public class ComandaPizza:ICustomizabil,ICloneable
    {
        private string nume;
        private string blat;
        private int durataRealizare;
        private List<Topping> topping;
        private static readonly float pretDefaultPizza = 10;

        public ComandaPizza(string nume, string blat, int durataRealizare)
        {
            this.nume = nume;
            this.blat = blat;
            this.durataRealizare = durataRealizare;
            this.topping = new List<Topping>();
        }

        public string Nume { get => nume; }
       
        public int DurataRealizare { get => durataRealizare;}
        public string Blat { get => blat; set => blat = value; }
        public List<Topping> Topping { get => topping; set => topping = value; }

        public Topping this[int index]
        {
            get
            {
                if (index >= 0 && index < topping.Count)
                    return topping[index];
                return null;
            }
        }

        public object Clone()
        {
            ComandaPizza c=new ComandaPizza(nume,blat,durataRealizare);
            foreach(Topping t in topping)
                c.topping.Add(t);
            return c;
        }

        public float CalculCostPizza()
        {
            float cost = 0;
            foreach (Topping t in topping)
                cost += t.Pret * t.Cantitate;
            return cost + pretDefaultPizza;
        }

        public static bool operator>(ComandaPizza c1,ComandaPizza c2)
        {
            return c1.CalculCostPizza()>c2.CalculCostPizza();
        }

        public static bool operator<(ComandaPizza c1,ComandaPizza c2)
        {
            return c1.CalculCostPizza() < c2.CalculCostPizza();
        }

        public static ComandaPizza operator+(ComandaPizza comanda,Topping t)
        {
            comanda.topping.Add(t);
            return comanda; 
        }

        public override string ToString()
        {
            string rezultat = nume + "|" + blat + "|" + durataRealizare + "|";
            foreach (Topping t in topping)
                rezultat += string.Join(", ", topping);
            return rezultat;
        }

    }
}
