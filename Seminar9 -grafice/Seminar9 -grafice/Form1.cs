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

namespace Seminar9__grafice {

    public partial class Form1 : Form 
    {
        List<Vanzare> listaVanzari = new List<Vanzare>();
        bool dateIncarcate = false;

        const int margine = 10;
        Color culoareBars = Color.Blue;
        Font fontText=new Font(FontFamily.GenericSansSerif,12,FontStyle.Bold);
        Color culoareText = Color.Black;
        public Form1() {
            InitializeComponent();
        }

        private void incarcareDateToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            StreamReader sr = new StreamReader("Date.txt");
            string linie = null;
            listaVanzari.Clear();
            while ((linie = sr.ReadLine()) != null) {
                try {
                    string luna = linie.Split(',')[0];
                    int valoare = Convert.ToInt32(linie.Split(',')[1]);
                    Vanzare v = new Vanzare(luna, valoare);
                    listaVanzari.Add(v);
                    dateIncarcate = true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }

            }
            sr.Close();
            MessageBox.Show("S-au incasat datele!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

            chart1.Visible = false;
            if(dateIncarcate) 
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 4 * margine,
                    panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 5 * margine);
                Pen pen=new Pen(Color.Red,3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaVanzari.Count / 3;
                double distanta = (rectangle.Width - listaVanzari.Count * latime) / (listaVanzari.Count + 1);
                double vMax = listaVanzari.Max(max => max.Valoare);

                Brush brBars = new SolidBrush(culoareBars);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaVanzari.Count];
                for(int i=0;i<rectangles.Length;i++) 
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaVanzari[i].Valoare / vMax * rectangle.Height),
                        (int)latime,
                        (int)(listaVanzari[i].Valoare / vMax * rectangle.Height));

                    g.DrawString(listaVanzari[i].Luna,fontText,brFont,new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y-fontText.Height)));
                    
                }

                g.FillRectangles(brBars, rectangles);
                
                for(int i=0;i< listaVanzari.Count-1;i++) {
                    g.DrawLine(pen,new Point((int)(rectangles[i].Location.X +latime/2), (int)(rectangles[i].Location.Y)),
                       new Point((int)(rectangles[i+1].Location.X + latime / 2), (int)(rectangles[i+1].Location.Y)));
                }

            }
        }

        private void graficDesenatBarsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dateIncarcate) {
                chart1.Visible = false;
                panel1.Invalidate();
            }
            else {
                MessageBox.Show("Datele nu au fost incarcate");
            }
                
        }

        private void graficBarsToolStripMenuItem_Click(object sender, EventArgs e) {
            panel1.SendToBack();
            if (dateIncarcate==true) {

                chart1.Series["Vanzari"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                for(int i=0;i<listaVanzari.Count;i++) {
                    chart1.Series["Vanzari"].Points.AddXY(listaVanzari[i].Luna, listaVanzari[i].Valoare);
                }
                chart1.Titles.Add("Vanzari magazin");
            }
            else {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void graficPieToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dateIncarcate == true) {

                chart1.Series["Vanzari"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                for (int i = 0; i < listaVanzari.Count; i++) {
                    chart1.Series["Vanzari"].Points.AddXY(listaVanzari[i].Luna, listaVanzari[i].Valoare);
                }
                chart1.Titles.Add("Vanzari magazin");
            }
            else {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void salvare_bmp(Control c,string nume_fisier) {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(nume_fisier);
            img.Dispose();
        }
        private void salvareBmpToolStripMenuItem_Click(object sender, EventArgs e) {
            salvare_bmp(panel1, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
            MessageBox.Show("S-a salvat imaginea!");
        }



        private void pp(object sender,PrintPageEventArgs e) {

            chart1.Visible = false;
            if (dateIncarcate) {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 4 * margine,
                   e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 5 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaVanzari.Count / 3;
                double distanta = (rectangle.Width - listaVanzari.Count * latime) / (listaVanzari.Count + 1);
                double vMax = listaVanzari.Max(max => max.Valoare);

                Brush brBars = new SolidBrush(culoareBars);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaVanzari.Count];
                for (int i = 0; i < rectangles.Length; i++) {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaVanzari[i].Valoare / vMax * rectangle.Height),
                        (int)latime,
                        (int)(listaVanzari[i].Valoare / vMax * fontText.Height));

                    g.DrawString(listaVanzari[i].Luna, fontText, brFont, new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y - fontText.Height)));

                }

                g.FillRectangles(brBars, rectangles);

                for (int i = 0; i < listaVanzari.Count - 1; i++) {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2), (int)(rectangles[i].Location.Y)),
                       new Point((int)(rectangles[i].Location.X + latime / 2), (int)(rectangles[i + 1].Location.Y)));
                }

            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e) {
            PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog {
                Document = pd
            };
            pdlg.ShowDialog();
        }

        private void barsToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog cd=new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK) {
                culoareBars = cd.Color;
            }
            panel1.Invalidate();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                culoareText = cd.Color;
            }
            panel1.Invalidate();
        }

        private void modificareFontToolStripMenuItem_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK) {
                fontText = fd.Font;
            }
            panel1.Invalidate();
        }
    }
}
