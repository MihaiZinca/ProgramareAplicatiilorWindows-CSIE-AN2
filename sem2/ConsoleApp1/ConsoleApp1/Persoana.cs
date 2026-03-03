using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in c# putem tipul de acces pt fiecare atribut, default e private

namespace ConsoleApp1 {
    internal class Persoana:CalculeazaAnNastere {
      private string nume;
      private int varsta;
      bool _areOchelari; //_ gen private dar n are trb  -- default private


     //public int NumeAtribut { get; set; }  -fara a avea corp si se pot folosi in clasa


     public Persoana() 
      {
            nume = string.Empty;
            varsta = 0;
            _areOchelari = false;
      }

     public Persoana(string nume, int varsta, bool areOchelari) 
      {
            this.nume = nume;
            this.varsta = varsta;
            _areOchelari = areOchelari;
      }

     public string Nume {
           // get { return nume; }

            get {
                if (nume.Length > 0) {
                    return nume;
                }
                else { return string.Empty; }
            }

            set { nume = value; }  //proprietate doar daca are get sau set, grupeaza metodele de acces
        }

    public int Varsta {
            get => varsta; // <=> return varsta
            //set => varsta = value;
            set { if (value < 0) 
                    varsta = 0;
                else varsta = value;
            }
        }

    public bool AreOchelari {
            get => _areOchelari;
            set => _areOchelari=value;

            // set { _areOchelari=value; }
        }   //proprietati <=> get/set


     public override int AflaAnNastere() {
            return DateTime.Now.Year - varsta; //datetime struct din sistem, Now-proprietate a lui date time care returneaza un date time(data si ora de la computer), year-proprietate care returneaza un int
        }
        

    }
}
