using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosCumparaturi
{
    public partial class Form1 : Form
    {
        Cumparaturi listaCumparaturi = new Cumparaturi();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormProdus fp=new FormProdus();
            if(fp.ShowDialog() == DialogResult.OK )
            {
                foreach (Produs p in fp.ListaProduse)
                    listaCumparaturi += p;
                
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            lvCos.Items.Clear();

            foreach(Produs p in listaCumparaturi.Produse)
            {
                ListViewItem itm = new ListViewItem(p.Id.ToString());
                itm.SubItems.Add(p.DenumireP);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.Cantitate.ToString());
                itm.SubItems.Add(p.Valoare.ToString());
                itm.Tag = p;

                lvCos.Items.Add(itm);
            }
        }

        private void stergereProdusCosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvCos.SelectedItems.Count==0)
            {
                MessageBox.Show("Selectati Produs din cos");
                return;
            }
            
            Produs p=(Produs)lvCos.SelectedItems[0].Tag;
            listaCumparaturi.Produse.Remove(p);
            btnAfisare_Click(sender, e);

        }

        private void modificareProdusCosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati Produs din cos");
                return;
            }
            Produs p = (Produs)lvCos.SelectedItems[0].Tag;
            FormEditare fp = new FormEditare(p);
            if(fp.ShowDialog() == DialogResult.OK)
            {
                btnAfisare_Click(sender, e);
            }

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }

        private void pp(object sender,PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            float y = 20;

            e.Graphics.DrawString("COS CUMPARATURI", fontTitlu, Brushes.Black, 20, y);
            y += 25;
            double total = 0;
            foreach(Produs p in listaCumparaturi.Produse)
            {
                e.Graphics.DrawString($"{p.Id}-{p.DenumireP}-{p.Pret}-{p.Cantitate}", fontText, Brushes.Black, 40, y);
                y += 25;

                total += p.Valoare;
 
            }

            e.Graphics.DrawString($"Valoare totala:{total}", fontText, Brushes.Black, 40, y);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach (Produs p in listaCumparaturi.Produse)
                    sw.WriteLine(p.ToString());
                sw.Close();
                MessageBox.Show("Save.txt succes!");
            }
        }
    }
}
