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
using System.Data.SqlClient;

namespace SubTranzactie
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        List<ExtrasCont> listaExtraseCl=new List<ExtrasCont>();


        ExtrasCont extrasSelectat;//pt desenare

        //stergem spatiile de la TrustServerCertificate  si cele de dupa ca sa nu crape!
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=ExtrasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }


        public void SalvareExtras()
        {
            con.Open();
            foreach (ExtrasCont ec in listaExtraseCl)
            {
                string tranzactii = "";
                foreach (Tranzactie t in ec.Tranzactii)
                    tranzactii += t.DetaliiTranzactie + ",";

                SqlCommand cmd = new SqlCommand("INSERT INTO Extrase (NumeClient,Adresa,Tranzactii) VALUES(@nume,@adresa,@tranzactii)", con);

                cmd.Parameters.AddWithValue("@nume", ec.NumeClient);
                cmd.Parameters.AddWithValue("@adresa", ec.Adresa);
                cmd.Parameters.AddWithValue("@tranzactii", tranzactii);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void btnAfisareEx_Click(object sender, EventArgs e)
        {
            FormExtras fe=new FormExtras();
            if(fe.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    listaExtraseCl.AddRange(fe.ListaExtrase);
                    lvAfisareExtrase.Items.Clear();

                    foreach(ExtrasCont ec in listaExtraseCl)
                    {
                        ListViewItem itm = new ListViewItem(ec.NumeClient);
                        itm.SubItems.Add(ec.Adresa);

                        string detalii = string.Join(",", ec.Tranzactii.Select(t => t.DetaliiTranzactie));
                        itm.SubItems.Add(detalii);
                        itm.Tag = ec;
                        lvAfisareExtrase.Items.Add(itm);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void stergereDateExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvAfisareExtrase.SelectedItems.Count>0)
            {
                ListViewItem itm = lvAfisareExtrase.SelectedItems[0];
                ExtrasCont ec=(ExtrasCont)itm.Tag;

                listaExtraseCl.Remove(ec);
                lvAfisareExtrase.Items.Remove(itm);
            }
        }

        private void modificareExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvAfisareExtrase.SelectedItems.Count>0)
            {
                ListViewItem itm = lvAfisareExtrase.SelectedItems[0];
                ExtrasCont ec = (ExtrasCont)itm.Tag;

                FormExtras fe = new FormExtras();
                if(fe.ShowDialog()==DialogResult.OK)
                {
                    ExtrasCont nou = fe.ListaExtrase[fe.ListaExtrase.Count-1];
                    ec.NumeClient = nou.NumeClient;
                    ec.Adresa= nou.Adresa;
                    ec.Tranzactii= nou.Tranzactii;

                    itm.Text = ec.NumeClient;
                    itm.SubItems[1].Text = ec.Adresa;
                    itm.SubItems[2].Text = string.Join(",", ec.Tranzactii.Select(t => t.DetaliiTranzactie));
                }
            }
        }
        private void lvAfisareExtrase_DoubleClick(object sender, EventArgs e)
        {
            if(lvAfisareExtrase.SelectedItems.Count>0)
            {
                ListViewItem itm = lvAfisareExtrase.SelectedItems[0];
                ExtrasCont ec = (ExtrasCont)itm.Tag;

                double suma = 0;
                foreach(Tranzactie t in ec.Tranzactii)
                {
                    suma += t.Suma;
                }

                double medie = 0;
                if (ec.Tranzactii.Count > 0)
                    medie = suma / ec.Tranzactii.Count;

                MessageBox.Show("Media tranzactiilor: "+ medie);
            }

        }

        private void salvareExtrasDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareExtras();
            FormDB fdb=new FormDB();
            fdb.Show();
        }

        private void lvAfisareExtrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvAfisareExtrase.SelectedItems.Count>0)
            {
                ListViewItem itm = lvAfisareExtrase.SelectedItems[0];
                extrasSelectat=(ExtrasCont)itm.Tag;
            }
        }

        private void bareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(extrasSelectat==null)
            {
                MessageBox.Show("Selecteaza un extras!");
                return;
            }
            panelGrafic.Invalidate();

        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            if (extrasSelectat == null) return;

            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 10, panelGrafic.ClientRectangle.Y + 10,
                panelGrafic.ClientRectangle.Width - 20, panelGrafic.ClientRectangle.Height - 20);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int n = extrasSelectat.Tranzactii.Count;

            double latime = (double)r.Width / (n * 1.5);
            double distanta = (r.Width - n * latime) / (n + 1);

            double max = extrasSelectat.Tranzactii.Max(t => t.Suma);

            Brush br = Brushes.Blue;

            Rectangle[] bars = new Rectangle[n];
            for(int i=0;i<n;i++)
            {
                double val = extrasSelectat.Tranzactii[i].Suma;

                bars[i] = new Rectangle(
                    (int)(r.X + (i + 1) * distanta + i * latime),
                    (int)(r.Y + r.Height - (val / max * r.Height)),
                    (int)latime,
                    (int)(val / max * r.Height)
                    );
            }

            g.FillRectangles(br, bars);

        }


    }
}
