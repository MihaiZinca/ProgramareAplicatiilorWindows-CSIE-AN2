using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Sub2
{
    public partial class Form1 : Form
    {
        Firma firma = new Firma("Firma");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugareAng_Click(object sender, EventArgs e)
        {
            try
            {
                string nume=tbNume.Text;
                int oreLucrat = Convert.ToInt32(tbOreLucrate.Text);
                float salariulOrar = float.Parse(tbSalariuOrar.Text, CultureInfo.InvariantCulture.NumberFormat);

                Angajat a = new Angajat(nume, oreLucrat, salariulOrar);
                a.calculeazaTotalSalariu();
                firma += a;
                MessageBox.Show("Angajat adaugat cu succes");

            }
            catch(ValidareEx ve)
            {
                MessageBox.Show(ve.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbOreLucrate.Clear();
                tbSalariuOrar.Clear();
            }
        }

        private void btnArata_Click(object sender, EventArgs e)
        {
            lvAngajati.Items.Clear();
            foreach(Angajat a in firma.ListaAngajati)
            {
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.OreLucrate.ToString());
                itm.SubItems.Add(a.SalariuOrar.ToString());
                itm.SubItems.Add(a.salariuLunar.ToString());
                lvAngajati.Items.Add(itm);
            }
        }

        private void lvAngajati_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                string mesaj = "";
                mesaj += "Nume: " + e.Item.Text + "\n";

                for (int i = 1; i < e.Item.SubItems.Count; i++)
                {
                    mesaj += e.Item.SubItems[i].Text + "\n";
                }

                MessageBox.Show(mesaj);
            } 
        }

        private void saveTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(firma.NumeFirma);
                foreach(Angajat a in firma.ListaAngajati)
                    sw.WriteLine(a.ToString());
                sw.Close();
                MessageBox.Show("Salvare txt realizata cu succes");
            }
        }

        private void openTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                lvAngajati.Items.Clear();
                string numeFirma=sr.ReadLine();
                string linie;
                while((linie=sr.ReadLine()) != null)
                {
                    ListViewItem itm = new ListViewItem(linie.Split('|')[0]);
                    itm.SubItems.Add(linie.Split('|')[1]);
                    itm.SubItems.Add(linie.Split('|')[2]);
                    itm.SubItems.Add(linie.Split('|')[3]);
                    lvAngajati.Items.Add(itm);
                }
                sr.Close();
                MessageBox.Show("Citire din txt realizata cu succes!");
            }
        }
    }
}
