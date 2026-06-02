using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Seminar12_BD
{
    public partial class Form1 : Form
    {
        //stergem spatiile de la TrustServerCertificate  si cele de dupa ca sa nu crape!
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Facultate;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        //citire date din baza de date
        private void btnRead_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Studenti", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gvStudenti.DataSource = dt;
            connection.Close();
        }

        dgv.DataSource=null;
         dgv.DataSource=lista;
           

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormularStudent fms = new FormularStudent(); //instantiere
            fms.Show(); //ori cu showdialog 
        }


        public void IncarcaraDinDB()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=ExtrasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Extrase", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);// pt update//insert/delete
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            tbDb.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                tbDb.AppendText(dr["NumeClient"].ToString() + " | " +
                        dr["Adresa"].ToString() + " | " +
                        dr["Tranzactii"].ToString() +
                Environment.NewLine);
            }

            lvAutoriDB.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                Autor a = new Autor(dr["Nume"].ToString(),
                    dr["GradDidactic"].ToString(),
                    Convert.ToInt32(dr["Marca"])
                    );

                //daca am list< >
                List<float> greutati = new List<float>();

                if (dr["GreutateMarfa"] != DBNull.Value)
                {
                    string[] parts = dr["GreutateMarfa"].ToString().Split(',');

                    foreach (string p in parts)
                    {
                        if (float.TryParse(p, out float val))
                            greutati.Add(val);
                    }
                }
                --

                listaAutori.add(a);
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.Grad_didactic);
                itm.Tag = a;

                lvAutoriDB.Items.Add(itm);
            }



            con.Close();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            IncarcaraDinDB();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
                adapter.Update(dt); //update din gv +save
        }



        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public void SalvareBD()
        {
            con.Open();
            foreach (Hotel h in listaHoteluri)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Hoteluri(Locatie, NrStele) VALUES (@loc,@stele)", con);
                cmd.Parameters.AddWithValue("@loc", h.Locatie);
                cmd.Parameters.AddWithValue("@stele", h.NrStele);

                cmd.ExecuteNonQuery();

            }
            con.Close();
        }




        //desenare grafic tip bare ->cand e in altForm trb sa primeasac prin parametru lista
        public partial class FormGrafic : Form
        {
            List<Apartament> apartamente;
            public FormGrafic(List<Apartament> ap)
            {
                InitializeComponent();
                this.apartamente = ap;
            }

            private void panelGrafic_Paint(object sender, PaintEventArgs e)
            {
                if (apartamente == null || apartamente.Count == 0)
                    return;
                Graphics g = e.Graphics;
                Rectangle r = new Rectangle(panelGrafic.ClientRectangle.X + 20, panelGrafic.ClientRectangle.Y + 30,
                    panelGrafic.ClientRectangle.Width - 40, panelGrafic.ClientRectangle.Height - 70);

                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, r);

                int n = apartamente.Count;
                double latime = (double)r.Width / (n * 1.5);
                double distanta = (r.Width - n * latime) / (n + 1);

                double max = apartamente.Max(a => a.CalculSuprafata());
                if (max == 0) max = 1;
                Brush Br = Brushes.Blue;
                Font fontS = new Font("Arial", 8, FontStyle.Bold);

                Rectangle[] bars = new Rectangle[n];
                for (int i = 0; i < n; i++)
                {
                    double val = apartamente[i].CalculSuprafata();
                    bars[i] = new Rectangle(
                        (int)(r.X + (i + 1) * distanta + i * latime),
                        (int)(r.Y + r.Height - (val / max * r.Height)),
                        (int)latime,
                        (int)(val / max * r.Height)
                        );

                    g.DrawString($"{val} suprafata", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);

                    g.DrawString($"Apt{i + 1}", fontS, Brushes.Black, bars[i].X, r.Bottom + 5);
                }

                g.FillRectangles(Br, bars);
            }


        //desnerare grafic pie
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
            foreach (Rezervare rez in h.Rezervari)
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

            g.FillPie(b2, r, start, uD);

            g.DrawEllipse(pen, r);

            g.DrawString($"Single {single}", fontS, Brushes.Blue, r.Right + 10, r.Top + 20);
            g.DrawString($"Double {dubla}", fontS, Brushes.Red, r.Right + 10, r.Top + 50);
        }
    }

        //dupa pe aferSelect --cand avem paint in formPrincipal
        private void tvComanda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            panelGrafic.Invalidate(); //redeseneaza!
        }



        //salvare bmp
        private void salvare_bmp(Control c, string nume_fisier)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(nume_fisier);
            img.Dispose();
        }
        private void salvareBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare_bmp(panel1, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
            MessageBox.Show("S-a salvat imaginea!");
        }

        //preview
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }


        private void pp(Object sender, PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            float y = 20;

            foreach (ProgramStudiu p in lstPrograme)
            {
                e.Graphics.DrawString($"Program:{p.CodProgram}", fontTitlu, Brushes.Black, 20, y);
                y += 25;

                foreach (Candidat c in lstCandidati)
                {
                    e.Graphics.DrawString($"-{c.NumeCandidat}", fontText, Brushes.Black, 40, y);
                    y += 25;
                }
                y += 10;
            }
        }



        if (!int.TryParse(tbDurata.Text, out int rez) || rez<0)
            {
                errorProvider1.SetError(tbDurata, "Introduceti o val numerica");
                valid = false;
            }






        //DRAG & DROP
     private void lvAutori_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvAutori.SelectedItems.Count > 0)
            {
                lvAutori.DoDragDrop(lvAutori.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void tbAutori_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void tbAutori_DragDrop(object sender, DragEventArgs e)
        {
            if (lvPublicatii.SelectedItems.Count == 0)
                return;

            // autorul tras
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            Autor a = (Autor)item.Tag;

            // cartea selectata
            Carte c = (Carte)lvPublicatii.SelectedItems[0].Tag;


            // RELATIE 1:M
            if (!c.Autori.Contains(a))
                c.Autori.Add(a);

            // refresh textbox
            tbAutori.Text = "";
            foreach (Autor aut in c.Autori)
            {
                tbAutori.Text += aut.Nume + Environment.NewLine;
            }
        }



        //preluare din dgv
        Student s = lstStud[e.RowIndex];
        //preluare din lv
         if (lvAngajati.SelectedItems.Count == 0)
                return;
        Angajat a = (Angajat)lvAngajati.SelectedItems[0].Tag;
        //prealuare din lb
        Angajat a = (Angajat)lbAngajati.SelectedItem;

        //tv
        ComandaPizza pizza = (ComandaPizza)tvComanda.SelectedNode.Tag;


    //copy & paste

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



    private void btnFiltruSud_Click(object sender, EventArgs e)
    {
        var sud = listaCamere.Where(c => c.Orientare == Orientare.N).ToList();
        dgvCamere.DataSource = sud;
    }


     //sterger dgv
    private void button1_Click(object sender, EventArgs e)
    {
        if (dgvReg.CurrentRow != null)
        {
            listaReg.RemoveAt(dgvReg.CurrentRow.Index);
            AfisareGrid();

        }
    }

    //modificare la dublu click
    private void dgvReg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;
        Registration r = listaReg[e.RowIndex];

        tbNumeC.Text = r.CompanyName;
        tbPasses.Text = r.NoOfPasses.ToString();
        cmbAccesPack.SelectedValue = r.AccessId;

    }


    //desenare poligon
    public void DesenarePoligon()
    {
        Graphics g = e.Graphics;
        foreach (Poligon p in listaPoligoane)
        {
            if (p.Puncte.Count < 3)
                continue;

            Pen pen = new Pen(Color.FromName(p.Culoare), p.GrosimeLinie);
            Point[] puncte = new Point[p.Puncte.Count];
            for (int i = 0; i < p.Puncte.Count; i++)
                puncte[i] = new Point(p.Puncte[i].X, p.Puncte[i].Y);

            g.DrawPolygon(pen, puncte);
        }
    }


    //poligon perimetru
    public double CalculPerimetru()
    {
        double p = 0;
        for (int i = 0; i < puncte.Count; i++)
        {
            Punct a = puncte[i];
            Punct b = puncte[(i + 1) % puncte.Count];
            p += Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        return p;
    }


    //e.PageBounds.
    private void pp(object sender, PrintPageEventArgs e)
    {
        if (listaReg.Count == 0 || listaReg == null) return;

        Graphics g = e.Graphics;
        Rectangle r = new Rectangle(e.PageBounds.X + 20, e.PageBounds.Y + 30, e.PageBounds.Width - 40, e.PageBounds.Height - 70);

        Pen pen = new Pen(Color.Red, 2);
        g.DrawRectangle(pen, r);

        var grupare = listaReg.GroupBy(reg => reg.Pack.Nume).
            Select(p => new { Nume = p.Key, Count = p.Count() }).ToList();

        int n = grupare.Count;
        double latime = (double)r.Width / (n * 1.5);
        double distanta = (r.Width - n * latime) / (n + 1);

        double max = grupare.Max(x => x.Count);
        if (max == 0) max = 1;
        Brush Br = Brushes.Blue;
        Font fontS = new Font("Arial", 8, FontStyle.Bold);

        Rectangle[] bars = new Rectangle[n];
        for (int i = 0; i < n; i++)
        {
            double val = grupare[i].Count;
            bars[i] = new Rectangle(
                (int)(r.X + (i + 1) * distanta + i * latime),
                (int)(r.Y + r.Height - (val / max * r.Height)),
                (int)latime,
                (int)(val / max * r.Height)
                );

            g.DrawString($"{val}", fontS, Brushes.Black, bars[i].X, bars[i].Y - 20);

            g.DrawString($"Reg:{grupare[i].Nume}", fontS, Brushes.Black, bars[i].X, r.Bottom + 5);
        }

        g.FillRectangles(Br, bars);

    }


    public double LungimeTraseu
    {
        get
        {
            double lungime = 0;
            for (int i = 1; i < locatii.Count; i++)
            {
                int dx = locatii[i].X + locatii[i - 1].X;
                int dy = locatii[i].Y + locatii[i - 1].Y;
                lungime += Math.Sqrt(dx * dx + dy * dy);

            }
            return lungime;

        }
    }

    //desenare traseu
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        if (traseu.Locatii.Count == 0)
            return;

        Graphics g = e.Graphics;

        int dim = 10;

        for (int i = 0; i < traseu.Locatii.Count; i++)
        {
            int x = traseu.Locatii[i].X;
            int y = traseu.Locatii[i].Y;

            Rectangle r = new Rectangle(x - dim / 2, y - dim / 2, dim, dim);
            g.FillRectangle(Brushes.Red, r);

            if (i > 0)
            {
                g.DrawLine(Pens.Black, traseu.Locatii[i - 1].X, traseu.Locatii[i - 1].Y, x, y);
            }
        }
    }

    private void panel1_Resize(object sender, EventArgs e)
    {
        panel1.Invalidate();
    }
}


