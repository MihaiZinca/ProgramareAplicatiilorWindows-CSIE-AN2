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
                listaValori = new List<int>();
                foreach (DataGridViewRow rand in gv.Rows)
                    if (rand.Cells[0].Value != null) listaValori.Add(int.Parse(rand.Cells[0].Value.ToString())); // am pus if ca sa evit sa mi puna celula goala(Aia de apare mereu cand adaugi)

            }
            else
            {
                listaValori = null;
            }
            gr.ListaValoriGr=listaValori; //se duce in proop ListaValoriGr din Grafic

            

        }
    }
}
