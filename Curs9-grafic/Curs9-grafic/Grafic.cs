using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs9_grafic
{
    public class Grafic : Control
    {
        List<int> listaValoriGrafica;
        public Grafic()
        {
            this.ResizeRedraw = true; //ce face?
            listaValoriGrafica = null; 

        }

        public List<int> ListaValoriGr 
        { 
            get => listaValoriGrafica;
            set 
            { 
                listaValoriGrafica = value;
                Invalidate(); //ridica evenimentul OnPaint (ev OnPaint este ridicat cand am folosit control, apoi este ridicat in mod implicit cand modific size ul controlului si acum cer cand sa il ridic) -invalidate=ridica evenimentul trasare evn in fereastra gen
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
           base.OnPaint(e);  //apleaza clasa de baza numita Control
           Graphics g=e.Graphics; //ca sa pot fac brush, pen etc;

            //am facut canvas ca sa trasez chenarul
            Rectangle canvas = new Rectangle
            {
                X = this.ClientRectangle.X + 10,
                Y = this.ClientRectangle.Y + 10,
                Width = this.ClientRectangle.Width - 20,//-10 st -10 dreapta
                Height = this.ClientRectangle.Height - 20
            };
            g.DrawRectangle(Pens.Blue, canvas);
            if(listaValoriGrafica != null && listaValoriGrafica.Count>2)
            {
                //trasare toate dreptung
                //Rectangle pt ordonate intregi
                //rectangleF ordonate reale
                RectangleF[] vrect = new RectangleF[listaValoriGrafica.Count];
                int i, maxv = listaValoriGrafica.Max();
                float distantaBara, latimeBara, stanga;

                //W=n*lb+(n+1)db --formula
                distantaBara = canvas.Width / (4 * listaValoriGrafica.Count + 1F);  //db=distanta bara
                latimeBara = 3F * distantaBara;
                for(i=0,stanga=canvas.X+distantaBara; i<listaValoriGrafica.Count;i++, stanga+=latimeBara+distantaBara)
                {
                    vrect[i].X = stanga;
                    vrect[i].Width = latimeBara;
                    vrect[i].Height = (float)listaValoriGrafica[i]/maxv * (float)canvas.Height;
                    //val observatiei/max
                    vrect[i].Y = canvas.Y + (canvas.Height - vrect[i].Height);
                }

                g.FillRectangles(Brushes.Red, vrect);


            }


            
        }
    }

}
