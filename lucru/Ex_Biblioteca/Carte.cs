using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Biblioteca
{
    [Serializable]
    public class Carte
    {
        private int cod;
        private string titlu;
        private string autor;
        private double pret;

        public Carte(int cod, string titlu, string autor, double pret)
        {
            this.cod = cod;
            this.titlu = titlu;
            this.autor = autor;
            this.pret = pret;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Titlu { get => titlu; set => titlu = value; }
        public string Autor { get => autor; set => autor = value; }
        public double Pret { get => pret; set => pret = value; }

        public override string ToString()
        {
            return $"{Cod}, {titlu}, {autor}, {pret}";
        }
    }
}
