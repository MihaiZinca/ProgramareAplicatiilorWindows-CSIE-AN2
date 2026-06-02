using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub4
{
    public partial class Form1 : Form
    {
        Statistica date = new Statistica();
        bool afisareGrafic = false;
        public Form1()
        {
            InitializeComponent();
            date.Modifi += AfisareLV;
        }

        public void AfisareLV()
        {
            lv.Items.Clear();
            for(int i=0;i<date.Observatii.Count;i++)
            {
                ListViewItem itm = new ListViewItem((i + 1).ToString());
                itm.SubItems.Add(date.Observatii[i].ToString());
                itm.SubItems.Add(date.Frecvente[i].ToString());
                itm.Tag = i;
                lv.Items.Add(itm);
            }
            tbMedie.Text = date.CalcularMedie().ToString();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if(double.TryParse(tbObsv.Text,out double val))
            {
                date.Adaugare(val);
                tbObsv.Clear();
                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("Valoare invalida");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(lv.SelectedItems.Count==0)
            {
                MessageBox.Show("Alegeti o observatie");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            if (double.TryParse(tbObsv.Text, out double val))
            {
                date.Modificare(index, val);
                tbObsv.Clear();
                
                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("Valoare invalida");
            }

        }

        private void btnStergereSimpla_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti o observatie");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            date.stergerSimpla(index);
            
            panel1.Invalidate();
        }

        private void btnStergereCompleta_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti o observatie");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            date.StergereCompleta(index);
            
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (afisareGrafic)
            {
                if (date.Observatii.Count < 2)
                    return;

                Graphics g = e.Graphics;
                Rectangle r = new Rectangle(panel1.ClientRectangle.X + 20, panel1.ClientRectangle.Y + 30, panel1.ClientRectangle.Width - 40, panel1.ClientRectangle.Height - 70);

                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, r);

                int n = date.Observatii.Count;
                double latime = (double)r.Width / (n * 1.5);
                double distanta = (r.Width - n * latime) / (n + 1);

                double max = date.Observatii.Max();

                Brush br = Brushes.Blue;
                Font fontS = new Font("Arial", 12, FontStyle.Bold);

                Rectangle[] bars = new Rectangle[n];
                for (int i = 0; i < n; i++)
                {
                    double val = date.Observatii[i];
                    bars[i] = new Rectangle(
                        (int)(r.X + (i + 1) * distanta + i * latime),
                        (int)(r.Y + r.Height - (val / max * r.Height)),
                        (int)latime,
                        (int)(val / max * r.Height)
                        );

                    g.DrawString($"{val}", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);
                    g.DrawString($"Frecv:{date.Frecvente[i]}", fontS, Brushes.Black, bars[i].X, r.Bottom + 5);
                }
                g.FillRectangles(br, bars);

            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            afisareGrafic = true;
            panel1.Invalidate();
        }
    }
}
