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

namespace SubTranzactie
{
    public partial class FormDB : Form
    {
        public FormDB()
        {
            InitializeComponent();
        }

        public void IncarcaraDinDB()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=ExtrasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Extrase", con);
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

            con.Close();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            IncarcaraDinDB();
        }
    }
}
