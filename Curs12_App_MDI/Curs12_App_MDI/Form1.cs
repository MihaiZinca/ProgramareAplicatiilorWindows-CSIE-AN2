using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs12_App_MDI
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            i = 1;
        }

        private void fereastraNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fc = new Form2();
            fc.Text = "Document" + i.ToString();
            i++;
            fc.MdiParent = this;
            fc.Show();

        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void inchideFerestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in MdiChildren)
            {
                f.Close();
                f.Dispose();//scoate din memorie
            }
        }

        private void scriereDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                Form2 aux = (Form2)this.ActiveMdiChild;
                File.WriteAllText(aux.Text + ".txt", aux.tb.Text);
            }

        }

        private void citesteDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Form2 aux = (Form2)this.ActiveMdiChild;

                string numeFisier = aux.Text + ".txt";

                if (File.Exists(numeFisier))
                {
                    aux.tb.Text = File.ReadAllText(numeFisier);
                }
                else
                {
                    MessageBox.Show("Fisierul nu exista!");
                }
            }
        }

        //De facut operatia de citire
    }
}
