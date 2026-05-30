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

namespace Bibliografice
{
    public partial class FormDB : Form
    {
        List<Autor> autoriSelectati=new List<Autor>();
        public FormDB()
        {
            InitializeComponent();
        }

        public List<Autor> AutoriSelecati { get => autoriSelectati; }
        public void IncarcareDinDB()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=AutoriDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Autori",con);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            
            lvAutoriDB.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                Autor a = new Autor(dr["Nume"].ToString(),
                    dr["GradDidactic"].ToString(),
                    Convert.ToInt32(dr["Marca"])
                    );

                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.Grad_didactic);
                itm.Tag = a;

                lvAutoriDB.Items.Add(itm);
            }
            con.Close();

        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            IncarcareDinDB();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvAutoriDB.CheckedItems)
            {
                Autor a = (Autor)itm.Tag;
                AutoriSelecati.Add(a);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
