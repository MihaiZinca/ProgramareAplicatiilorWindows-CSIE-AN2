using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliografice
{
    public class Autor
    {
        private string nume;
        private string grad_didactic;
        private readonly int marca;

        
        public Autor(string nume, string grad_didactic, int marca)
        {
            this.nume = nume;
            this.grad_didactic = grad_didactic;
            this.marca = marca;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Grad_didactic { get => grad_didactic; set => grad_didactic = value; }
        public int Marca => marca;

        public override string ToString()
        {
            return $"{nume}|{grad_didactic}";
        }
    }
}
