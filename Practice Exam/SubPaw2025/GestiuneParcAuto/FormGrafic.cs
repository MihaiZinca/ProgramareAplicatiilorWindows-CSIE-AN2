using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneParcAuto
{
    public partial class FormGrafic : Form
    {
        List<Autocamion> lista;
        public FormGrafic(List<Autocamion> listaAuto)
        {
            InitializeComponent();
            this.lista= listaAuto;
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            if (lista == null || lista.Count == 0)
                return;

            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 20, panelGrafic.ClientRectangle.Y + 30,
                panelGrafic.ClientRectangle.Width - 40, panelGrafic.ClientRectangle.Height - 70);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int n = lista.Count;
            double latime = (double)r.Width / (n * 1.5);
            double distanta = (r.Width - n * latime) / (n + 1);

            double max = lista.Max(l => l.NrCurse);
            if (max == 0) max = 1;
            Brush Br = Brushes.Blue;
            Font fontS = new Font("Arial", 8, FontStyle.Bold);

            Rectangle[] bars = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                double val = lista[i].NrCurse;
                bars[i] = new Rectangle(
                    (int)(r.X + (i + 1) * distanta + i * latime),
                    (int)(r.Y + r.Height - (val / max * r.Height)),
                    (int)latime,
                    (int)(val / max * r.Height)
                    );

                g.DrawString($"{val} ", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);

                g.DrawString($"Cod: {lista[i].Id}", fontS, Brushes.Black, bars[i].X, r.Bottom + 5);
            }
            g.FillRectangles(Br, bars);

        }
    }
}
