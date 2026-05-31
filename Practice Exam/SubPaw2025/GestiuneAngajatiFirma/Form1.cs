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

namespace GestiuneAngajatiFirma
{
    public partial class Form1 : Form
    {
        List<Angajat> angajati=new List<Angajat>();
        List<Companie> companii = new List<Companie>();
        public Form1()
        {
            InitializeComponent();
            Companie c1 = new Companie(1, "Renault");
            Companie c2 = new Companie(2, "Oracle");
            Companie c3 = new Companie(3, "Google");
            companii.Add(c1);
            companii.Add(c2);
            companii.Add(c3);

            IncarcareDB();
        }

        public void IncarcareDB()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AngajatiDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ANGAJATI", con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);

            lvAngajati.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                Angajat a = new Angajat(dr["Nume"].ToString(), Convert.ToDateTime(dr["DataNasterii"]), Convert.ToInt32(dr["IdCompanie"]));
                angajati.Add(a);
                   
            }
            angajati.Sort();
            AfisareLV();
            con.Close();
        }

        public void AfisareLV()
        {
            lvAngajati.Items.Clear();
            foreach (Angajat a in angajati)
            {
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.DataNasterii.ToString());
                itm.SubItems.Add(a.IdCompanie.ToString());
                itm.Tag = a;

                lvAngajati.Items.Add(itm);
            }
        }
        private void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            FormAdaugare fm=new FormAdaugare(companii);
            if(fm.ShowDialog() == DialogResult.OK)
            {
                angajati.AddRange(fm.ListaAngajat);
                angajati.Sort();
                AfisareLV();
            }
        }

        private void lvAngajati_DoubleClick(object sender, EventArgs e)
        {
            if(lvAngajati.SelectedItems.Count==0)
            {
                MessageBox.Show("Selectati un angajat");
                return;
            }

            Angajat a = (Angajat)lvAngajati.SelectedItems[0].Tag;
            FormModificare fm = new FormModificare(a,companii);
            if(fm.ShowDialog() == DialogResult.OK)
            {
                angajati.Sort();
                AfisareLV();
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
            angajati.Sort();
            AfisareLV();
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            bool auCompanie = true;
            foreach(Angajat a in angajati)
            {
                if(!(bool)a)
                {
                    auCompanie = false;
                    break;
                }
            }
            if(auCompanie)
                MessageBox.Show("Au toti companie!");
            else MessageBox.Show("NU AU TOTI COMPANIE");

        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                XmlSerializer ser = new XmlSerializer(typeof(List<Angajat>));
                ser.Serialize(fs, angajati);
                fs.Close();
                MessageBox.Show("Salvare xml realizata cu succes");
            }
        }

        private void citireXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter= "(*.xml)|*.xml";
           if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                FileStream fs=new FileStream(openFileDialog1.FileName,FileMode.Open);
                XmlSerializer ser=new XmlSerializer(typeof(List<Angajat>));
                angajati = (List<Angajat>)ser.Deserialize(fs);
                fs.Close();
                angajati.Sort();
                AfisareLV();
                MessageBox.Show("Citire XML realizata cu succes");
            }
        }
    }
}
