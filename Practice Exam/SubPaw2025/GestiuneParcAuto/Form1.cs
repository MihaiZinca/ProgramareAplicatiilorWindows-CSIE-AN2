using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneParcAuto
{
    public partial class Form1 : Form
    {
        List<Autocamion> listaAuto=new List<Autocamion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncarcareBD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Parc", con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            
            lvAuto.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {

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

                Autocamion a = new Autocamion(Convert.ToInt32(dr["Id"]),
                    dr["Proprietar"].ToString(),
                    Convert.ToSingle(dr["Pret"]),
                    Convert.ToInt32(dr["Nr_Locuri"]),
                    greutati,
                    Convert.ToInt32(dr["Nr_Curse"])
                    );


                listaAuto.Add(a);

                ListViewItem itm=new ListViewItem(a.Id.ToString());
                itm.SubItems.Add(a.Proprietar);
                itm.SubItems.Add(a.Pret.ToString());
                itm.SubItems.Add(a.NrLocuri.ToString());
                itm.SubItems.Add(string.Join(",", greutati));
                itm.SubItems.Add(a.NrCurse.ToString());
                itm.Tag = a;

                
                lvAuto.Items.Add(itm);

            }
            con.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (lvAuto.CheckedItems.Count==0)
            {
                MessageBox.Show("Bifeaza cel putin un camion!");
                return;
            }

            foreach(ListViewItem itm in lvAuto.CheckedItems)
            {
                Autocamion a=(Autocamion)itm.Tag;
                listaAuto.Remove(a);
                lvAuto.Items.Remove(itm);
                
            }
        }

        private void btnAfisareGrafic_Click(object sender, EventArgs e)
        {
            if (listaAuto.Count == 0)
                return;

            FormGrafic fg=new FormGrafic(listaAuto);
            fg.ShowDialog();
        }
    }
}
