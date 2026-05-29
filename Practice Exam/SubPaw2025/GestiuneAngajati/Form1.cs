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
using System.Xml.Serialization;

namespace GestiuneAngajati
{
    public partial class Form1 : Form
    {
        List<Angajat> angajati=new List<Angajat>();
        public Form1()
        {
            InitializeComponent();
            Companie c1 = new Companie(1, "Renault");
            Companie c2 = new Companie(2, "Oracle");
            Companie c3 = new Companie(3, "Google");

            IncarcareDINBD();
        }
        public void IncarcareDINBD()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AngajatiDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adatper = new SqlDataAdapter("SELECT * FROM ANGAJATI", con);
            DataTable dt=new DataTable();
            adatper.Fill(dt);

            lvAngajati.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                Angajat a = new Angajat(dr["Nume"].ToString(),
                   Convert.ToDateTime(dr["DataNasterii"]),
                   Convert.ToInt32(dr["IdCompanie"])
                    );

                angajati.Add(a);

                AfisareLV();
            }

            con.Close();

           
        }
        private void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            FormAdaugare fa= new FormAdaugare();
            if(fa.ShowDialog() == DialogResult.OK)
            {
                angajati = fa.ListaAngajati;
                AfisareLV();
            }
        }

        public void AfisareLV()
        {
            lvAngajati.Items.Clear();
            foreach(Angajat a in angajati)
            {
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.DataNasterii.ToString());
                itm.SubItems.Add(a.IdCompanie.ToString());
                itm.Tag = a;
                
                lvAngajati.Items.Add(itm);
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (lvAngajati.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un angajat");
                return;
            }

            Angajat a = (Angajat)lvAngajati.SelectedItems[0].Tag;
            angajati.Remove(a);
            AfisareLV();

        }

        private void lvAngajati_DoubleClick(object sender, EventArgs e)
        {
            if (lvAngajati.SelectedItems.Count == 0)
                return;

            Angajat a=(Angajat)lvAngajati.SelectedItems[0].Tag;
            FormModificare fm = new FormModificare(a);
            if(fm.ShowDialog()==DialogResult.OK)
            {
                AfisareLV();
            }
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            bool auCompanieToti = true;
            foreach(Angajat a in angajati)
            {
                if(!(bool)a)
                {
                    auCompanieToti=false;
                    break;
                }
            }
            if (auCompanieToti)
                MessageBox.Show("Au toti companie!");
            else MessageBox.Show("NU AU TOTI COMPANIE");


        }

        //salvare XML
        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.xml)|*.xml";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs=new FileStream(saveFileDialog1.FileName, FileMode.Create);
                XmlSerializer ser = new XmlSerializer(typeof(List<Angajat>));
                ser.Serialize(fs, angajati);
                fs.Close();
                MessageBox.Show("Salvare xml realizata cu succes");
            }
           
        }
        //citire XML
        private void citireXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                XmlSerializer ser = new XmlSerializer(typeof(List<Angajat>));
                angajati = (List<Angajat>)ser.Deserialize(fs);
                fs.Close();
                AfisareLV(); //daca nu in ce afisez eu
                MessageBox.Show("Citire XML realizata cu succes");
            }
        }


    }
}
