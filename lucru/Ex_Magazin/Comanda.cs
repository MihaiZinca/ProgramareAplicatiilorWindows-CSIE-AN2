using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Magazin
{
    public class Comanda:ICalcul
    {
        private Client client;
        private List<Produs> produse;
        private DateTime dataComanda;

        public Comanda() {
            produse=new List<Produs>();
        }
        public Comanda(Client client, List<Produs> listaProduse, DateTime dataComanda)
        {
            this.client = client;
            this.produse = new List<Produs>(listaProduse);
            this.dataComanda = dataComanda;
        }

        public Comanda(Client c, Produs p, DateTime dateTime)
        {
        }

        public Comanda(Client c, DateTime dateTime)
        {
        }

        public Client Client { get=>client; set=>client=value; }
        public DateTime Data { get=>dataComanda; set=>dataComanda=value; }
        
        public List<Produs> GetProduse()
        {
            return produse;
        }

        public double CalculeazaTotal()
        {
            double total = 0;
            foreach (Produs p in produse)
                total += p.Pret * p.Cantitate;
            return total;
        }
        public Produs ProdusMax()
        {
            Produs max = produse[0];
            foreach (Produs p in produse)
                if (p > max) max = p;
            return max;
        }

        public Produs this[int index]
        {
            get => produse[index];
            set=> produse[index]=value;
        }

        private double[,] preturiZile;
        public double this[int i,int j]
        {
            get => preturiZile[i, j];
            set => preturiZile[i, j] = value;
        }

        public static Comanda operator+(Comanda c, Produs p)
        {
            c.produse.Add(p);
            return c;
        }
        public static Comanda operator-(Comanda c, Produs p)
        {
            c.produse.Remove(p);
            return c;
        }
    }
}
