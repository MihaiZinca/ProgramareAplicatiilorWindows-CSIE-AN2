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

namespace ComenziPizza
{
    public partial class FormDB : Form
    {
        
        public FormDB()
        {
            InitializeComponent();
        }

        public ComandaPizza ComandaSelectata { get; set; }
        public void IncarcareDinBD()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ToppingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Topping", con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);

            lvDB.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                Topping t = new Topping(dr["Denumire"].ToString(),
                    Convert.ToSingle(dr["Pret"]), //pt float
                    Convert.ToSingle(dr["Cantitate"]),
                    Convert.ToInt32(dr["Cod"])
                    );
                ListViewItem itm = new ListViewItem(t.Cod.ToString());
                itm.SubItems.Add(t.Denumire);
                itm.SubItems.Add(t.Pret.ToString());
                itm.SubItems.Add(t.Cantitate.ToString());
                itm.Tag = t;
                lvDB.Items.Add(itm);
            } 
            con.Close();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            IncarcareDinBD();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvDB.CheckedItems)
            {
                Topping t = (Topping)itm.Tag;
                ComandaSelectata += t;
            }
            MessageBox.Show("Topping adaguat");

            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
