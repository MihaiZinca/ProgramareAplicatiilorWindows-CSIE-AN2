using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMaster
{
    public partial class FormGrafic : Form
    {
        List<Candidat> candidati;
        List<ProgramStudiu> programe;
        public FormGrafic(List<Candidat> c,List<ProgramStudiu> p)
        {
            InitializeComponent();
            candidati = c;
            programe = p;
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            if (programe == null || programe.Count == 0 || candidati == null) return;

            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 20, panelGrafic.ClientRectangle.Y + 30,
                panelGrafic.ClientRectangle.Width - 40, panelGrafic.ClientRectangle.Height - 70);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int n = programe.Count;

            int[] inscrisi = new int[n];
            for(int i=0;i<n;i++)
            {
                int codProg = programe[i].CodProgram;
                foreach(Candidat c in candidati)
                {
                    if (c.VectorOptiuni != null && c.VectorOptiuni.Contains(codProg))
                        inscrisi[i]++;
                }    
            }

            double latime = (double)r.Width / (n * 1.5);
            double distanta = (r.Width - n * latime) / (n + 1);

            double max = inscrisi.Max();
            if(max == 0) max = 1;

            Brush Br = Brushes.Blue;
            Font fontS = new Font("Arial", 8, FontStyle.Bold);

            Rectangle[] bars = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                double val = inscrisi[i];
                bars[i] = new Rectangle(
                    (int)(r.X + (i + 1) * distanta + i * latime),
                    (int)(r.Y + r.Height - (val / max * r.Height)),
                    (int)latime,
                    (int)(val / max * r.Height)
                    );

                g.DrawString($"{val} cand.", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);
                g.DrawString($"Cod: {programe[i].CodProgram}", fontS, Brushes.Black, bars[i].X, r.Bottom + 10);
            }
            g.FillRectangles(Br, bars);


        }
    }
}
