using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    [Serializable]
    public class Carte:Publicatie
    {
        private readonly string isbn; //echiv cu const 
        private string categorie;
        private List<Autor> autori;

      
        public Carte(string titlu,double pret,string isbn,string categorie):base(titlu,pret)
        {
           this.isbn= isbn; 
           this.categorie = categorie;
           autori=new List<Autor>();
        }
        
        public string ISBN { get => isbn; }
        public string Categorie { get => categorie; set => categorie = value; }

        public override string genereazaReferinta()
        {
            string listaAutori = string.Join(",", autori.Select(a => a.Nume));
            return $"{listaAutori} - {titlu},{isbn}";
        }
        public List<Autor>Autori { get=>autori; set=>autori = value; }


        public static Carte operator+(Carte c, Autor a)
        {
            c.Autori.Add(a);
            return c;
        }

        public override string ToString()
        {
            return $"{genereazaReferinta()}";
        }
    }
}
