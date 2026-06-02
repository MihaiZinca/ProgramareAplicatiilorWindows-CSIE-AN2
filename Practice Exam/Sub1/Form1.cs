using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub1
{
    public partial class Form1 : Form
    {
        Statistica date=new Statistica();
        public Form1()
        {
            InitializeComponent();
            date.DateModif += AfisareLV;
        }

       

        public void AfisareLV()
        {
            lv.Items.Clear();
            for(int i=0;i<date.Observatii.Count;i++)
            {
                ListViewItem itm=new ListViewItem((i+1).ToString());
                itm.SubItems.Add(date.Observatii[i].ToString());
                itm.SubItems.Add(date.IndiciBaza[i].ToString());
                itm.Tag = i;
                lv.Items.Add(itm);
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if(double.TryParse(tbObsv.Text,out double val))
            {
                date.AdaugaObs(val);
                tbObsv.Clear();
            }
            else
            {
                MessageBox.Show("Valoare invalida");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(lv.SelectedItems.Count==0)
            {
                MessageBox.Show("Selecteaza o valoare");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            if(double.TryParse(tbObsv.Text,out double val))
            {
                date.Modifica(index, val);
            }
            else
            {
                MessageBox.Show("Valoare invalida");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o valoare");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            date.Sterge(index);
        }

        private void tbObsv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                if (double.TryParse(tbObsv.Text, out double val))
                {
                    date.AdaugaObs(val);
                    tbObsv.Clear();
                }
                else
                {
                    MessageBox.Show("Valoare invalida");
                }
            }
        }

        private void lv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (lv.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteaza o valoare");
                    return;
                }

                int index = (int)lv.SelectedItems[0].Tag;
                date.Sterge(index);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }

        private void pp(object sender, PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontText = new Font("Arial", 14);
            float y = 20;

            e.Graphics.DrawString("STATISTICI", fontText, Brushes.Black, 350, y);

            y += 40;
            for(int i=0;i<date.Observatii.Count;i++)
            {
                if (i == 0)
                    e.Graphics.DrawString($"{i + 1}. x0={date.Observatii[i]}", fontText, Brushes.Black, 20, y);
                else
                    e.Graphics.DrawString($"{i + 1}. x{i}={date.Observatii[i]} i{i} = {date.IndiciBaza[i]}", fontText, Brushes.Black, 20, y);
                y += 25;
    
            }
        }
    }
}
