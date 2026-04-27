using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        Firma firma = new Firma("SRL");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                int oreL = Convert.ToInt32(tbOreL.Text);
                float salariuOrar = float.Parse(tbSalariuO.Text, CultureInfo.InvariantCulture.NumberFormat);
                Angajat a=new Angajat(nume, oreL, salariuOrar);
                a.CalculeazaTotalSalariu();
                firma += a;
                MessageBox.Show("Angajat adaugat cu succes!");

            }catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbOreL.Clear();
                tbSalariuO.Clear();
            }
        }

        private void btnAfisareLV_Click(object sender, EventArgs e)
        {
            lvAngajati.Items.Clear();
            foreach(Angajat a in firma.Angajati)
            {
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.OreLucrate.ToString());
                itm.SubItems.Add(a.SalariuOrar.ToString());
                itm.SubItems.Add(a.SalariuLunar.ToString());
                lvAngajati.Items.Add(itm);
            }
        }

        private void lvAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvAngajati.SelectedItems.Count > 0)
            {
                ListViewItem itm=lvAngajati.SelectedItems[0];
                string message = "Nume:" + itm.SubItems[0].Text +"\nOre lucrate:" + itm.SubItems[1].Text +"\nSal Orar: " + itm.SubItems[2].Text +
                    "\nSalariul lunar:"+itm.SubItems[3].Text;
                MessageBox.Show(message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(firma.NumeFirma);
                float total = 0;
                foreach (Angajat a in firma.Angajati)
                {
                    total += a.SalariuLunar;
                    sw.WriteLine(a.ToString());
                }
                sw.WriteLine("Valoarea totala a salariilor:" + total);
                sw.Close();
                MessageBox.Show("Salvare realizata cu succes!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbAngajati.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Citire realizata cu succes!");
            }
        }
    }
}
