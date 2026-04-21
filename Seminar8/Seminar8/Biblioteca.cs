using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    internal class Biblioteca
    {
        private string nume;
        private List<Carte> listaCarti;

        public Biblioteca(string nune)
        {
            this.nume = nune;
            listaCarti = new List<Carte>();
        }

        public string Nume { get => nume; set => nume = value; }
        internal List<Carte> ListaCarti { get => listaCarti; set => listaCarti = value; }

        public void adaugaCarte(Carte c)
        {
            listaCarti.Add(c);
        }
    }
}
