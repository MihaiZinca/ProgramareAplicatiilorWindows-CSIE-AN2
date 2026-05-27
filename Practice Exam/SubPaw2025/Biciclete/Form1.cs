using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Biciclete
{
    public partial class Form1 : Form
    {
        List<Bicicleta> lstBiciclete=new List<Bicicleta>();
        List<Utilizator> lstUtilizatori=new List<Utilizator>();
        public Form1()
        {
            InitializeComponent();
            incarcareBiciclete();
            incarcareUtilizatori();
            PopulareLV();
            lvBiciclete.ContextMenuStrip = contextMenuStrip1;

        }
        public void incarcareBiciclete()
        {
            StreamReader sr = new StreamReader("Biciclete.txt");
            string linie;
            while((linie=sr.ReadLine()) != null)
            {
                try
                {
                    int codB = int.Parse(linie.Split(',')[0]);
                    string denumireStatie=linie.Split(',')[1];
                    int kmP = int.Parse(linie.Split(',')[2]);

                    Bicicleta b = new Bicicleta(codB, denumireStatie, kmP);
                    lstBiciclete.Add(b);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Bicicletele au fost incarcate!");

        }

        public void PopulareLV()
        {
            lvBiciclete.Items.Clear();
            foreach (Bicicleta b in lstBiciclete)
            {
                ListViewItem itm = new ListViewItem(b.CodB.ToString());
                itm.SubItems.Add(b.DenumireStatieParcare);
                itm.SubItems.Add(b.KmParcursi.ToString());
                itm.Tag = b;
                lvBiciclete.Items.Add(itm);
            }
        }
        public void incarcareUtilizatori()
        {
            StreamReader sr = new StreamReader("Utilizatori.txt");
            string linie;
            while( (linie=sr.ReadLine()) != null)
            {
                try
                {
                    int codU = int.Parse(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    int codB = int.Parse(linie.Split(',')[2]);
                    int durata = int.Parse(linie.Split(',')[3]);

                    Utilizator u=new Utilizator(codU,nume,codB,durata);
                    lstUtilizatori.Add(u);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Utilizatori au fost incarcati!");
        }

        private void lvBiciclete_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUtilizatori.Items.Clear();
            if(lvBiciclete.SelectedItems.Count>0)
            {
                Bicicleta b = (Bicicleta)lvBiciclete.SelectedItems[0].Tag;
                foreach(Utilizator u in lstUtilizatori)
                {
                    if (b.CodB == u.CodB)
                        lbUtilizatori.Items.Add(u);
                }
            }
        }

        private void lbUtilizatori_DoubleClick(object sender, EventArgs e)
        {
            if(lbUtilizatori.SelectedItem!=null)
            {
                Utilizator u=(Utilizator)lbUtilizatori.SelectedItem;
                FormEditare fe = new FormEditare(u);
                fe.ShowDialog();
                lbUtilizatori.Refresh();
            }

        }

        double CalculIncasari(int codB)
        {
            double total = 0;
            foreach(Utilizator u in lstUtilizatori)
            {
                if(u.CodB==codB && u.DurataUtilizare>30)
                {
                    int extra = u.DurataUtilizare - 30;

                    int unitati = (int)Math.Ceiling(extra / 10.0);

                    total += unitati*2;
                }
            }
            return total;
            
        }

        private void sumaTotalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvBiciclete.SelectedItems.Count>0)
            {
                Bicicleta b = (Bicicleta)lvBiciclete.SelectedItems[0].Tag;
                double total = CalculIncasari(b.CodB);
                tbTotal.Text= total.ToString();
            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fg=new FormGrafic(lstBiciclete);
            fg.Show();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = pd
            };
            pdlg.ShowDialog();
            

        }

        private void pp(Object sender, PrintPageEventArgs e)
        {
            Font fontTitlu=new Font("Arial",12,FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            float y = 20;

            foreach(Bicicleta b in lstBiciclete)
            {
                e.Graphics.DrawString($"Bicicleta:{b.CodB}", fontTitlu, Brushes.Black, 20, y);
                y += 25;

                foreach(Utilizator u in lstUtilizatori)
                {
                    e.Graphics.DrawString($"-{u.Nume} ({u.DurataUtilizare} min)", fontText, Brushes.Black, 40, y);
                    y += 25;
                }
                y += 10;
            }
        }

        private void serializareBicicleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("biciclete.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter  bf=new BinaryFormatter();
            bf.Serialize(fs, lstBiciclete);
            fs.Close();
            MessageBox.Show("Serializare biciclete.dat realizata cu succes!");
        }

        private void serializareUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("utilizatori.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, lstUtilizatori);
            fs.Close();
            MessageBox.Show("Serializare utilizatori.dat realizata  cu succes!");
        }
    }
}
