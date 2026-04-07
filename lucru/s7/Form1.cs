using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s7
{
    public partial class Form1 : Form
    {
        List<TextBox> listaTB = new List<TextBox>();
        List<Produs> listaProduse=new List<Produs>();
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

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; //nu este blocat,permite introducerea

            }
            else e.Handled = true;
        }

        private void btnAdaugaLinie_Click(object sender, EventArgs e)
        {
            int X = listaTB[0].Location.X;
            int Y = listaTB[listaTB.Count - 1].Location.Y;
            int distantaTB = listaTB[1].Location.X - listaTB[0].Location.X;

            for(int i=0;i<4;i++)
            {
                TextBox tb=new TextBox();
                tb.Location = new Point(X, Y + 40);
                X += distantaTB;
                tb.Width = tbDenumire.Width;
                if (i == 1 || i == 2)
                    tb.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
                if (i == 3)
                    tb.ReadOnly = true;
                listaTB.Add(tb);
                this.Controls.Add(tb); //adaug in form1
            }
        }

        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lvProduse.Items.Clear();
            double valoareTotala = 0;

            for(int i=0;i<listaTB.Count;i+=4)
            {
                if (listaTB[i].Text == "")
                { errorProvider1.SetError(listaTB[i], "Introduceti denumire!"); }
                else if (listaTB[i + 1].Text == "")
                { errorProvider1.SetError(listaTB[i + 1], "Introduceti pretul!"); }
                else if (listaTB[i + 2].Text == "")
                { errorProvider1.SetError(listaTB[i + 2], "Introduceti cantitate!"); }
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

                    ListViewItem lvi = new ListViewItem(p.Denumire);
                    lvi.SubItems.Add(p.Pret.ToString());
                    lvi.SubItems.Add(p.Cantitate.ToString());
                    lvi.SubItems.Add(valoare.ToString());
                    lvProduse.Items.Add(lvi);

                }
                tbValoaretTotala.Text= valoareTotala.ToString();
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            StreamWriter sw = new StreamWriter($"Comanda_{data}.txt");
            double total = 0;
            foreach (ListViewItem item in lvProduse.Items)
            {
                string denumire = item.Text;
                string pret = item.SubItems[1].Text;
                string cantitate=item.SubItems[2].Text;
                string valoare=item.SubItems[3].Text;

                total += Convert.ToDouble(valoare);
                sw.WriteLine(denumire + "|" + cantitate + "|" + pret + "|" + valoare);
            }
            sw.WriteLine("Valoare totala comanda: " + total);
            sw.Close();
        }
    }
}
