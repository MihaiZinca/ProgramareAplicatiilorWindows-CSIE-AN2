using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs9_grafic
{
    public partial class Form1 : Form
    {
        List<int> listaValori=null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void gv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //aici creez colectia

            if (gv.Rows.Count > 3)
            {
                //listaValori = new List<int>();
                //foreach (DataGridViewRow rand in gv.Rows)
                //    if (rand.Cells[0].Value != null) 
                //        listaValori.Add(int.Parse(rand.Cells[0].Value.ToString())); // am pus if ca sa evit sa mi puna celula goala(Aia de apare mereu cand adaugi)

                //echivaletente

                listaValori = gv.Rows.Cast<DataGridViewRow>().Where(rand=> rand.Cells[0].Value!=null).Select(rand => int.Parse(rand.Cells[0].Value.ToString())).ToList<int>();

            }
            else
            {
                listaValori = null;
            }
            gr.ListaValoriGr=listaValori; //se duce in proop ListaValoriGr din Grafic

            

        }

        private void gv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            gv_CellValueChanged(sender, null);

        }
    }
}
//to do!!
//sa bagam spliter container si in grid, si sa fie de tip orizontal, in partea sus lasam dgv, si in partea de jos sa ne da graf cu tituluri
//de incercat de intengraf graful asta cu ex de la curs ala cu salariati!-curs6