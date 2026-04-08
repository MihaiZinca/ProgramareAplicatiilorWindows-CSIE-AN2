using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    [Serializable]
    public class Autor
    {
        private string nume;
        private string gradDidactic;
        private readonly int marca;

        public Autor(string nume,string gradDidactic,int marca)
        {
            this.nume = nume;
            this.gradDidactic = gradDidactic;
            this.marca = marca;
        }

        public string Nume { get => nume; set => nume = value; }
        public string GradDidactic {  get => gradDidactic; set => gradDidactic = value;}

        public int Marca => marca;
        public override string ToString()
        {
            return $"{nume} ({gradDidactic}) {marca}";
        }
    }
}
