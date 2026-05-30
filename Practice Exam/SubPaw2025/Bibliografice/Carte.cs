using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliografice
{
    public class Carte:Publicatie
    {
        private readonly string ISBN;
        private string categorie;
        private List<Autor> autori;

        public Carte(string ISBN,string categorie,string titlu, float pret) : base(titlu, pret)
        {
            this.ISBN = ISBN;
            this.categorie = categorie;
            this.autori = new List<Autor>();
        }

        public string Categorie { get => categorie; set => categorie = value; }
        public List<Autor> Autori { get => autori; set => autori = value; }

        public string ISBN1 => ISBN;

        public override string genereazaReferinte()
        {
            string rezultat = "";
            for(int i=0;i<autori.Count;i++)
            {
                rezultat += autori[i].Nume + ",";
            }

            rezultat += Titlu + "," + ISBN;
            return rezultat;
        }

    }
}
