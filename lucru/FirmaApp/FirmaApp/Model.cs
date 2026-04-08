using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaApp
{

    public class Firma_EvArgs : EventArgs
    {
        int indexMat;
        public Firma_EvArgs(int indexMat)
        {
            this.indexMat = indexMat;
        }
        public int Index_Salariat => indexMat;
    }

    public class Salariat
    {
        public int Marca {  get; set; }
        public string Nume {  get; set; }
        public int Nr_ore {  get; set; }
        public int Sal_ora {  get; set; }

        public int Salariul => Nr_ore * Sal_ora;

    }

    public class Firma
    {
        public event EventHandler<Firma_EvArgs> Ev_Modificare_Firma;
        string numeFirma;
        List<Salariat> listaSal = null;

        public Firma(string _numeFirma="Firma.SRL")
        {
            numeFirma = _numeFirma; 
            listaSal=new List<Salariat>();
        }
        public List<Salariat> Salariati => listaSal;
        public int Numar_Salariati => listaSal.Count;
        public string Nume_Firma => numeFirma;

        public int Fond_Sal => listaSal.Sum(s => s.Salariul);

        public void Adauga_Salariat(Salariat obs)
        {
            listaSal.Add(obs);
            Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(listaSal.Count - 1)); 

        }

        public Salariat this[int k]
        {
            get => listaSal[k];
            set
            {
                if (listaSal[k]!=value)
                {
                    listaSal[k] = value;
                    Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(k));

                }
            }
        }
    }
}
