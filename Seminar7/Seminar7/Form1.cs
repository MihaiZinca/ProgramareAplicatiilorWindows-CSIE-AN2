using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar7
{
    public partial class Form1 : Form
    {
        List<TextBox> listaTB = new List<TextBox>();
        List<Produs> listaProduse = new List<Produs>();
        public Form1()
        {
            InitializeComponent();
            listaTB.Add(tbDenumire);
            listaTB.Add(tbPret);
            listaTB.Add(tbCantitate);
            listaTB.Add(tbValoare);
            tbCantitate.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
            tbPret.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
        }

        //KeyPressEventArgs e:cotine datele evenimentului
        //Clasa KeyPressEvent Args ofera informatii despre tasta apasata
        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.keyChar:Reprezinta caracterul tastei apasate
            //propr keyChar din keyPressEventArgs este utilizata pt a det ce tasta a fost apasata
            

            //verifica daca dasta apasata este un nr intreg intre 0 si 9 sau tasta backspace(caracterul cu codul ASCII 8) sau cu.Enter
            if(e.KeyChar>='0' && e.KeyChar<='9' || e.KeyChar==(char)Keys.Enter)
            {
                //daca conditia este adv,
                //ev de apasare a tastei nu este bloct de manipulatorul de evenimente,
                //permitand astfel caracterul sa fie introdus In TextBox
                e.Handled = false; 
            }
            else
            {
                //previne introducerea caracterului in textBox prin trat evenimentului
                //cand e pe true - eveniment procesat si nu mai propaga actiunea
                e.Handled = true;
            }
        }

        private void btnAdaugaLinie_Click(object sender, EventArgs e)
        {
            //obtine coordonata X a primului textBox din lista existenta
            int X = listaTB[0].Location.X;

            //obtine coordonata Y a ultimului TextBox din lista, pt a plasa noul TextBox dedesubtul acestuia
            int Y = listaTB[listaTB.Count - 1].Location.Y;

            //calc distata pe orizontala intre primul si al doilea textBox din lista
            //pt a metine aceeasi distanta intre noile TextBox uri
            int distantaTB = listaTB[1].Location.X - listaTB[0].Location.X;

            //for care va adauga 4 noi TexBox
            for(int i=0;i<4;i++)
            {
                TextBox tb = new TextBox(); //creaza un nou control textbox
                tb.Location = new Point(X, Y + 40);// seteaza locatia noului tb, 40 pixeli dedesubtul utlimul tb din lista
                X += distantaTB; //actualizeaza coordonata X pt urmatorul TextBox, bazat pe distanta calculata mai sus
                tb.Width = tbDenumire.Width; //setaza latimea noului tb = cu tb specificat 

                if(i==1 ||i==2)
                {
                    tb.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
                    //adauga manipulatorul de evenimente pt a restrictiona inputulu pt al doilea si al treilea tb adaugat
                }
                if (i==3)
                {
                    tb.ReadOnly = true;//seteaza al patrulea tb adaugat ca fiind doar pt citire
                 
                }

                listaTB.Add(tb); //adauga noul tb in lista de textboxuri gesionate
                this.Controls.Add(tb); //adauga noul tb la colectia de controale a formularului, pt a fi afisat pe ecran
    
            }
        }

        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //curata orice erori prezentate anterior 
            lvProduse.Items.Clear(); //elimina toate elementele din Lv, pregatindu l pt o noua lista de produse
            double valoareTotala = 0; //init suma totala a valorilor produs

            //parcurge lista de tb in pasi de 4, presup ca fiecare grup de 4 tb reprez un produs
            for(int i=0;i<listaTB.Count;i+=4)
            {
                if (listaTB[i].Text == "")
                    errorProvider1.SetError(listaTB[i], "Introduceti denumire!");
                else if (listaTB[i + 1].Text == "")
                    errorProvider1.SetError(listaTB[i + 1], "Introduceti pretul!");
                else if (listaTB[i + 2].Text =="")
                    errorProvider1.SetError(listaTB[i + 2], "Introduceti cantitatea!");
                else
                {
                    string denumire = listaTB[i].Text;
                    double pret = Convert.ToDouble(listaTB[i + 1].Text);
                    int cantitate = Convert.ToInt32(listaTB[i + 2].Text);

                    Produs p = new Produs(denumire, pret, cantitate);
                    listaProduse.Add(p);

                    double valoare = pret * cantitate;
                    valoareTotala += valoare;
                    listaTB[i + 3].Text = valoare.ToString();

                    //creeaza un nou element ListView cu det produsului si il adauga in lv
                    ListViewItem lvi = new ListViewItem(p.Denumire);
                    lvi.SubItems.Add(p.Pret.ToString());
                    lvi.SubItems.Add(p.Cantitate.ToString());
                    lvi.SubItems.Add(valoare.ToString());
                    lvProduse.Items.Add(lvi);
                }

                //actualizeaza textbox ul destinat afisarii val totale cu suma calculata
                tbValoareTotala.Text = valoareTotala.ToString();
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {


            string data = dateTimePicker1.Value.ToString("dd-MMMM-yyyy");
            //MessageBox.Show(data);
           
            //TO DO
            //SALVARE FISIER TEXT CU DENUMIRE Comanda_[data].txt
            //Denumire | Cantitate | Pret | Valoare
            //...
            //Valoarea totala comanda: valoare totala
        }

     
    }
}
