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

namespace GestionareCredite
{
    public partial class Form1 : Form
    {

        List<Credit> lstCredite=new List<Credit>();
        public Form1()
        {
            InitializeComponent();
        }


        public void IncarcaDate()
        {
            StreamReader sr = new StreamReader("Credite.txt");
            string linie;
            while((linie= sr.ReadLine()) != null )
            {
                string client = linie.Split(',')[0];
                double valoare = double.Parse(linie.Split(',')[1]);
                double dobanda=double.Parse(linie.Split(',')[2]);
                DateTime data = DateTime.Parse(linie.Split(',')[3]);
                int perioada=int.Parse(linie.Split(',')[4]);

                Credit c=new Credit(client,valoare,dobanda,data,perioada);
                lstCredite.Add(c);
            }
            sr.Close();
            dgvCredite.DataSource = null;
            dgvCredite.DataSource = lstCredite;
        }
        private void btnAdaugaCredite_Click(object sender, EventArgs e)
        {
            FormCredite fc=new FormCredite();
            if(fc.ShowDialog() == DialogResult.OK )
            {
                lstCredite.AddRange(fc.ListaCredite);

                dgvCredite.DataSource = null;
                dgvCredite.DataSource = lstCredite;

            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvCredite.CurrentRow == null) return;

            Credit selectat = (Credit)dgvCredite.CurrentRow.DataBoundItem;
            FormEditare fe=new FormEditare(selectat);
            if(fe.ShowDialog() == DialogResult.OK )
            {
                dgvCredite.DataSource = null;
                dgvCredite.DataSource = lstCredite;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvCredite.CurrentRow == null) return;

            Credit c = (Credit)dgvCredite.CurrentRow.DataBoundItem;

            string text = c.Client + "," + c.Valoare + "," + c.Dobanda + "," + c.DataAcordare.ToString("yyyy-MM-dd") + "," + c.Perioada;

            Clipboard.SetText(text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;

            try
            {
                string[] p = Clipboard.GetText().Split(',');

                Credit c = new Credit(
                    p[0],
                    double.Parse(p[1]),
                    double.Parse(p[2]),
                    DateTime.Parse(p[3]),
                    int.Parse(p[4])
                );

                lstCredite.Add(c);

                dgvCredite.DataSource = null;
                dgvCredite.DataSource = lstCredite;
            }
            catch
            {
                MessageBox.Show("Date invalide în clipboard!");
            }
        }
    }
}
