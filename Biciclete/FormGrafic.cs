using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciclete
{
    public partial class FormGrafic : Form
    {
        List<Bicicleta> biciclete;
        public FormGrafic(List<Bicicleta> lst)
        {
            InitializeComponent();
            this.biciclete = lst;
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            if (biciclete.Count == 0 || biciclete == null) return;

            Graphics g=e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 20, panelGrafic.ClientRectangle.Y + 30,
                panelGrafic.ClientRectangle.Width - 40, panelGrafic.ClientRectangle.Height - 70);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int n = biciclete.Count;

            double latime = (double)r.Width / (n * 1.5);
            double distanta = (r.Width - n * latime) / (n + 1);

            double max = biciclete.Max(b => b.KmParcursi);
            if (max == 0) max = 1;

            Brush Br = Brushes.Blue;
            Font fontS = new Font("Arial", 8, FontStyle.Bold);

            Rectangle[] bars = new Rectangle[n];
            for(int i=0; i<n;i++)
            {
                double val = biciclete[i].KmParcursi;
                bars[i] = new Rectangle(
                    (int)(r.X + (i + 1) * distanta + i * latime),
                    (int)(r.Y+r.Height-(val/max *r.Height)),
                    (int)latime,
                    (int)(val/max*r.Height)
                    );

                g.DrawString($"{val} km", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);

                g.DrawString($"Cod: {biciclete[i].CodB}", fontS, Brushes.Black, bars[i].X, r.Bottom + 5);
            }
            g.FillRectangles(Br, bars);
            

        }
    }
}
