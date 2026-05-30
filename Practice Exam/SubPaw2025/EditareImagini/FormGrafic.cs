using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditareImagini
{
    public partial class FormGrafic : Form
    {
        private List<Poligon> listaPoligon;
        public FormGrafic(List<Poligon> listaPol)
        {
            InitializeComponent();
            this.listaPoligon = listaPol;

           
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(Poligon p in listaPoligon)
            {
                if (p.Puncte.Count < 3)
                    continue;

                Pen pen = new Pen(Color.FromName(p.Culoare), p.GrosimeLinie);
                Point[] puncte=new Point[p.Puncte.Count];
                for (int i = 0; i < p.Puncte.Count; i++)
                    puncte[i] = new Point(p.Puncte[i].X, p.Puncte[i].Y);

                g.DrawPolygon(pen,puncte);
            }
        }
    }
}
