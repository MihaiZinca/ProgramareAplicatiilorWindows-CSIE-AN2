using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traseu
{
    public partial class Form1 : Form
    {
        Traseu traseu = new Traseu();
        public Form1()
        {
            InitializeComponent();
            traseu.ModificareTraseu += StatusL;
        }

        private void StatusL()
        {
            AfisareInLV();
            toolStripStatusLabel1.Text = "Lungime curenta: " + traseu.LungimeTraseu;
            panel1.Invalidate();
            
        }

        private void AfisareInLV()
        {
            lvTraseu.Items.Clear();
            foreach (Locatie l in traseu.Locatii)
            {
                ListViewItem itm = new ListViewItem(l.X.ToString());
                itm.SubItems.Add(l.Y.ToString());
                itm.Tag = l;
                lvTraseu.Items.Add(itm);
            }
        }


        private void adaugareLocatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocatie fm = new FormLocatie();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                traseu.AdaugaLocatie(fm.LocCurenta);

            }
        }

        private void salvareBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("traseu.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, traseu);
            fs.Close();
            MessageBox.Show("Salvare bin realizata cu succes!");
        }

        private void restaurareBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("traseu.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            traseu = (Traseu)bf.Deserialize(fs);
            fs.Close();

            traseu.ModificareTraseu += StatusL;
            StatusL();
            MessageBox.Show("Deserializare bin realizata cu succes!");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (traseu.Locatii.Count == 0)
                return;

            Graphics g = e.Graphics;

            int dim = 10;

            for(int i=0;i<traseu.Locatii.Count;i++)
            {
                int x=traseu.Locatii[i].X;
                int y=traseu.Locatii[i].Y;

                Rectangle r = new Rectangle(x - dim / 2, y - dim / 2, dim, dim);
                g.FillRectangle(Brushes.Red, r);

                if(i>0)
                {
                    g.DrawLine(Pens.Black, traseu.Locatii[i - 1].X, traseu.Locatii[i-1].Y,x,y);
                }
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
