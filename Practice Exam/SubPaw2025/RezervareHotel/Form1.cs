using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervareHotel
{
    public partial class Form1 : Form
    {
        List<Hotel> listaHoteluri = new List<Hotel>();


        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        public void SalvareBD()
        {
            con.Open();
            foreach(Hotel h in listaHoteluri)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Hoteluri(Locatie, NrStele) VALUES (@loc,@stele)",con);
                cmd.Parameters.AddWithValue("@loc", h.Locatie);
                cmd.Parameters.AddWithValue("@stele", h.NrStele);

                cmd.ExecuteNonQuery();

            }
            con.Close();
        }

        private void btnAdaugareHotel_Click(object sender, EventArgs e)
        {
            FormHotel fh = new FormHotel();
            if (fh.ShowDialog() == DialogResult.OK)
            {
                listaHoteluri = fh.ListaHoteluri;
            }
        }

        private void btnAfisareHot_Click(object sender, EventArgs e)
        {
            tvHotel.Nodes.Clear();


            foreach (Hotel h in listaHoteluri)
            {
                TreeNode nodStele = null;
                foreach (TreeNode n in tvHotel.Nodes)
                {
                    if (n.Text == h.NrStele + " stele")
                    {
                        nodStele = n;
                        break;
                    }
                }
                if (nodStele == null)
                {
                    nodStele = new TreeNode(h.NrStele + " stele");
                    tvHotel.Nodes.Add(nodStele);
                }

                TreeNode nodHotel = new TreeNode(h.ToString());
                nodHotel.Tag = h;
                nodStele.Nodes.Add(nodHotel);

            }
            tvHotel.ExpandAll();
        }

        private void stergereHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = tvHotel.SelectedNode;
            if (nodSelectat == null ||nodSelectat.Tag==null)
            {
                MessageBox.Show("Selectează un hotel!");
                return;
            }
            Hotel h = (Hotel)nodSelectat.Tag;
            listaHoteluri.Remove(h);
            nodSelectat.Remove();
        }

        private void editareHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = tvHotel.SelectedNode;
            if (nodSelectat == null || nodSelectat.Tag == null)
            {
                MessageBox.Show("Selectează un hotel!");
                return;
            }
            Hotel h = (Hotel)nodSelectat.Tag;
            FormHotel fe=new FormHotel();
            if(fe.ShowDialog() == DialogResult.OK)
            {
                Hotel nou = fe.ListaHoteluri[fe.ListaHoteluri.Count - 1];
                h.Locatie = nou.Locatie;
                h.NrStele=nou.NrStele;
                h.Rezervari=nou.Rezervari;

                btnAfisareHot_Click(null, null);// refresh

            }
                
        }

        private void btnAdaugareRez_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = tvHotel.SelectedNode;
            if(nodSelectat==null || nodSelectat.Tag == null)
            {
                MessageBox.Show("Selectează un hotel!");
                return;
            }

            Hotel h=(Hotel)nodSelectat.Tag;
            try
            {
                StreamReader sr = new StreamReader("rezervare.txt");
                string linie;
                while((linie= sr.ReadLine()) != null )
                {
                    int idRezervare= int.Parse(linie.Split(';')[0]);
                    string numeClient = linie.Split(';')[1];
                    char tipC = char.Parse(linie.Split(';')[2]);
                    int durata = int.Parse(linie.Split(';')[3]);
                    double suma=double.Parse(linie.Split(';')[4]);
                    string data = linie.Split(';')[5];

                    Rezervare r=new Rezervare(idRezervare,numeClient, tipC, durata, suma,data);
                    h = h + r;
                    

                }
                sr.Close();
                btnAfisareHot_Click(null, null); // refresh
                MessageBox.Show("Rezevare adaugata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salvareInBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvareBD();
            FormDB fdb= new FormDB();
            fdb.Show();
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            TreeNode nodSelectat = tvHotel.SelectedNode;
            if (nodSelectat == null || nodSelectat.Tag == null)
            {
                return;
            }

            Hotel h = (Hotel)nodSelectat.Tag;

            if (h.Rezervari == null || h.Rezervari.Count == 0)
            {
                MessageBox.Show("Selectează un hotel cu rezervari!");
                return;
            }

            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 50, panelGrafic.ClientRectangle.Y + 30,
                panelGrafic.ClientRectangle.Width - 100, panelGrafic.ClientRectangle.Height - 80);

            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, r);

            int single = 0;
            int dubla = 0;
            foreach(Rezervare rez in h.Rezervari)
            {
                if (rez.TipCamera == 'S')
                    single++;
                else
                    dubla++;
            }

            int max = single + dubla;
            if (max == 0) return;

            Brush b1 = Brushes.Blue;
            Brush b2 = Brushes.Red;
            Font fontS = new Font("Arial", 9, FontStyle.Bold);


            float start = 0;
            float uS = (float)single / max * 360;
            float uD = (float)dubla / max * 360;

            g.FillPie(b1, r, start, uS);
            start += uS;

            g.FillPie(b2,r, start, uD);

            g.DrawEllipse(pen, r);

            g.DrawString($"Single {single}", fontS, Brushes.Blue, r.Right + 10, r.Top + 20);
            g.DrawString($"Double {dubla}", fontS, Brushes.Red, r.Right + 10, r.Top + 50);
        }

        private void tvHotel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panelGrafic.Invalidate();
        }
    }
}
