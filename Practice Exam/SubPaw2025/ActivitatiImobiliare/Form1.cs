using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivitatiImobiliare
{
    public partial class Form1 : Form
    {
        List<Camera> listaCamere = new List<Camera>();
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            
        }

        public List<Apartament> CreeazaApartament()
        {
            List<Apartament> apartamente= new List<Apartament>();
            for(int i=0;i<listaCamere.Count;i+=2)
            {
                Apartament a=new Apartament();
                a.Camere.Add(listaCamere[i]);
                if (i + 1 < listaCamere.Count)
                    a.Camere.Add(listaCamere[i + 1]);
                apartamente.Add(a);
            }
            return apartamente;
        }


        public void IncarcareDinBD()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tblCamere;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            adapter = new SqlDataAdapter("SELECT * FROM tblCamere", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);// pt update//insert/delete
            dt =new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Camera c = new Camera(Convert.ToDouble(dr["Latime"]),
                    Convert.ToDouble(dr["Lungime"]),
                    (Orientare)Enum.Parse(typeof(Orientare), dr["Orientare"].ToString())
                    );
                listaCamere.Add(c);
            }
            con.Close();
            dgvCamere.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncarcareDinBD();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dt);
                MessageBox.Show("Date salvate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfisareGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fg=new FormGrafic(CreeazaApartament());
            fg.Show();
        }

        private void btnFiltruSud_Click(object sender, EventArgs e)
        {
            var sud = listaCamere.Where(c => c.Orientare == Orientare.N).ToList();
            dgvCamere.DataSource= sud;
        }
    }
}
