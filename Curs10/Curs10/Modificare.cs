using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs10
{
    //fereastra nemodala! sa pot sa modific mai multe ,nu o mai inchid etc, navigez cum vreau
    public partial class Modificare : Form
    {
        BindingSource bds;
        public Modificare(BindingSource fbds)
        {
            InitializeComponent();
            bds = fbds;
            tbMarca.DataBindings.Add("Text", bds, "Marca"); //ii adaug o legatura
            tbNume.DataBindings.Add("Text", bds, "Nume");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); //ascund dar obiectul sa ramana
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingContext[bds].Position -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingContext[bds].Position += 1;
        }

        private void Modificare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            //nu mai las evenimentul sa se duca mai departe sa excute closing de la forma de baza
            e.Cancel = true; //anulare eveniment
        }
    }
}
