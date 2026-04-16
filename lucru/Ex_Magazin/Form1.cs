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

namespace Ex_Magazin
{
    public partial class tbTotal : Form
    {
        public List<Comanda> listaComanda=new List<Comanda>();
        public List<Produs>listaProduse=new List<Produs>();
        public tbTotal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbDenumirePr.Text))
                    throw new Exception("Introduceti denumire");
                string den = tbDenumirePr.Text;

                if (String.IsNullOrWhiteSpace(tbPret.Text))
                    throw new Exception("Introduceti pret");
                double pret = Convert.ToDouble(tbPret.Text);

                if (String.IsNullOrWhiteSpace(tbCantitate.Text))
                    throw new Exception("Introcueti cantitate");
                int cant = Convert.ToInt32(tbCantitate.Text);
                string nC = tbNumeC.Text;
                int vC = Convert.ToInt32(tbVarstaCl.Text);

                Produs p = new Produs(den, pret, cant);
                Client c = new Client(nC, vC);
                Comanda com = new Comanda(c,DateTime.Parse(dataTK.Text));
                com += p;
                listaComanda.Add(com);

           
                Comanda ultimaC = listaComanda.Last();
                foreach (Produs p1 in ultimaC.GetProduse())
                {
                    ListViewItem lvi = new ListViewItem(p1.Denumire);
                    lvi.SubItems.Add(p1.Pret.ToString());
                    lvi.SubItems.Add(p1.Cantitate.ToString());
                    lvProduse.Items.Add(lvi);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbDenumirePr.Clear();
                tbPret.Clear();
                tbCantitate.Clear();
                tbNumeC.Clear();
                tbVarstaCl.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double totalGeneral = 0;
            foreach (Comanda c in listaComanda)
            {
                totalGeneral += c.CalculeazaTotal();
            }
            tbTotall.Text= totalGeneral.ToString();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK )
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach(Comanda c in listaComanda) 
                    sw.WriteLine(c.ToString());
                sw.Close();
            }
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK )
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName);

                string linie;

                while((linie=sr.ReadLine()) != null )
                {
                    try
                    {
                        string denumire = linie.Split('|')[0];
                        int pret = Convert.ToInt32(linie.Split('|')[1]);
                        int cantitate = Convert.ToInt32(linie.Split('|')[2]);
                        int valoare = Convert.ToInt32(linie.Split('|')[3]);

                        Produs p = new Produs(denumire, pret, cantitate);
                        listaProduse.Add(p);
                        
                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                sr.Close();
            }
        }
    }
}
