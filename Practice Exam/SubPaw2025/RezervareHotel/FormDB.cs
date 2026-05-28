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

namespace RezervareHotel
{
    public partial class FormDB : Form
    {
        public FormDB()
        {
            InitializeComponent();
        }

        public void IncarcareDinBD()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hoteluri", con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);

            tbDB.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                tbDB.AppendText(dr["Locatie"].ToString() +"|" + dr["NrStele"].ToString() +" stele" + Environment.NewLine);
            }
            
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            IncarcareDinBD();
        }
    }
}
