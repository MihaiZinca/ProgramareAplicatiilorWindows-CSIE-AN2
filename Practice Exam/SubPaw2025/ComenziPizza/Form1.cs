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
using System.Xml;

namespace ComenziPizza
{
    public partial class Form1 : Form
    {
        List<ComandaPizza> comenziPizza = new List<ComandaPizza>();

        bool afisareGarfic = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormComanda fc = new FormComanda();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                comenziPizza = fc.LstComanda;
                AfisareComanda();
            }
        }

        public void AfisareComanda()
        {

            TreeNode parinte = new TreeNode("Comenzi");
            tvComanda.Nodes.Add(parinte);
            foreach (ComandaPizza c in comenziPizza)
            {
                TreeNode copil = new TreeNode(c.Blat);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode(c.Nume + "-" + c.DurataRealizare);
                nepot.Tag = c;
                copil.Nodes.Add(nepot);

            }
            tvComanda.ExpandAll();
        }

        private void citireTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Comenzi.txt");
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    string nume = linie.Split(',')[0];
                    string blat = linie.Split(',')[1];
                    int durata = int.Parse(linie.Split(',')[2]);

                    ComandaPizza c = new ComandaPizza(nume, blat, durata);
                    comenziPizza.Add(c);
                    MessageBox.Show("Comenzi adaugate cu succes!");

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
        }

        private void citireDinDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDB db = new FormDB();
            db.Show();
        }

        private void btnTopping_Click(object sender, EventArgs e)
        {
            if (tvComanda.SelectedNode == null || tvComanda.SelectedNode.Tag == null)
            {
                MessageBox.Show("Selectează o pizza!");
                return;
            }

            ComandaPizza pizza=(ComandaPizza)tvComanda.SelectedNode.Tag;

            FormDB db=new FormDB();
            db.ComandaSelectata = pizza;
            if(db.ShowDialog()== DialogResult.OK)
            {
                AfisareComanda();
                panelGrafic.Invalidate();
               
            }


        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {

            if (!afisareGarfic)
                return;

            if (tvComanda.SelectedNode == null || tvComanda.SelectedNode.Tag == null)
            {
                return;
            }

            ComandaPizza pizza = (ComandaPizza)tvComanda.SelectedNode.Tag;
            
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 20, panelGrafic.ClientRectangle.Y + 30,
                panelGrafic.ClientRectangle.Width - 40, panelGrafic.ClientRectangle.Height - 70);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int n = pizza.Topping.Count;
            double[] valori = new double[n];
            for (int i = 0;i<n;i++)
            {
                valori[i] = pizza.Topping[i].Pret*pizza.Topping[i].Cantitate;
            }

            double latime = (double)r.Width / (n * 1.5);
            double distanta = (r.Width - n * latime) / (n + 1);

            double max = valori.Max();
            if (max == 0) max = 1;


            Brush Br = Brushes.Blue;
            Font fontS = new Font("Arial", 8, FontStyle.Bold);

            Rectangle[] bars = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                double val = valori[i];
                bars[i] = new Rectangle(
                    (int)(r.X + (i + 1) * distanta + i * latime),
                    (int)(r.Y + r.Height - (val / max * r.Height)),
                    (int)latime,
                    (int)(val / max * r.Height)
                    );

                g.DrawString($"{val} ", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);
                g.DrawString($"Nume: {pizza.Topping[i].Denumire}", fontS, Brushes.Black, bars[i].X, r.Bottom + 10);
            }
            g.FillRectangles(Br, bars);
        }

        private void tvComanda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            afisareGarfic = false;
            panelGrafic.Invalidate();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            afisareGarfic = true;
            panelGrafic.Invalidate();
        }
    }
}
