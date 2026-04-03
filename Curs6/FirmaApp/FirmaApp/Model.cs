using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net.Http.Headers;
using System.IO; //pt serializare 

namespace FirmaApp
{

    public class Firma_EvArgs : EventArgs
    {

        int indexMat;
        public Firma_EvArgs(int _indexMat)
        {
            indexMat = _indexMat;
        }
        public int Index_Salariat => indexMat;
    }

    [DataContract]
    //vom defini doar proprietatile
    public class Salariat
    {
        [DataMember]public int Marca {  get; set; }  //ascundem atributele, nu lucram direct cu ele, ci cu proprietatea
        [DataMember] public string Nume { get; set; }
        [DataMember] public int Nr_ore  { get; set; }

        [DataMember] public int Sal_ora { get; set; }

        public int Salariul => Nr_ore * Sal_ora; // => proprietate de tip read only
    }

    [DataContract]
    public class Firma
    {
        //facem class Firma_EvArgs
        public event EventHandler<Firma_EvArgs> Ev_Modificare_Firma; //ori de cate ori cineva imi modifica oviectul Firma
        [DataMember] string numeFirma;
        [DataMember] List<Salariat> ls = null;

        public Firma(string _numeFirma="Firma.SRL")
        {
            numeFirma = _numeFirma;
            ls = new List<Salariat>();
        }

        public List<Salariat> Salariati => ls; //returnam lista 
        public int  Numar_Salariati => ls.Count;

        public string Nume_Firma => numeFirma;

        public int Fond_Sal => ls.Sum(s => s.Salariul);
        
        public void Adauga_Salariat(Salariat obs)
        {
            //pt principiu cu cheie unica - sa nu fie cheie prima dublicata, si sa nu fie nulla -to do!
            //Salariat aux=ls.Find(s => s.Marca == obs.Marca);
            //if (aux != null) throw new Exception("Marca Dublicata!!!!");

            ls.Add(obs);
            Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(ls.Count - 1)); //?.- daca nu e null this=sender ,
        }

        public Salariat this[int k]
        {
            get => ls[k];
            set
            {
                if (ls[k]!=value)
                {
                    ls[k] = value;
                    Ev_Modificare_Firma?.Invoke(this, new Firma_EvArgs(k));
                }
            }
        }

        //2 variante - pt gestioanre
        //1-principiu baze de date, de a gestiona marca ca fiind o cheie unica, si gestionare dupa marca, 
        //2-de a opera cu salariatul din firma pe baza indexului pe care il procesez la un mom dat(!asta facem)

        //tipul delegatului din windows forms - sender si
        //EventArgs-tine informatie care se impacheteaza odt cu ridicarea evenimentului pt a avea informatii mai detaliate

        //serializare -salvarea datelor intr un fisier
        //deserializarea -restaurarea datelor intr un fisier
        //in prima etapa trebuie sa definesc starea obiectului!! 

        public void Serializeaza(string numeFisier)
        {
            FileStream fs = new FileStream(numeFisier, FileMode.Create); //creez fisierul
            DataContractSerializer obs = new DataContractSerializer(typeof(Firma));
            obs.WriteObject(fs, this); //this este vorba de obiectul firma
        }

        public void Deserializeaza(string numeFisier)
        {
            FileStream fs = new FileStream(numeFisier, FileMode.Open);
            DataContractSerializer obs = new DataContractSerializer(typeof(Firma));
            Firma aux=obs.ReadObject(fs) as Firma; // as Firma tot cast

            numeFirma = aux.numeFirma;
            ls.Clear(); //elimin toti sal din firma
                        //si ii iau pe aia din aux si pun la aceasta firma
            foreach (Salariat s in aux.Salariati)
                Adauga_Salariat(s);

            fs.Close();
        }

    }

}

